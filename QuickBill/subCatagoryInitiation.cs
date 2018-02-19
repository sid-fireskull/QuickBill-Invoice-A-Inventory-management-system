using QuickBill.Properties;
using System;
using System.Data;
using System.Data.SqlServerCe;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QuickBill
{
    public partial class subCatagoryInitiation : Form
    {
        public subCatagoryInitiation()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float pp, sp, qty;
            int qtyint;
            Regex rx = new Regex("([_])");

            if (subcattb.Text == "")
            {
                MessageBox.Show("Please enter a name of the item");
            }
            else if (selectcatcombo.Text == "")
            {
                MessageBox.Show("Please select a catagory of the item");
            }
            else if (stockqty.Text == "")
            {
                MessageBox.Show("Please enter stock quantity of the item");
            }
            else if (pprice.Text == "")
            {
                MessageBox.Show("Please enter purchased price per unit basis or float value");
            }
            else if (sellprice.Text == "")
            {
                MessageBox.Show("Please enter selling price per unit basis");
            }
            else if (!float.TryParse(pprice.Text, out pp))
            {
                MessageBox.Show("Please enter float value in Purchased price field");
            }
            else if (!float.TryParse(sellprice.Text, out sp))
            {
                MessageBox.Show("Please enter float value in Selling price field");
            }
            else if (!float.TryParse(stockqty.Text, out qty))
            {
                MessageBox.Show("Please insert a numeric value in stock Quantity Field");
            }
            else if(rx.IsMatch(subcattb.Text))
            {
                MessageBox.Show("'_' Charecter is not allowed in a sub-catagory Name");
            }
            else
            {
                dboperation operation = new dboperation();
                SqlCeConnection conn = operation.dbConnection(Settings.Default.DatabasePath);
                string checkdup = "SELECT sub_catagory.ItemName,catagory.Catagory FROM sub_catagory INNER JOIN catagory ON sub_catagory.undercatagory = catagory.CatId";
                if (mulabel.Text == "Measuring Unit: pcs")
                {
                    
                    if (!int.TryParse(stockqty.Text, out qtyint))
                    {
                        MessageBox.Show("Please mention integer value in stock quantity field when the selected item is measure in \"pcs\"");

                    }
                    else 
                    {
                        
                        if(sub_duplicate(conn, subcattb.Text, selectcatcombo.Text, checkdup))
                        {
                            MessageBox.Show("Duplicate entry found in the list, try other name");
                        }
                        else
                        {

                            InsertData();
                        }
                                                
                    }
                }
                else
                {
                    if (sub_duplicate(conn, subcattb.Text, selectcatcombo.Text, checkdup))
                    {
                        MessageBox.Show("Duplicate entry found in the list, try other name");
                    }
                    else
                    {
                        InsertData();
                    }

                    
                }                
                // Else Statement for other unit goes here
            }
        }
        private void subCatagoryInitiation_Load(object sender, EventArgs e)
        {
            try {
                SqlCeDataReader reader = null;
                dboperation operation = new dboperation();
                SqlCeConnection conn = null;
                conn = operation.dbConnection(Settings.Default.DatabasePath);
                string query = "SELECT Catagory FROM catagory";
                SqlCeCommand cmd = new SqlCeCommand(query, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    // Add Catagory List

                    selectcatcombo.Items.Add(reader.GetString(0));

                }
                load_subcat_gridview(conn);
                operation.closeDBConnection(conn);
            }
            catch (Exception ex)
            {

            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlCeDataReader reader = null;
                dboperation operation = new dboperation();
                SqlCeConnection conn = null;
                conn = operation.dbConnection(Settings.Default.DatabasePath);
                string query = "SELECT MeasuringUnit FROM catagory WHERE Catagory=@cat";
                SqlCeCommand cmd = new SqlCeCommand(query, conn);
                cmd.Parameters.AddWithValue("@cat", selectcatcombo.Text);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    // Measuring unit selection

                    mulabel.Text="Measuring Unit: "+reader.GetString(0);

                }
                operation.closeDBConnection(conn);
            }
            
            catch (Exception ex)
            {

            }
         }


        private void subCatList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void subCatDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private bool load_subcat_gridview(SqlCeConnection conn)
        {
            try
            {
                string selectquery = "SELECT sub_catagory.ItemId, sub_catagory.ItemName,sub_catagory.stock_Quantity,sub_catagory.purchase_price,sub_catagory.selling_price, catagory.Catagory, catagory.MeasuringUnit FROM sub_catagory INNER JOIN catagory ON sub_catagory.undercatagory = catagory.CatId ORDER BY sub_catagory.ItemId DESC";
                SqlCeDataAdapter adapter = new SqlCeDataAdapter(selectquery, conn);
                DataTable dt = new DataTable();
                subCatList.AutoGenerateColumns = false;
                adapter.Fill(dt);
                subCatList.DataSource = dt;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex);
                return false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var removesubcat = new rmvSubCatagory();
            foreach (DataGridViewRow row in subCatList.SelectedRows)
            {
                removesubcat.subcatnamermv.Text = row.Cells[1].Value.ToString();
                removesubcat.subcatpprmv.Text = row.Cells[2].Value.ToString();
                removesubcat.subcatqtyrmv.Text = row.Cells[3].Value.ToString();
                removesubcat.subcatsprmv.Text = row.Cells[4].Value.ToString();
                removesubcat.rmvscid.Text = row.Cells[0].Value.ToString();
                
                removesubcat.ShowDialog();
            }
            dboperation operation = new dboperation();
            SqlCeConnection conn = operation.dbConnection(Settings.Default.DatabasePath);
            load_subcat_gridview(conn);
            operation.closeDBConnection(conn);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var editsubcat = new editSubCatagory();
            foreach (DataGridViewRow row in subCatList.SelectedRows)
            {
                editsubcat.subcatnameupdate.Text = row.Cells[1].Value.ToString();
                editsubcat.subcatppupdate.Text = row.Cells[5].Value.ToString();
                editsubcat.subcatspupdate.Text = row.Cells[4].Value.ToString();
                editsubcat.subcatqtyupdate.Text = row.Cells[3].Value.ToString();
                editsubcat.scid.Text = row.Cells[0].Value.ToString();
                editsubcat.ShowDialog();
            }
            dboperation operation = new dboperation();
            SqlCeConnection conn = operation.dbConnection(Settings.Default.DatabasePath);
            load_subcat_gridview(conn);
            operation.closeDBConnection(conn);
        }

        // Insert Data to Database

        private void InsertData()
        {
            // Code for adding sub-catagory goes here
            string subcatname, scatagory;
            double purchase, selling;
            float stkqty;
            subcatname = subcattb.Text;
            scatagory = selectcatcombo.Text;
            stkqty = float.Parse(stockqty.Text);
            purchase = double.Parse(pprice.Text);
            selling = double.Parse(sellprice.Text);

            try
            {
                dboperation operation = new dboperation();
                SqlCeConnection conn = null;
                SqlCeDataReader reader = null;
                long catid = -1;
                conn = operation.dbConnection(Settings.Default.DatabasePath);
                string selectquery = "SELECT CatId FROM catagory WHERE Catagory=@cat";
                string insertquery = "INSERT INTO sub_catagory (ItemName,stock_Quantity,purchase_price,selling_price,undercatagory) VALUES(@item,@stock,@purchase,@sell,@ucat)";
                SqlCeCommand cmd = new SqlCeCommand(selectquery, conn);
                cmd.Parameters.AddWithValue("@cat", scatagory);

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    catid = reader.GetInt64(0);

                }

                int result;
                SqlCeCommand cmdinsert = new SqlCeCommand(insertquery, conn);
                cmdinsert.Parameters.AddWithValue("@item", subcatname);
                cmdinsert.Parameters.AddWithValue("@stock", stkqty);
                cmdinsert.Parameters.AddWithValue("@purchase", purchase);
                cmdinsert.Parameters.AddWithValue("@sell", selling);
                cmdinsert.Parameters.AddWithValue("@ucat", catid.ToString());
                result = cmdinsert.ExecuteNonQuery();
                if (result < 0)
                {
                    MessageBox.Show("An error occured while inserting the subcatagory in the database");
                }
                else
                {
                    //  MessageBox.Show("Item inserted Successfully");
                    load_subcat_gridview(conn);
                    subcattb.Clear();
                    selectcatcombo.ResetText();
                    stockqty.Clear();
                    pprice.Clear();
                    sellprice.Clear();
                }
                operation.closeDBConnection(conn);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }


        private bool sub_duplicate(SqlCeConnection conn, string subcatname, string cat,string query)
        {
            try
            {
                SqlCeDataReader reader = null;
                SqlCeCommand cmd = new SqlCeCommand(query, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (subcatname.ToLower() == reader.GetString(0).ToLower() && cat.ToLower()==reader.GetString(1).ToLower())
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured while checking for duplicate entry"+ex);
                return true;
            }
        }




    }
}

