using QuickBill.Properties;
using System;
using System.Data.SqlServerCe;
using System.Windows.Forms;

namespace QuickBill
{
    public partial class rmvSubCatagory : Form
    {
        public rmvSubCatagory()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void subcatrmvbtn_Click(object sender, EventArgs e)
        {
            dboperation operation = new dboperation();
            SqlCeConnection conn = null;
            conn=operation.dbConnection(Settings.Default.DatabasePath);
            string delquery = "DELETE FROM sub_catagory WHERE ItemId = @subcatid";

            try
            {
                SqlCeCommand cmd = new SqlCeCommand(delquery, conn);
                cmd.Parameters.AddWithValue("@subcatid", rmvscid.Text);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Happened while removing " + subcatnamermv.Text + " from the Catagory List" + ex);
            }
            operation.closeDBConnection(conn);
            this.Close();

        }
    }
}
