using System;
using System.Windows.Forms;
using QuickBill.Properties;
using System.Threading;
using System.Data.SqlServerCe;

namespace QuickBill
{
    public partial class loginPanel : Form
    {
        Thread thread;
        public loginPanel()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dboperation operation = new dboperation();
            if (!operation.keyvalidation())
            {
                this.Close();
                thread = new Thread(openreg);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
            int flag = 0;
            if (userselector.Text != null && passwd.Text != null)
            {
                flag=Authentication(userselector.Text, passwd.Text);
                if (flag==1)
                {
                    this.Close();
                    thread = new Thread(openPref);
                    thread.SetApartmentState(ApartmentState.STA);
                    thread.Start();
                }
                else if (flag == 2)
                {
                    this.Close();
                    thread = new Thread(openBill);
                    thread.SetApartmentState(ApartmentState.STA);
                    thread.Start();
                }
                else
                {
                    MessageBox.Show("Incorrect Login Credential", "Error");
                    passwd.Clear();
                }

            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                SqlCeDataReader reader = null;
                dboperation operation = new dboperation();
                SqlCeConnection conn = null;
                conn = operation.dbConnection(Settings.Default.DatabasePath);
                string query = "SELECT UserName FROM users";
                string checkregquery = "SELECT companyName,regkey FROM regdetails WHERE Id=1";
                if (!checkRegistration(conn, checkregquery))
                {
                    this.Close();
                    thread = new Thread(openreg);
                    thread.SetApartmentState(ApartmentState.STA);
                    thread.Start();
                }
                SqlCeCommand cmd = new SqlCeCommand(query, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    // Check wheather user exist or not
                    userselector.Items.Add(reader.GetString(0));
                    
                }
                
                operation.closeDBConnection(conn);
            }
            catch (Exception ex)
            {

            }
        }


        private bool checkRegistration(SqlCeConnection conn,string query)
        {
            string key="0";
            SqlCeCommand cmd = new SqlCeCommand(query, conn);
            SqlCeDataReader reader = null;
            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    if (reader.GetString(1) != ""&&reader.GetString(0)!="")
                    {
                        
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private int Authentication(String user, String pwd)
        {
            int flag = 0;
            if(user=="admin"&& pwd == Settings.Default.useradminpwd)
            {
                flag = 1;
            }
            else if(user !="admin")
            {
                dboperation operation = new dboperation();
                SqlCeConnection conn = null;
                conn=operation.dbConnection(Settings.Default.DatabasePath);
                SqlCeDataReader reader = null;
                try
                {
                    string query = "SELECT UserName,Password FROM users WHERE UserName=@user AND Password=@pwd";
                    SqlCeCommand cmd = new SqlCeCommand(query, conn);
                    cmd.Parameters.AddWithValue("@user",user);
                    cmd.Parameters.AddWithValue("@pwd",pwd);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        flag = 2;
                        
                    }                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(""+ex);
                }
            }
            
            return flag;
        }

        private void openPref(Object obj)
        {
            Application.Run(new Preferences());
        }
        private void openBill(Object obj)
        {
            Application.Run(new billing());
        }

        private void openreg(object obj)
        {
            Application.Run(new registration());
        }


        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
