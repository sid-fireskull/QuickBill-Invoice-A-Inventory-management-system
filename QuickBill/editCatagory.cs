using QuickBill.Properties;
using System;
using System.Data.SqlServerCe;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QuickBill
{
    public partial class editCatagory : Form
    {
        public editCatagory()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void catAddbtn_Click(object sender, EventArgs e)
        {
            float stax, ctax;
            Regex rx = new Regex("([_])");
            string query = "SELECT Catagory FROM catagory WHERE CatId!="+cid.Text;
            if (catnameupdate.Text == "")
            {
                MessageBox.Show("Please enter a catagory name");
            }
            else if (updatemu.Text == "")
            {
                MessageBox.Show("Please select a measuring unit to measure the catagory of items");
            }
            else if (!float.TryParse(updatecgst.Text, out stax))
            {
                MessageBox.Show("Please enter only numeric value in SGST field");
            }
            else if (!float.TryParse(updatecgst.Text, out ctax))
            {
                MessageBox.Show("Please enter only numeric value in CGST field");
            }
            else if (float.Parse(updatecgst.Text) > 99 || float.Parse(updatecgst.Text) < 0)
            {
                MessageBox.Show("CGST value is unacceptable (0 - 99)");
            }
            else if (float.Parse(updatesgst.Text) > 99 || float.Parse(updatesgst.Text) < 0)
            {
                MessageBox.Show("SGST value is unacceptable (0 - 99)");
            }
            else if (rx.IsMatch(catnameupdate.Text))
            {
                MessageBox.Show("'_' Charecter is not allowed in a Catagory Name");
            }
            else
            {
                try {
                    dboperation operation = new dboperation();
                    SqlCeConnection conn = null;
                    conn = operation.dbConnection(Settings.Default.DatabasePath);
                    string updatequery = "UPDATE catagory SET Catagory=@cat , sgst=@sgst, cgst=@cgst , MeasuringUnit=@mu  WHERE CatId= @id";
                    SqlCeCommand cmd = new SqlCeCommand(updatequery, conn);
                    if (!duplicate(conn, catnameupdate.Text,query))
                    {
                        cmd.Parameters.AddWithValue("@cat", catnameupdate.Text);
                        cmd.Parameters.AddWithValue("@sgst", updatesgst.Text);
                        cmd.Parameters.AddWithValue("@cgst",updatecgst.Text);
                        cmd.Parameters.AddWithValue("@mu", updatemu.Text);
                        cmd.Parameters.AddWithValue("@id", cid.Text);
                      //  MessageBox.Show(updatequery);
                        int result = cmd.ExecuteNonQuery();
                        operation.closeDBConnection(conn);
                        if (result != 0)
                        {
                            MessageBox.Show("Data Updated Successfully");

                        }
                    }
                    else
                    {
                        MessageBox.Show("Duplicate entry found in Database, please try another name");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("An Error occured to update the Catagory list "+ex);
                }
                this.Close();
            }
        }

        private bool duplicate(SqlCeConnection conn, string catname,string query)
        {
            try
            {
                
                SqlCeDataReader reader = null;
                SqlCeCommand cmd = new SqlCeCommand(query, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (catname.ToLower() == reader.GetString(0).ToLower())
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured while checking for duplicate entry");
                return true;
            }
        }

        private void editCatagory_Load(object sender, EventArgs e)
        {

        }

        private void cid_TextChanged(object sender, EventArgs e)
        {

        }

        private void catnameupdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void updatetax_TextChanged(object sender, EventArgs e)
        {

        }

        private void updatecgst_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
