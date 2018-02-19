using QuickBill.Properties;
using System;
using System.Data.SqlServerCe;
using System.Windows.Forms;

namespace QuickBill
{
    public partial class rmvCatagory : Form
    {
        public rmvCatagory()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void catAddbtn_Click(object sender, EventArgs e)
        {
            dboperation operation = new dboperation();
            SqlCeConnection conn = null;
            conn = operation.dbConnection(Settings.Default.DatabasePath);
            string query1 = "DELETE FROM sub_catagory WHERE undercatagory= @cat";
            string delquery = "DELETE FROM Catagory WHERE CatId= @cat";
            
            try
            {
                SqlCeCommand cmd = new SqlCeCommand(query1, conn);
                cmd.Parameters.AddWithValue("@cat", rmvcid.Text);
                cmd.ExecuteNonQuery();
                SqlCeCommand cmd2 = new SqlCeCommand(delquery, conn);
                cmd2.Parameters.AddWithValue("@cat", rmvcid.Text);
                cmd2.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Happened while removing "+catnamermv.Text+" from the Catagory List"+ex);
            }
            operation.closeDBConnection(conn);
            this.Close();
        }

        private void rmvCatagory_Load(object sender, EventArgs e)
        {

        }

        private void catmurmv_TextChanged(object sender, EventArgs e)
        {

        }

        private void catnamermv_TextChanged(object sender, EventArgs e)
        {

        }

        private void cattaxrmv_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void rmvcid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
