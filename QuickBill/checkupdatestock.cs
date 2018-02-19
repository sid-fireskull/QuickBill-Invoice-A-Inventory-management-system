using System;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using QuickBill.Properties;
using System.Data;

namespace QuickBill
{
    public partial class checkupdatestock : Form
    {
        public checkupdatestock()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void stockSearch_Click(object sender, EventArgs e)
        {

        }

        private void backBilling_Click(object sender, EventArgs e)
        {
          
        }

        private void stocksearchtxtbox_TextChanged(object sender, EventArgs e)
        {
            if (stocksearchtb.Text != null)
            {
                dboperation operation = new dboperation();
                SqlCeConnection conn = null;
                string selectquery = "SELECT sub_catagory.ItemId, sub_catagory.ItemName, sub_catagory.stock_Quantity, sub_catagory.purchase_price, sub_catagory.selling_price, catagory.MeasuringUnit, catagory.Catagory FROM sub_catagory INNER JOIN catagory ON catagory.CatId=sub_catagory.undercatagory WHERE sub_catagory.ItemName LIKE @itemname";
                conn = operation.dbConnection(Settings.Default.DatabasePath);
                
                try
                {
                    SqlCeDataAdapter adapter = new SqlCeDataAdapter(selectquery, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@itemname","%"+stocksearchtb.Text+"%");
                    DataTable dt = new DataTable();
                    itemdetails.AutoGenerateColumns = false;
                    adapter.Fill(dt);
                    itemdetails.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(""+ex);
                }
                
            }
            
        }

        private void updatestock_Click(object sender, EventArgs e)
        {
            try {
                var editsubcat = new editSubCatagory();
                foreach (DataGridViewRow row in itemdetails.SelectedRows)
                {
                    editsubcat.subcatnameupdate.Text = row.Cells[1].Value.ToString();
                    editsubcat.subcatppupdate.Text = row.Cells[5].Value.ToString();
                    editsubcat.subcatspupdate.Text = row.Cells[6].Value.ToString();
                    editsubcat.subcatqtyupdate.Text = row.Cells[2].Value.ToString();
                    editsubcat.scid.Text = row.Cells[0].Value.ToString();
                    editsubcat.subcatnameupdate.Enabled = false;
                    editsubcat.subcatppupdate.Enabled = false;
                    editsubcat.subcatspupdate.Enabled = false;
                    editsubcat.edititemheader.Text = "Update Stock";

                    editsubcat.ShowDialog();
                }
                dboperation operation = new dboperation();
                SqlCeConnection conn = operation.dbConnection(Settings.Default.DatabasePath);
                //  load_subcat_gridview(conn);
                operation.closeDBConnection(conn);
            }catch(Exception ex)
            {
                MessageBox.Show(""+ex);
            }
        }

        private void checkupdatestock_Activated(object sender, EventArgs e)
        {
            dboperation operation = new dboperation();
            SqlCeConnection conn = null;
            conn = operation.dbConnection(Settings.Default.DatabasePath);
            load_item_list(conn);
            
        }


        private bool load_item_list(SqlCeConnection conn)
        {

           string selectquery = "SELECT sub_catagory.ItemId, sub_catagory.ItemName, sub_catagory.stock_Quantity, sub_catagory.purchase_price, sub_catagory.selling_price, catagory.MeasuringUnit, catagory.Catagory FROM sub_catagory INNER JOIN catagory ON catagory.CatId=sub_catagory.undercatagory WHERE sub_catagory.ItemName LIKE @itemname";
            try
            {
                SqlCeDataAdapter adapter = new SqlCeDataAdapter(selectquery, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@itemname", "%" + stocksearchtb.Text + "%");
                DataTable dt = new DataTable();
                itemdetails.AutoGenerateColumns = false;
                adapter.Fill(dt);
                itemdetails.DataSource = dt;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                return false;
            }
        }
    }
}
