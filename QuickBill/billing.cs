using QuickBill.Properties;
using System;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace QuickBill
{
    public partial class billing : Form
    {

        Thread thread;
        string itemid,prefix;
        double stock_qty;
        Boolean stockflag = false;
        

        AutoCompleteStringCollection items;
        string quantity;
        public billing()
        {
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

       
        private void billstockbtn_Click(object sender, EventArgs e)
        {
            checkupdatestock myform = new checkupdatestock();
            myform.Show();
        }



        private void billing_Load(object sender, EventArgs e)
        {
            if (!withoutstock.Checked)
            {
                label11.Visible = false;
                manualinvoiceno.Visible = false;
                manualprefix.Visible = false;
                label17.Visible = false;
                manualinvoiceno.Text = "";
            }
            else
            {
                label11.Visible = true;
                manualinvoiceno.Visible = true;
                manualprefix.Visible = true;
                label17.Visible = true;
            }
            dboperation operation = new dboperation();
            SqlCeConnection conn = null;
            SqlCeDataReader reader = null;
            SqlCeDataReader reader2 = null;
            conn = operation.dbConnection(Settings.Default.DatabasePath);
            string selectquery = "SELECT sub_catagory.ItemName,catagory.Catagory FROM sub_catagory INNER JOIN catagory ON sub_catagory.undercatagory=catagory.CatId ORDER BY sub_catagory.ItemName";
            try {
                SqlCeCommand cmd = new SqlCeCommand(selectquery, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    searchItemcb.Items.Add(reader.GetString(0)+"_  -"+reader.GetString(1));                   
                }
                string query2 = "SELECT prefix FROM regdetails WHERE Id=1";
                SqlCeCommand cmd2 = new SqlCeCommand(query2,conn);
                reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    prefix = reader2.GetString(0);
                }

                operation.closeDBConnection(conn);
            }
            catch (Exception ex)
            {

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void searchItemcb_TextChanged(object sender, EventArgs e)
        {
            if (searchItemcb.Text == "")
            {
                currentstocklbl.Text = "";
            }
            dboperation operation = new dboperation();
            SqlCeConnection conn = null;
            SqlCeDataReader reader = null;
            conn = operation.dbConnection(Settings.Default.DatabasePath);
            string query = "SELECT sub_catagory.ItemId, sub_catagory.ItemName, sub_catagory.stock_Quantity, sub_catagory.purchase_price, sub_catagory.selling_price, catagory.MeasuringUnit, catagory.Catagory, catagory.sgst, catagory.cgst FROM sub_catagory INNER JOIN catagory ON catagory.CatId = sub_catagory.undercatagory WHERE sub_catagory.ItemName = @itemname";
            try {
                SqlCeCommand cmd = new SqlCeCommand(query, conn);
                char[] splitchar = { '_' };
                string itemcat = searchItemcb.Text;
                string[] temp = itemcat.Split(splitchar);
                // Regex.Match(searchItemcb.Text, @"\b($         $)\b")              
                cmd.Parameters.AddWithValue("@itemname",temp[0]);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    itemid = reader.GetInt64(0).ToString();
                    stock_qty = double.Parse(reader.GetString(2));
                    currentstocklbl.Text = "Current Stock of the " + temp[0] + " is " + stock_qty.ToString() + " " + reader.GetString(5).ToString();
                    billcat.Text = reader.GetString(6);
                    spricetb.Text = reader.GetDouble(4).ToString();
                    mu.Text = reader.GetString(5).ToString();
                    sgsttb.Text = reader.GetDouble(7).ToString();
                    cgsttb.Text = reader.GetDouble(8).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex);
            }
        }

        private void addbtnbill_Click(object sender, EventArgs e)
        {
            float dis;
            
            if (discounttb.Text == "")
            {
                discounttb.Text = "0";
            }
            if (searchItemcb.Text == "" && billcat.Text == "")
            {
                MessageBox.Show("Item or Catagory field can't be blank");
            }
            else if (!float.TryParse(discounttb.Text, out dis))
            {
                MessageBox.Show("Enter a numeric value of Discount Field");
            }
            else if (!searchItemcb.Items.Contains(searchItemcb.Text))
            {
                MessageBox.Show("Item not allowed");
            }
            else
            {
                
                string itemCol, descCol, MUCol, ISPCol, discountCol, sgstCol, cgstCol;
                double totalItemPrice;
                double qty = 0;

                quantityandconversion muconversion = new quantityandconversion();
                muconversion.itemmu.Text = mu.Text;
                muconversion.dataSent += muconversion_datasent;
                muconversion.ShowDialog();
                string itemcat = searchItemcb.Text;
                char[] splitchar = { '_' };
                string[] temp = itemcat.Split(splitchar);
                itemCol = temp[0];
                descCol = desc.Text;
                MUCol = mu.Text;
                double.TryParse(quantity, out qty);
                totalItemPrice = float.Parse(spricetb.Text) * qty;
                ISPCol = totalItemPrice.ToString();
                discountCol = discounttb.Text;
                cgstCol = sgsttb.Text;
                sgstCol = cgsttb.Text;
                bool flag = false;
                if (!withoutstock.Checked)
                {
                    string[] row = { itemid, itemCol, descCol, qty.ToString(), MUCol, ISPCol, discountCol, sgstCol, cgstCol };
                    if (stock_qty >= qty & totalItemPrice >= float.Parse(discounttb.Text))
                    {
                        if (billList.Rows.Count != 0)
                        {
                            
                            foreach (DataGridViewRow i in billList.Rows)
                            {

                                if (i.Cells[0].Value.ToString() == itemid)
                                {
                                    flag = true;
                                }
                            }
                            if (flag)
                            {
                                MessageBox.Show("Duplicate entry found in Billing List");
                            }
                            else
                            {
                                billList.Rows.Add(row);
                            }
                        }
                        else
                        {

                            billList.Rows.Add(row);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Entered Quantity exceeds the stock Quantity, Please Update stock Quantity before billing or Discount Amount is greater than amount of Total Price");
                    }
                }
                else
                {
                    string[] row = { itemid, itemCol, descCol, qty.ToString(), MUCol, ISPCol, discountCol, sgstCol, cgstCol };
                    billList.Rows.Add(row);
                    stockflag = true;
                }

            }
            discounttb.Clear();
            desc.Clear();
            searchItemcb.ResetText();

        }

        private void muconversion_datasent(string str)
        {
            
                quantity = str;
            
        }


        private void withoutstock_Click(object sender, EventArgs e)
        {
            if (!withoutstock.Checked)
            {
                withoutstock.Checked=true;
            }
            else
            {
                withoutstock.Checked = false;
            }
        }

        private void rmvbillitem_Click(object sender, EventArgs e)
        {
            if (billList.Rows.Count > 0)
            {
                billList.Rows.RemoveAt(billList.CurrentRow.Index);
            }
            else
            {
                MessageBox.Show("The List is Empty");
            }
        }

        private void Editqty_Click(object sender, EventArgs e)
        {
            double qty = double.Parse(quantity);
            quantityandconversion conv = new quantityandconversion();
            foreach (DataGridViewRow row in billList.SelectedRows)
            {
                conv.itemmu.Text = row.Cells[4].Value.ToString();
                conv.qtyac.Text = row.Cells[3].Value.ToString();
                conv.dataSent += muconversion_datasent;
                conv.ShowDialog();
                row.Cells[3].Value = quantity;
                row.Cells[5].Value = (double.Parse(quantity) * getSellingPrice(row.Cells[0].Value.ToString())).ToString();
            }

        }

        private double getSellingPrice(string itemid)
        {
            
            double sprice=0;
            dboperation operation = new dboperation();
            SqlCeConnection conn= operation.dbConnection(Settings.Default.DatabasePath);
            string query = "SELECT selling_price FROM sub_catagory WHERE ItemId=@id";
            SqlCeDataReader reader = null;
            try
            {
                SqlCeCommand cmd = new SqlCeCommand(query, conn);
                cmd.Parameters.AddWithValue("@id",itemid);
                reader=cmd.ExecuteReader();
                while (reader.Read())
                {
                    sprice = reader.GetDouble(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Happend while getting the Selling Price "+ex);
            }

            return sprice;
        }

        private void billList_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            withoutstock.Enabled = false;
        }

        private void billList_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if(billList.Rows.Count == 0)
            {
                withoutstock.Enabled = true;
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            long inv;
            if(withoutstock.Checked)
                {
                if (manualinvoiceno.Text == "" || !long.TryParse(manualinvoiceno.Text, out inv))
                {
                    MessageBox.Show("Invoice field is empty or Value is not numeric");
                    return;
                }
            }
            if (billList.Rows.Count == 0)
            {
                MessageBox.Show("No Items added in the List");
                return;
            }
            int count = 0;
            int flag = 0;
            FinalInvoice invoice = new FinalInvoice();
            foreach(DataGridViewRow row in billList.Rows)
            {
                invoice.ItemList.Rows.Add();
                invoice.ItemList.Rows[count].Cells[0].Value = row.Cells[0].Value.ToString();
                invoice.ItemList.Rows[count].Cells[1].Value = row.Cells[1].Value.ToString();
                invoice.ItemList.Rows[count].Cells[2].Value = row.Cells[2].Value.ToString();
                invoice.ItemList.Rows[count].Cells[3].Value = row.Cells[3].Value.ToString();
                invoice.ItemList.Rows[count].Cells[4].Value = row.Cells[4].Value.ToString();
                invoice.ItemList.Rows[count].Cells[5].Value = row.Cells[5].Value.ToString();
                invoice.ItemList.Rows[count].Cells[6].Value = row.Cells[6].Value.ToString();
                invoice.ItemList.Rows[count].Cells[7].Value = row.Cells[7].Value.ToString();
                invoice.ItemList.Rows[count].Cells[8].Value = row.Cells[8].Value.ToString();
                if (float.Parse(row.Cells[7].Value.ToString()) > 0 || float.Parse(row.Cells[8].Value.ToString()) > 0)
                {
                    flag = 1;
                }
                count++;
            }
            if (flag == 1)
            {
                invoice.finalsgsttb.Text = "0";
                invoice.finalcgsttb.Text = "0";
                invoice.finalsgsttb.Enabled = false;
                invoice.finalcgsttb.Enabled = false;
                
            }
            if (stockflag)
            {
                invoice.invoicenumber = manualinvoiceno.Text;
            }
            invoice.billForm = this;
            this.Visible = false;
            invoice.Show();
            
            
        }

        private void usrswitch_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(openlogin);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }


        private void openlogin(Object obj)
        {
            
            Application.Run(new loginPanel());
        }

        private void searchItemcb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void billing_Activated(object sender, EventArgs e)
        {
            if (!withoutstock.Checked)
            {
                label11.Visible = false;
                manualinvoiceno.Visible = false;
                manualprefix.Visible = false;
                label17.Visible = false;
                manualinvoiceno.Text = "";
            }
            else
            {
                label11.Visible = true;
                manualinvoiceno.Visible = true;
                manualprefix.Visible = true;                
                label17.Visible = true;
            }
        }

        private void usrswitch_MouseEnter(object sender, EventArgs e)
        {
            usrswitch.Font = new Font(usrswitch.Font.FontFamily, 9.75F, FontStyle.Underline);
            usrswitch.ForeColor = Color.BlueViolet;
        }

        private void usrswitch_MouseLeave(object sender, EventArgs e)
        {
            usrswitch.Font = new Font(usrswitch.Font.FontFamily, 9, FontStyle.Underline);
            usrswitch.ForeColor = Color.Blue;
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            billList.Rows.Clear();
            billList.Refresh();
        }

        private void withoutstock_CheckedChanged(object sender, EventArgs e)
        {
            if (withoutstock.Checked)
            {
                label11.Visible = true;
                manualprefix.Visible = true;
                manualinvoiceno.Visible = true;
                label17.Visible = true;
                manualprefix.Text = prefix;
            }
            else
            {
                label11.Visible = false;
                manualprefix.Visible = false;
                manualinvoiceno.Visible = false;
                manualinvoiceno.Text = "";
                label17.Visible = false;
            }
        }
    }
}
