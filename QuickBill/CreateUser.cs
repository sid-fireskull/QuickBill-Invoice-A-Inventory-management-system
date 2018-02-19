using System;
using System.Drawing;
using System.Windows.Forms;
using QuickBill.Properties;
using System.Data.SqlServerCe;
using System.Linq;
using System.Security.Cryptography;

namespace QuickBill
{
    public partial class CreateUser : Form
    {
        public CreateUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Createuserbtn_Click(object sender, EventArgs e)
        {
            string user, passwd1;
            passwd1 = newuserpwd1.Text;
            if (passwd1.Length < 5)
            {
                MessageBox.Show("Error! Password strength should be atleast 5 charecter long");
                newuserpwd1.Clear();
                newusrpwd2.Clear();
                return;
            }
            user = string.Concat(newuser.Text.Where(char.IsLetterOrDigit));

            try {
                SqlCeDataReader reader = null;
                dboperation operation = new dboperation();
                SqlCeConnection conn = null;
                conn= operation.dbConnection(Settings.Default.DatabasePath);
                string query = "SELECT UserName FROM users";
                SqlCeCommand cmd = new SqlCeCommand(query, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                         // Check wheather user exist or not
                    if (reader.GetString(0) == user)
                    {
                        MessageBox.Show("Username already exist, Please choose another one");
                        return;
                    }    
                }
               
                // Insert Username and Password to the Database

                query="INSERT INTO users (UserName,Password) VALUES (@usr,@pwd)";
                cmd = new SqlCeCommand(query,conn);
                cmd.Parameters.AddWithValue("@usr", user);
                cmd.Parameters.AddWithValue("@pwd", passwd1);
                int result=cmd.ExecuteNonQuery();
                if (result < 0)
                {
                    MessageBox.Show("Error Inserting New User");
                    return;
                }
                else
                {
                    MessageBox.Show("User: "+ user +" for billing created successfully");
                }
                
                this.Close();
                // MessageBox.Show("Insert new Record");
                operation.closeDBConnection(conn);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error Occured to create User: "+ ex);
            }
             
        }

        private void newusrpwdconfirm_TextChanged(object sender, EventArgs e)
        {
            if (newuserpwd1.Text == newusrpwd2.Text)
            {
                Createuserbtn.Enabled = true;
                Createuserbtn.BackColor = Color.LightSkyBlue;
            }
            else
            {
                Createuserbtn.Enabled = false;
                Createuserbtn.BackColor = Color.LightSteelBlue;
            }
        }

        private void CreateUser_Load(object sender, EventArgs e)
        {
            Createuserbtn.Enabled = false;
            Createuserbtn.BackColor = Color.LightSteelBlue;
        }

        private void newuser_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void newuser_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }


        // Hashing Function

        private string hashgenerator(string mystr)
        {
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(mystr);
            SHA1 hash = new SHA1CryptoServiceProvider();
            byte[] result = hash.ComputeHash(bytes);
            return result.ToString();
        }

    }
        
}
