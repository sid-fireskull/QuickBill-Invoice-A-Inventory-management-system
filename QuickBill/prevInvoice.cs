using QuickBill.Properties;
using System;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace QuickBill
{
    public partial class prevInvoice : Form
    {
        public prevInvoice()
        {
            InitializeComponent();
        }

        private void prevInvoice_Load(object sender, EventArgs e)
        {
            dboperation operation = new dboperation();
            SqlCeConnection conn= operation.dbConnection(Settings.Default.DatabasePath);
            string query = "SELECT prefix FROM regdetails WHERE Id=1";
            SqlCeCommand cmd = new SqlCeCommand(query, conn);
            SqlCeDataReader reader = null;
            try
            {
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    prefixtb.Text = reader.GetString(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void invoicenotb_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(invoicenotb.Text, "^[0-9]*$"))
            {
                invoicenotb.Text = "";
            }
        }

        private void invoicenotb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "^[0-9\b]*$"))
            {
                e.Handled = true;
            }
        }

        private void searchinvoicebtn_Click(object sender, EventArgs e)
        {
            FinalInvoice invoice = new FinalInvoice();
            // Disabling the controls of FinalInvoice
            invoice.custNametb.Enabled = false;
            invoice.addrtb.Enabled = false;
            invoice.mobiletb.Enabled = false;
            invoice.paymenttypecb.Enabled = false;
            invoice.paymentDetailstb.Enabled = false;
            invoice.finalsgsttb.Enabled = false;
            invoice.finalcgsttb.Enabled = false;

            dboperation operation = new dboperation();
            SqlCeConnection conn = operation.dbConnection(Settings.Default.DatabasePath);
            string query1 = "SELECT InvoiceNo, customerName, custAddress, custMobile, paymentDetails, totalSGST, totalCGST, totalDiscount, percentSGST, percentCGST, InvoiceTime FROM customerDetails WHERE InvoiceNo=@invoiceno"; // DATEPART(day,InvoiceTime), DATEPART(month,InvoiceTime), DATEPART(year,InvoiceTime)
            string query2 = "SELECT InvoiceNo,ItemName,quantity,TotalSellingPrice,TotalPurchasedPrice,perItemSGST,perItemCGST,discountPerItemType,measuringUnit,description FROM invoiceDetails WHERE InvoiceNo=@invoiceno";
//                                      0       1           2           3               4                   5           6           7                  8           9      
            string invoiceresult="";
            SqlCeCommand cmd1 = null;
            SqlCeCommand cmd2 = null;
            SqlCeDataReader reader = null;
            try
            {
                cmd1 = new SqlCeCommand(query1, conn);
                cmd1.Parameters.AddWithValue("@invoiceno",invoicenotb.Text);
                reader = cmd1.ExecuteReader();
                if (reader.Read())
                {
                    string temp;
                    string[] separator;
                    char[] tag= new char[] {'^'};
                    invoiceresult= reader.GetInt64(0).ToString();
                    invoice.invoicenumber = invoiceresult;
                    invoice.custNametb.Text = reader.GetString(1);
                    invoice.addrtb.Text = reader.GetString(2);
                    invoice.mobiletb.Text = reader.GetString(3);
                    temp = reader.GetString(4);
                    separator = temp.Split(tag);
                    invoice.paymenttypecb.Text = separator[0];
                    if (separator.Length > 1)
                    {
                        invoice.paymentDetailstb.Text = separator[1];
                    }
                    else
                    {
                        invoice.paymentDetailstb.Text = "";
                    }
                    invoice.finalsgsttb.Text = reader.GetString(8);
                    invoice.finalcgsttb.Text = reader.GetString(9);
                    invoice.dt = reader.GetDateTime(10);//Convert.ToDateTime(reader.GetInt32(10).ToString() + "/" + reader.GetInt32(11).ToString() + "/" + reader.GetInt32(12));
                }
                else
                {
                    MessageBox.Show("Invoice No: " + invoicenotb.Text + " not exist in the Database");
                }

                if (invoiceresult != "")
                {
                    int count = 0;
                    cmd2 = new SqlCeCommand(query2, conn);
                    SqlCeDataReader read = null;
                    cmd2.Parameters.AddWithValue("@invoiceno",invoiceresult);
                    read = cmd2.ExecuteReader();
                    
                    while (read.Read())
                    {
                        invoice.ItemList.Rows.Add();
                        invoice.ItemList.Rows[count].Cells[1].Value = read.GetString(1); // Item Name
                        invoice.ItemList.Rows[count].Cells[2].Value = read.GetString(9); // Description
                        invoice.ItemList.Rows[count].Cells[3].Value = read.GetString(2); // Quantity
                        invoice.ItemList.Rows[count].Cells[4].Value = read.GetString(8); // Measuring Unit
                        invoice.ItemList.Rows[count].Cells[5].Value = read.GetString(3); // Total Selling Price
                        invoice.ItemList.Rows[count].Cells[6].Value = read.GetString(7); // Total Discount per item
                        invoice.ItemList.Rows[count].Cells[7].Value = read.GetDouble(5); // percent SGST
                        invoice.ItemList.Rows[count].Cells[8].Value = read.GetDouble(6); // percent CGST
                        count++;
                    }
                    invoice.searchflag = true;
                    invoice.ShowDialog();

                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
    }
}
