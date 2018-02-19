using QuickBill.Properties;
using System;
using System.Data.SqlServerCe;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QuickBill
{
    public partial class editSubCatagory : Form
    {
        public editSubCatagory()
        {
            InitializeComponent();
        }

        private void subcatrmvbtn_Click(object sender, EventArgs e)
        {
            string selectquery = "SELECT catagory.MeasuringUnit FROM catagory INNER JOIN sub_catagory ON catagory.CatId=sub_catagory.undercatagory WHERE undercatagory!=" + scid.Text;
            string dupquery = "SELECT ItemName FROM sub_catagory WHERE ItemId != " + scid.Text;
            float pp, sp, qty;
            int qtyint, addqty;
            Regex rx = new Regex("([_])");
            if (subcatnameupdate.Text == "")
            {
                MessageBox.Show("Please enter Item name");
            }
            else if (subcatppupdate.Text == "")
            {
                MessageBox.Show("Please select a measuring unit to measure the catagory of items");
            }
            else if (!float.TryParse(subcatppupdate.Text, out pp))
            {
                MessageBox.Show("Please enter float value in Purchased price field");
            }
            else if (!float.TryParse(subcatspupdate.Text, out sp))
            {
                MessageBox.Show("Please enter float value in Selling price field");
            }
            else if (!float.TryParse(subcatqtyupdate.Text, out qty))
            {
                MessageBox.Show("Please insert a numeric value in stock Quantity Field");
            }
            else if (rx.IsMatch(subcatnameupdate.Text))
            {
                MessageBox.Show("'_' Charecter is not allowed in a sub-catagory Name");
            }
            else
            {

                if (getUnit(selectquery) == "pcs")
                {
                    if ((!int.TryParse(subcatqtyupdate.Text, out qtyint)) || (!int.TryParse(addqtytb.Text, out qtyint)))
                    {
                        MessageBox.Show("Please mention integer value in stock quantity or quantity to add field when the selected item is measure in \"pcs\"");

                    }
                    else
                    {
                        float total;
                        
                        
                            total = float.Parse(addqtytb.Text) + float.Parse(subcatqtyupdate.Text);
                        
                        
                        try
                        {
                            dboperation operation = new dboperation();
                            SqlCeConnection conn = null;
                            conn = operation.dbConnection(Settings.Default.DatabasePath);
                            string updatequery = "UPDATE sub_catagory SET ItemName=@item , stock_Quantity=@qty , purchase_price=@pp, selling_price=@sp  WHERE ItemId= @id";
                            SqlCeCommand cmd = new SqlCeCommand(updatequery, conn);
                            if (!duplicate(conn, subcatnameupdate.Text, dupquery))
                            {
                                cmd.Parameters.AddWithValue("@item", subcatnameupdate.Text);
                                cmd.Parameters.AddWithValue("@qty", total.ToString());
                                cmd.Parameters.AddWithValue("@pp", pp.ToString());
                                cmd.Parameters.AddWithValue("@sp", sp.ToString());
                                cmd.Parameters.AddWithValue("@id", scid.Text);
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
                        catch (Exception ex)
                        {
                            MessageBox.Show("An Error occured to update the Catagory list " + ex);
                        }
                        this.Close();
                    }
                }
            }
        }


        private bool duplicate(SqlCeConnection conn, string catname, string query)
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



        private string getUnit(string query)
        {
            dboperation operation = new dboperation();
            SqlCeConnection conn = null;          
            string result="";
            SqlCeDataReader reader = null;
            SqlCeCommand cmd = null;
            
            try
            {
                conn = operation.dbConnection(Settings.Default.DatabasePath);
                cmd = new SqlCeCommand(query, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result = reader.GetString(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex);
            }
            operation.closeDBConnection(conn);
            return result;
        }

        private void editSubCatagory_Load(object sender, EventArgs e)
        {
            addqtytb.Text = "0";
        }
    }
}
