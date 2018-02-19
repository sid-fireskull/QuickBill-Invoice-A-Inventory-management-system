using QuickBill.Properties;
using System;
using System.Data.SqlServerCe;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace QuickBill
{
    public partial class FinalInvoice : Form
    {
        internal string flagdate = "";
        internal string invoicenumber = "";
        string invoiceprefix = "";
        int ItemCount = 1;
        int spacer = 0;
        string cname = "", caddr = "", cmbl = "", cemail = "", cgstin = "", cvat = "", ccst = "", cpan = "";
        private double totalitemprice = 0, finalItemdiscount = 0, sgstamount = 0, cgstamount = 0, grandtotalprice = 0;
        private int itemPerPage = 0;
        private int numberOfItemsPrinted = 0;
        internal Boolean searchflag = false;
        internal DateTime dt=new DateTime();

        public FinalInvoice()
        {
            InitializeComponent();
        }

        public Form billForm { get; set; }


        private void custNametb_TextChanged(object sender, EventArgs e)
        {
            if (custNametb.Text != "" && paymenttypecb.Text!="")
            {
                printpreviewbtn.Enabled = true;
                saveprint.Enabled = true;
            }
            else
            {
                printpreviewbtn.Enabled = false;
                saveprint.Enabled = false;
            }
        }

        private void paymenttypecb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (custNametb.Text != "" && paymenttypecb.Text != null)
            {
                printpreviewbtn.Enabled = true;
                saveprint.Enabled = true;
            }
            else
            {
                printpreviewbtn.Enabled = false;
                saveprint.Enabled = false;
            }
        }

        private void printpreviewdialog_Load(object sender, EventArgs e)
        {

        }

        private void FinalInvoice_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!searchflag)
            {
                this.billForm.Show();
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void paymenttypecb_TextChanged(object sender, EventArgs e)
        {
            if (custNametb.Text != "" && paymenttypecb.Text != "")
            {
                printpreviewbtn.Enabled = true;
                saveprint.Enabled = true;
            }
            else
            {
                printpreviewbtn.Enabled = false;
                saveprint.Enabled = false;
            }
            if (paymenttypecb.Text == "Credit/Debit Card" || paymenttypecb.Text== "Others")
            {
                paymentDetailstb.Enabled = true;
            }
            else
            {              
                paymentDetailstb.Enabled = false;               
            }
        }

        private void saveprint_Click(object sender, EventArgs e)
        {
            string invoiceid;
            dboperation operation = new dboperation();
            SqlCeConnection conn = operation.dbConnection(Settings.Default.DatabasePath);

            string insertCustdetailsquery = "INSERT INTO customerDetails(customerName, custAddress,custMobile,paymentDetails ,totalSGST,totalCGST,totalDiscount,totalItemPrice,percentSGST,percentCGST,InvoiceTime) VALUES(@custname,@custaddr,@custmbl,@payment,@totalsgst,@totalcgst,@dis,@totaliprice,@percentcgst,@percentsgst,GETDATE())";

            string insertInvoicedetailsquery = "INSERT INTO invoiceDetails(InvoiceNo,ItemName,quantity,TotalSellingPrice,TotalPurchasedPrice,perItemSGST,perItemCGST,discountPerItemType,measuringUnit,description) VALUES(@invoiceno,@item,@qty,@itotalsp,@itotalpp,@peritemsgst,@peritemcgst,@itemdisc,@itemmu,@itemdesc)";

           
            if (invoicenumber != "")
            {
                printinvoice.Print();
                return;
            }
            invoiceid =insertinvoicedata1(conn, insertCustdetailsquery);
            if (invoiceid != "-1")
            {
                MessageBox.Show(invoiceid);
                invoicenumber = invoiceid;
                insertinvoicedata2(conn, insertInvoicedetailsquery);
                updatestock(conn);
                printinvoice.Print();
            }
            else
            {
                MessageBox.Show("Error Occured While printing and Saving Invoice");
            }           
        }

        private void updatestock(SqlCeConnection conn)
        {
            double current_stock=0, updated_stock=0;
            long id;
            string Itemselectquery = "SELECT stock_Quantity FROM sub_catagory WHERE ItemId=";
            string Itemstockupdate = "UPDATE sub_catagory SET stock_Quantity=@updateItemstock WHERE ItemId=@id";
                        
            SqlCeDataReader reader1 = null;

            try
            {
                foreach (DataGridViewRow row in ItemList.Rows)
                {
                    
                    SqlCeCommand cmd1 = new SqlCeCommand(Itemselectquery+row.Cells[0].Value.ToString(), conn);
                    reader1 = cmd1.ExecuteReader();
                    while (reader1.Read())
                    {
                        current_stock = double.Parse(reader1.GetString(0));
                    }
                    updated_stock = current_stock - double.Parse(row.Cells[3].Value.ToString());

                    SqlCeCommand cmd2 = new SqlCeCommand(Itemstockupdate, conn);
                    cmd2.Parameters.AddWithValue("@updateItemstock", updated_stock.ToString());
                    cmd2.Parameters.AddWithValue("@id", row.Cells[0].Value.ToString());
                    cmd2.ExecuteNonQuery();
                    cmd2 = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            

        }

        private string insertinvoicedata1(SqlCeConnection conn,string query)
        {
            string id="-1";
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@custname", custNametb.Text);
                cmd.Parameters.AddWithValue("@custaddr", addrtb.Text);
                cmd.Parameters.AddWithValue("@custmbl", mobiletb.Text);
                cmd.Parameters.AddWithValue("@payment", paymenttypecb.Text + "^" + paymentDetailstb.Text);
                cmd.Parameters.AddWithValue("@totalsgst", totalsgsttb.Text);
                cmd.Parameters.AddWithValue("@totalcgst", totalcgsttb.Text);
                cmd.Parameters.AddWithValue("@dis", totalDiscounttb.Text);
                cmd.Parameters.AddWithValue("@percentcgst", finalsgsttb.Text);
                cmd.Parameters.AddWithValue("@percentsgst", finalcgsttb.Text);
                cmd.Parameters.AddWithValue("@totaliprice", totalPricetb.Text);
            //    cmd.Parameters.Add("@datenow",System.Data.SqlDbType.DateTime).Value=DateTime.Now;
                try
                {
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "SELECT @@IDENTITY";
                    id =  cmd.ExecuteScalar().ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(""+ex);
                }
            }
            return id.ToString();
        }

        private void insertinvoicedata2(SqlCeConnection conn,string query)
        {
            double bucket;
            
            SqlCeCommand cmd = new SqlCeCommand(query,conn);
            try {
                foreach (DataGridViewRow row in ItemList.Rows) {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@invoiceno", invoicenumber);
                    cmd.Parameters.AddWithValue("@item", row.Cells[1].Value.ToString());
                    cmd.Parameters.AddWithValue("@qty", row.Cells[3].Value.ToString());
                   // bucket = float.Parse(row.Cells[5].Value.ToString()) * float.Parse(row.Cells[3].Value.ToString());
                    cmd.Parameters.AddWithValue("@itotalsp", row.Cells[5].Value.ToString());
                    bucket = getpurchashedprice(row.Cells[0].Value.ToString(), conn) * float.Parse(row.Cells[3].Value.ToString());
                    cmd.Parameters.AddWithValue("@itotalpp", bucket.ToString());
                    cmd.Parameters.AddWithValue("@peritemsgst", row.Cells[7].Value.ToString());
                    cmd.Parameters.AddWithValue("@peritemcgst", row.Cells[8].Value.ToString());
                    cmd.Parameters.AddWithValue("@itemdisc", row.Cells[6].Value.ToString());
                    cmd.Parameters.AddWithValue("@itemmu", row.Cells[4].Value.ToString());
                    cmd.Parameters.AddWithValue("@itemdesc", row.Cells[2].Value.ToString());
                    cmd.ExecuteNonQuery();
                }
               // return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting data to invoice table " +ex);
               // return false;
            }
        }



        private double getpurchashedprice(string id,SqlCeConnection conn)
        {
            double pp = -1;
            SqlCeDataReader reader = null;
            string query = "SELECT purchase_price FROM sub_catagory WHERE ItemId = @id";
            SqlCeCommand cmd = new SqlCeCommand(query, conn);
            cmd.Parameters.AddWithValue("@id",id);
            try
            {
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    pp =  reader.GetDouble(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while extracting purchashed price from Database "+ex);
            }
            return pp;
        }

        private void calculation()
        {
           
            double bucket = 0;
            totalitemprice = 0; finalItemdiscount = 0; sgstamount = 0; cgstamount = 0; grandtotalprice = 0;
            foreach (DataGridViewRow row in ItemList.Rows)
            {

                // Cell 5= Per Item Selling Price
                totalitemprice = double.Parse(row.Cells[5].Value.ToString())+totalitemprice;
                // Cell 6= Per Item Discount
                finalItemdiscount = double.Parse(row.Cells[6].Value.ToString()) + finalItemdiscount;
                // bucket= per item Selling Price- per item Discount
                bucket = double.Parse(row.Cells[5].Value.ToString()) - double.Parse(row.Cells[6].Value.ToString());
                // sgstamount per item= (percent sgst[cell 7]/100)*bucket[Item price after Discount]
                if (double.Parse(row.Cells[7].Value.ToString()) > 0)
                {
                    sgstamount = ((double.Parse(row.Cells[7].Value.ToString())/100)* bucket)+sgstamount;
                }
                // cgstamount per item= (percent cgst[cell 7]/100)*bucket[Item price after Discount]
                if (double.Parse(row.Cells[8].Value.ToString()) > 0)
                {
                    cgstamount = ((double.Parse(row.Cells[8].Value.ToString())/100)* bucket)+cgstamount;
                }                
            }

            // Total Item Price put into the Total Price Textbox
            totalPricetb.Text = totalitemprice.ToString();
            // Total Discount put into the Discount Textbox
                totalDiscounttb.Text = finalItemdiscount.ToString();
            
            // SGST for overall item
            if (sgstamount > 0)
            {
                totalsgsttb.Text = sgstamount.ToString();
            }
            else
            {
                // Changing here
                sgstamount=totalitemprice* double.Parse(finalsgsttb.Text)/100 ;
                totalsgsttb.Text = sgstamount.ToString();
           }

            // CGST for overall item
            if (cgstamount > 0)
            {
                totalcgsttb.Text = cgstamount.ToString();
            }
            else
            {
                // Changing here
              cgstamount = totalitemprice * double.Parse(finalcgsttb.Text) / 100;
                totalcgsttb.Text = cgstamount.ToString();
            }
            grandtotalprice = (totalitemprice + sgstamount + cgstamount) - finalItemdiscount;
            grandtotaltb.Text = grandtotalprice.ToString();
        }

        private void FinalInvoice_Load(object sender, EventArgs e)
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
                    invoiceprefix = reader.GetString(0);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(""+ex);
            }
           
            calculation();
        }

        private void finalsgsttb_TextChanged(object sender, EventArgs e)
        {
            float result = 0;
            if(!float.TryParse(finalsgsttb.Text, out result))
            {
                finalsgsttb.Text = "0";
            }
            else
            {
                calculation();
            }            
        }

        private void finalcgsttb_TextChanged(object sender, EventArgs e)
        {
            float result = 0;
            if (!float.TryParse(finalcgsttb.Text, out result))
            {
                finalcgsttb.Text = "0";
            }
            else
            {
                calculation();
            }

        }

        private void printpreviewbtn_Click(object sender, EventArgs e)
        {
            
            printpreviewdialog.Document = printinvoice;
            printpreviewdialog.ShowDialog();
            
            
        }

        private void printinvoice_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            

            dboperation operation = new dboperation();
            SqlCeConnection conn = operation.dbConnection(Settings.Default.DatabasePath);
            SqlCeCommand cmd = null;
            byte[] photo_array = null;
            SqlCeDataReader reader = null;
            MemoryStream ms = new MemoryStream();
            Bitmap bitmap=null;
            string selectquery = "SELECT Id,companyName, companyAddr, companyMobile, companyEmail, companygstin, companyVAT, companyCST, companyPAN, regkey,logo FROM regdetails WHERE Id=1";

            cmd = new SqlCeCommand(selectquery, conn);
            try
            {
               
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    cname = reader.GetString(1);
                    caddr = reader.GetString(2);
                    cmbl = reader.GetString(3);
                    cemail = reader.GetString(4);
                    cgstin = reader.GetString(5);
                    cvat = reader.GetString(6);
                    ccst = reader.GetString(7);
                    cpan = reader.GetString(8);
                    photo_array = (byte[])reader["logo"];
                    MemoryStream mes = new MemoryStream(photo_array);
                    bitmap = new Bitmap(mes);
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

            Image logoimg = bitmap;



            e.Graphics.DrawString("Invoice",new Font("Arial",13,FontStyle.Regular),Brushes.Black,new Point(390,28));
            e.Graphics.DrawImage(logoimg, 40, 63, 30, 30);
            e.Graphics.DrawLine(new Pen(Color.Black, 3), 29, 57, 795, 57);
            e.Graphics.DrawLine(new Pen(Color.Black, 3), 29, 57, 29, 1050);
            e.Graphics.DrawLine(new Pen(Color.Black, 3), 795, 57, 795, 1050);
            e.Graphics.DrawLine(new Pen(Color.Black, 3), 29, 1050, 795, 1050);

            e.Graphics.DrawLine(new Pen(Color.Black, 1), 550, 57, 550, 212);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 550, 90, 795, 90);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 550, 120, 795, 120);

            e.Graphics.DrawLine(new Pen(Color.Black, 3), 29, 212, 795, 212);
           



            // Buyer Information segment

            e.Graphics.DrawLine(new Pen(Color.Black, 2), 29, 310, 795, 310);


            // Item Table drawing 

            e.Graphics.DrawLine(new Pen(Color.Black, 2), 29, 355, 795, 355);

            e.Graphics.DrawLine(new Pen(Color.Black, 2), 55, 310, 55, 880);
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 380, 310, 380, 880);
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 435, 310, 435, 880);
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 510, 310, 510, 880);
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 558, 310, 558, 880);
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 632, 310, 632, 880);
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 698, 310, 698, 880);
            //  e.Graphics.DrawLine(new Pen(Color.Black, 2), , 250, , 1070);


            using (Font font1 = new Font("Arial", 11, FontStyle.Italic, GraphicsUnit.Point))
            {
                RectangleF rectF1 = new RectangleF(280, 1058, 400, 30);
                e.Graphics.DrawString("[This is Computer generated document]", font1, Brushes.Black, rectF1);
                e.Graphics.DrawRectangle(Pens.Transparent, Rectangle.Round(rectF1));
            }
            

            // company Name


            using (Font font1 = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point))
            {
                RectangleF rectF1 = new RectangleF(77, 65, 490, 32);
                e.Graphics.DrawString(cname, font1, Brushes.Black, rectF1);
                e.Graphics.DrawRectangle(Pens.Transparent, Rectangle.Round(rectF1));
            }

            // Company Address


            using (Font font1 = new Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point))
            {
                RectangleF rectF1 = new RectangleF(35,100,490,40);
                e.Graphics.DrawString(caddr, font1, Brushes.Black, rectF1);
                e.Graphics.DrawRectangle(Pens.Transparent, Rectangle.Round(rectF1));
            }


            // Company Email

            using (Font font1 = new Font("Arial", 11, FontStyle.Regular, GraphicsUnit.Point))
            {
                RectangleF rectF1 = new RectangleF(35, 145, 400, 30);
                e.Graphics.DrawString("Email: "+cemail, font1, Brushes.Black, rectF1);
                e.Graphics.DrawRectangle(Pens.Transparent, Rectangle.Round(rectF1));
            }

            // Company Phone Number


            using (Font font1 = new Font("Arial", 11, FontStyle.Regular, GraphicsUnit.Point))
            {
                RectangleF rectF1 = new RectangleF(35, 165, 400, 20);
                e.Graphics.DrawString("Contact No. : " + cmbl, font1, Brushes.Black, rectF1);
                e.Graphics.DrawRectangle(Pens.Transparent, Rectangle.Round(rectF1));
            }

            // Company VAT TIN

            if (cvat != "0")
            {
                using (Font font1 = new Font("Arial", 11, FontStyle.Regular, GraphicsUnit.Point))
                {
                    RectangleF rectF1 = new RectangleF(35, 185, 400, 25);
                    e.Graphics.DrawString("Company's VAT TIN - "+cvat , font1, Brushes.Black, rectF1);
                    e.Graphics.DrawRectangle(Pens.Transparent, Rectangle.Round(rectF1));
                }
            }

            // Invoice Number

            using (Font font1 = new Font("Arial", 11, FontStyle.Regular, GraphicsUnit.Point))
            {
                string temp = (invoiceprefix + invoicenumber).Replace(" ", string.Empty);
                RectangleF rectF1 = new RectangleF(553, 64, 260, 30);
                e.Graphics.DrawString("Invoice No.- " +temp, font1, Brushes.Black, rectF1);
                e.Graphics.DrawRectangle(Pens.Transparent, Rectangle.Round(rectF1));
            }

            // Invoice Date

            using (Font font1 = new Font("Arial", 11, FontStyle.Regular, GraphicsUnit.Point))
            {

                if (dt==default(DateTime))
                {
                    RectangleF rectF1 = new RectangleF(556, 95, 254, 30);
                    e.Graphics.DrawString("Dated - " + DateTime.Now.Date.ToString("dd/MM/yyyy"), font1, Brushes.Black, rectF1);
                    e.Graphics.DrawRectangle(Pens.Transparent, Rectangle.Round(rectF1));
                }
                else
                {
                    RectangleF rectF1 = new RectangleF(556, 95, 254, 30);
                    e.Graphics.DrawString("Dated - " + dt.ToString("dd/MM/yyyy"), font1, Brushes.Black, rectF1);
                    e.Graphics.DrawRectangle(Pens.Transparent, Rectangle.Round(rectF1));
                }
            }
            

            // GSTIN number

            using (Font font1 = new Font("Arial", 11, FontStyle.Bold, GraphicsUnit.Point))
            {
                RectangleF rectF1 = new RectangleF(556, 130, 260, 25);
                e.Graphics.DrawString("GSTIN/UIN - "+cgstin, font1, Brushes.Black, rectF1);
                e.Graphics.DrawRectangle(Pens.Transparent, Rectangle.Round(rectF1));
            }

            // Company CST Number

            using (Font font1 = new Font("Arial", 11, FontStyle.Regular, GraphicsUnit.Point))
            {
                RectangleF rectF1 = new RectangleF(556, 153, 260, 25);
                e.Graphics.DrawString("CST No. - "+ccst, font1, Brushes.Black, rectF1);
                e.Graphics.DrawRectangle(Pens.Transparent, Rectangle.Round(rectF1));
            }

            // Company PAN number

            using (Font font1 = new Font("Arial", 11, FontStyle.Regular, GraphicsUnit.Point))
            {
                RectangleF rectF1 = new RectangleF(556, 176, 260, 25);
                e.Graphics.DrawString("PAN - "+cpan, font1, Brushes.Black, rectF1);
                e.Graphics.DrawRectangle(Pens.Transparent, Rectangle.Round(rectF1));
            }


            // Buyer Information

            // Customer Name
            e.Graphics.DrawString("Buyer Information", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(360, 217));

            using (Font font1 = new Font("Arial", 11, FontStyle.Regular, GraphicsUnit.Point))
            {
                RectangleF rectF1 = new RectangleF(35, 247, 400, 20);
                e.Graphics.DrawString("Cust. Name - "+custNametb.Text , font1, Brushes.Black, rectF1);
                e.Graphics.DrawRectangle(Pens.Transparent, Rectangle.Round(rectF1));
            }

            // Customer Address

            using (Font font1 = new Font("Arial", 11, FontStyle.Regular, GraphicsUnit.Point))
            {
                RectangleF rectF1 = new RectangleF(35, 270, 454, 38);
                e.Graphics.DrawString("Cust. Address - "+addrtb.Text, font1, Brushes.Black, rectF1);
                e.Graphics.DrawRectangle(Pens.Transparent, Rectangle.Round(rectF1));
            }

            e.Graphics.DrawLine(new Pen(Color.Black, 2), 515, 246, 515, 310);



            // Customer Contact Number

            using (Font font1 = new Font("Arial", 11, FontStyle.Regular, GraphicsUnit.Point))
            {
                RectangleF rectF1 = new RectangleF(525, 260, 265, 40);
                e.Graphics.DrawString("Customer Contact Number "+mobiletb.Text, font1, Brushes.Black, rectF1);
                e.Graphics.DrawRectangle(Pens.Transparent, Rectangle.Round(rectF1));
            }
  

                        // Column Name
                        // Serial No.

                        using (Font font1 = new Font("Arial", 11, FontStyle.Bold, GraphicsUnit.Point))
                        {
                            RectangleF rectF1 = new RectangleF(29, 318, 30, 35);
                            e.Graphics.DrawString("SL No.", font1, Brushes.Black, rectF1);
                            e.Graphics.DrawRectangle(Pens.Transparent, Rectangle.Round(rectF1));
                        }

                        //  Description of Items

                        using (Font font1 = new Font("Arial", 11, FontStyle.Bold, GraphicsUnit.Point))
                        {
                            RectangleF rectF1 = new RectangleF(120, 318, 200, 35);
                            e.Graphics.DrawString("Description of Item(s)", font1, Brushes.Black, rectF1);
                            e.Graphics.DrawRectangle(Pens.Transparent, Rectangle.Round(rectF1));
                        }

                        // HSN/SAC 

                        using (Font font1 = new Font("Arial", 11, FontStyle.Bold, GraphicsUnit.Point))
                        {
                            RectangleF rectF1 = new RectangleF(385, 318, 40, 35);
                            e.Graphics.DrawString("HSN", font1, Brushes.Black, rectF1);
                            e.Graphics.DrawRectangle(Pens.Transparent, Rectangle.Round(rectF1));
                        }

                        // Quantity

                        using (Font font1 = new Font("Arial", 11, FontStyle.Bold, GraphicsUnit.Point))
                        {
                            RectangleF rectF1 = new RectangleF(440, 318, 76, 35);
                            e.Graphics.DrawString("Quantity", font1, Brushes.Black, rectF1);
                            e.Graphics.DrawRectangle(Pens.Transparent, Rectangle.Round(rectF1));
                        }

                        // Measuring Unit

                        using (Font font1 = new Font("Arial", 11, FontStyle.Bold, GraphicsUnit.Point))
                        {
                            RectangleF rectF1 = new RectangleF(513, 318, 45, 35);
                            e.Graphics.DrawString("Unit", font1, Brushes.Black, rectF1);
                            e.Graphics.DrawRectangle(Pens.Transparent, Rectangle.Round(rectF1));
                        }

                        // Selling Price

                        using (Font font1 = new Font("Arial", 11, FontStyle.Bold, GraphicsUnit.Point))
                        {
                            RectangleF rectF1 = new RectangleF(568, 318, 47, 35);
                            e.Graphics.DrawString("Rate/Unit", font1, Brushes.Black, rectF1);
                            e.Graphics.DrawRectangle(Pens.Transparent, Rectangle.Round(rectF1));
                        }


                        // Discount Amount

                        using (Font font1 = new Font("Arial", 10, FontStyle.Bold, GraphicsUnit.Point))
                        {
                            RectangleF rectF1 = new RectangleF(634, 318, 60, 35);
                            e.Graphics.DrawString("Disc Amount", font1, Brushes.Black, rectF1);
                            e.Graphics.DrawRectangle(Pens.Transparent, Rectangle.Round(rectF1));
                        }

                        // Total Amount Item Basis

                        using (Font font1 = new Font("Arial", 11, FontStyle.Bold, GraphicsUnit.Point))
                        {
                            RectangleF rectF1 = new RectangleF(716, 318, 75, 35);
                            e.Graphics.DrawString("Amount", font1, Brushes.Black, rectF1);
                            e.Graphics.DrawRectangle(Pens.Transparent, Rectangle.Round(rectF1));
                        }  // */


                        
            // Signature Segment

            e.Graphics.DrawString("Authorized Signature", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(610,977));


            // Print items

            Boolean flag = false;

            try
            {

                string item, desc, qty, mu, sp = "0", tdi, sg, cg;
                string query = "SELECT selling_price FROM sub_catagory WHERE ItemId=@subcatid";
                SqlCeDataReader rdr = null;
                double bucket = 0;
               

                for (int j = numberOfItemsPrinted; j < ItemList.RowCount; j++)
                {
                    itemPerPage++;
                    if (itemPerPage <= 6)
                    {
                        numberOfItemsPrinted++;
                        if (numberOfItemsPrinted <= ItemList.RowCount)
                        {
                            item = ItemList.Rows[j].Cells[1].Value.ToString();
                            desc = ItemList.Rows[j].Cells[2].Value.ToString();
                            qty = ItemList.Rows[j].Cells[3].Value.ToString();
                            mu = ItemList.Rows[j].Cells[4].Value.ToString();
                            tdi = ItemList.Rows[j].Cells[6].Value.ToString();
                            sg = ItemList.Rows[j].Cells[7].Value.ToString();
                            cg = ItemList.Rows[j].Cells[8].Value.ToString();
                            cmd = new SqlCeCommand(query, conn);
                            if (!searchflag)
                            {
                                cmd.Parameters.AddWithValue("@subcatid", ItemList.Rows[j].Cells[0].Value.ToString());
                            
                                rdr = cmd.ExecuteReader();
                                while (rdr.Read())
                                {
                                    sp = rdr.GetDouble(0).ToString();
                                }
                                bucket = double.Parse(sp) * float.Parse(qty);
                                itemrow(e, item, "8247", qty, mu, sp, tdi, bucket.ToString(), desc, sg, cg);
                            }
                            else
                            {
                                sp = ItemList.Rows[j].Cells[5].Value.ToString();
                                itemrow(e, item, "8247", qty, mu, sp, tdi, sp, desc, sg, cg);
                            }
                        }
                        else
                        {
                            finish_bottom_segment(e);
                            e.HasMorePages = false;

                        }
                        
                    }
                    else
                    {
                        itemPerPage = 0;
                        e.HasMorePages = true;
                        flag = true;
                    }

                }
                if (flag)
                {
                    more_bottom_segment(e);
                    spacer = 0;
                }
                else
                {
                    finish_bottom_segment(e);
                    numberOfItemsPrinted = 0;
                    itemPerPage = 0;
                    ItemCount = 1;
                    spacer = 0;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex);
            }
            
            
        }

    // Item Row

    private void itemrow( System.Drawing.Printing.PrintPageEventArgs e, string itemName, string hsn, string qty, string munit, string itemrate, string itemdisc, string itprice, string description, string sgstp, string cgstp)
        {
            
            using (Font font1 = new Font("Arial", 11, FontStyle.Bold, GraphicsUnit.Point))
            {
                RectangleF rectF1 = new RectangleF(33, 373+spacer, 25, 40);
                e.Graphics.DrawString(ItemCount.ToString(), font1, Brushes.Black, rectF1);
                e.Graphics.DrawRectangle(Pens.Transparent, Rectangle.Round(rectF1));
            }


            // Item Name

            using (Font font1 = new Font("Arial", 11, FontStyle.Bold, GraphicsUnit.Point))
            {
                RectangleF rectF1 = new RectangleF(58, 373+spacer, 320, 25);
                e.Graphics.DrawString(itemName, font1, Brushes.Black, rectF1);
                e.Graphics.DrawRectangle(Pens.Transparent, Rectangle.Round(rectF1));
            }

            // Item HSN

            using (Font font1 = new Font("Arial", 11, FontStyle.Bold, GraphicsUnit.Point))
            {
                RectangleF rectF1 = new RectangleF(380, 373+spacer, 80, 40);
                e.Graphics.DrawString(hsn, font1, Brushes.Black, rectF1);
                e.Graphics.DrawRectangle(Pens.Transparent, Rectangle.Round(rectF1));
            }

            // Item Quantity

            using (Font font1 = new Font("Arial", 11, FontStyle.Bold, GraphicsUnit.Point))
            {
                RectangleF rectF1 = new RectangleF(441, 373+spacer, 73, 40);
                e.Graphics.DrawString(qty, font1, Brushes.Black, rectF1);
                e.Graphics.DrawRectangle(Pens.Transparent, Rectangle.Round(rectF1));
            }

            // Item Measuring Unit

            using (Font font1 = new Font("Arial", 11, FontStyle.Regular, GraphicsUnit.Point))
            {
                RectangleF rectF1 = new RectangleF(515, 373+spacer, 48, 40);
                e.Graphics.DrawString(munit, font1, Brushes.Black, rectF1);
                e.Graphics.DrawRectangle(Pens.Transparent, Rectangle.Round(rectF1));
            }

            
            
            // Item Basis Selling Price

            using (Font font1 = new Font("Arial", 11, FontStyle.Bold, GraphicsUnit.Point))
            {
                RectangleF rectF1 = new RectangleF(568, 373+spacer, 70, 40);
                e.Graphics.DrawString(itemrate, font1, Brushes.Black, rectF1);
                e.Graphics.DrawRectangle(Pens.Transparent, Rectangle.Round(rectF1));
            }


            // Item Basis Discount

            using (Font font1 = new Font("Arial", 11, FontStyle.Regular, GraphicsUnit.Point))
            {
                RectangleF rectF1 = new RectangleF(639, 373+spacer, 55, 40);
                e.Graphics.DrawString(itemdisc, font1, Brushes.Black, rectF1);
                e.Graphics.DrawRectangle(Pens.Transparent, Rectangle.Round(rectF1));
            }

            // Item Basis Total Price

            using (Font font1 = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point))
            {
                RectangleF rectF1 = new RectangleF(707, 373+spacer, 89, 40);
                e.Graphics.DrawString(itprice, font1, Brushes.Black, rectF1);
                e.Graphics.DrawRectangle(Pens.Transparent, Rectangle.Round(rectF1));
            }


            // Description

            using (Font font1 = new Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Point))
            {
                RectangleF rectF1 = new RectangleF(58, 400+spacer, 320, 30);
                if (description != "")
                {
                    e.Graphics.DrawString(description, font1, Brushes.Black, rectF1);
                }
                else
                {
                    e.Graphics.DrawString("No Description for this Item", font1, Brushes.Black, rectF1);
                }
                e.Graphics.DrawRectangle(Pens.Transparent, Rectangle.Round(rectF1));
            }

            // SGST percent CGST percent

            using (Font font1 = new Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Point))
            {
                RectangleF rectF1 = new RectangleF(65, 432+spacer, 310, 15);
                e.Graphics.DrawString("SGST= "+sgstp+"%  CGST= "+cgstp+"%", font1, Brushes.Black, rectF1);
                e.Graphics.DrawRectangle(Pens.Transparent, Rectangle.Round(rectF1));
            }

            spacer = spacer + 83;
            ItemCount++;

        }



        // More pages bottom segment method

        private void more_bottom_segment(System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 380, 880, 380, 975);
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 599, 975, 599, 1050);
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 29, 975, 795, 975);

            e.Graphics.DrawLine(new Pen(Color.Black, 2), 55, 880, 55, 975);
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 435, 880, 435, 975);
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 510, 880, 510, 975);
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 558, 880, 558, 975);
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 632, 880, 632, 975);
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 698, 880, 698, 975);

            using (Font font1 = new Font("Arial", 13, FontStyle.Italic, GraphicsUnit.Point))
            {
                RectangleF rectF1 = new RectangleF(140, 1000, 250, 40);
                e.Graphics.DrawString("Carried out to next Page", font1, Brushes.Black, rectF1);
                e.Graphics.DrawRectangle(Pens.Transparent, Rectangle.Round(rectF1));
            }

        }


        // Bottom Segment design


        private void finish_bottom_segment(System.Drawing.Printing.PrintPageEventArgs e)
        {
            

            // Calculation Printing

            e.Graphics.DrawLine(new Pen(Color.Black, 2), 29, 880, 795, 880);
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 29, 975, 795, 975);

            e.Graphics.DrawLine(new Pen(Color.Black, 2), 350, 945, 570, 945);

            e.Graphics.DrawLine(new Pen(Color.Black, 2), 350, 910, 570, 910);
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 570, 880, 570, 975);
           
            
            // GST details


            e.Graphics.DrawString("Central", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(353, 916));
            e.Graphics.DrawString("State", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(353, 950));


            e.Graphics.DrawLine(new Pen(Color.Black, 2), 415, 880, 415, 975);
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 350, 880, 350, 975);
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 480, 880, 480, 975);

            e.Graphics.DrawString("Rate", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(425, 890));
            e.Graphics.DrawString("Amount", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(490, 890));
            e.Graphics.DrawString("GST", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(355, 890));

            if (finalcgsttb.Text == "0")
            {
                using (Font font1 = new Font("Arial", 11, FontStyle.Regular, GraphicsUnit.Point))
                {
                    RectangleF rectF1 = new RectangleF(425, 913, 55, 30);
                    e.Graphics.DrawString(finalcgsttb.Text, font1, Brushes.Black, rectF1);
                    e.Graphics.DrawRectangle(Pens.Transparent, Rectangle.Round(rectF1));
                }
            }
            if (finalsgsttb.Text == "0")
            {
                using (Font font1 = new Font("Arial", 11, FontStyle.Regular, GraphicsUnit.Point))
                {
                    RectangleF rectF1 = new RectangleF(425, 950, 55, 30);
                    e.Graphics.DrawString(finalsgsttb.Text, font1, Brushes.Black, rectF1);
                    e.Graphics.DrawRectangle(Pens.Transparent, Rectangle.Round(rectF1));
                }
            }
            using (Font font1 = new Font("Arial", 11, FontStyle.Regular, GraphicsUnit.Point))
            {
                RectangleF rectF1 = new RectangleF(485, 915, 80, 25);
                e.Graphics.DrawString(totalcgsttb.Text, font1, Brushes.Black, rectF1);
                e.Graphics.DrawRectangle(Pens.Transparent, Rectangle.Round(rectF1));
            }


            using (Font font1 = new Font("Arial", 11, FontStyle.Regular, GraphicsUnit.Point))
            {
                RectangleF rectF1 = new RectangleF(485, 950, 80, 25);
                e.Graphics.DrawString(totalsgsttb.Text, font1, Brushes.Black, rectF1);
                e.Graphics.DrawRectangle(Pens.Transparent, Rectangle.Round(rectF1));
            }




            // Total Price

            // e.Graphics.DrawString("Total Price", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(55, 908));
            using (Font font1 = new Font("Arial", 11, FontStyle.Bold, GraphicsUnit.Point))
            {
                RectangleF rectF1 = new RectangleF(55, 890, 120, 75);
                e.Graphics.DrawString("Total Price", font1, Brushes.Black, rectF1);
                e.Graphics.DrawRectangle(Pens.Transparent, Rectangle.Round(rectF1));
            }
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 200, 880, 200, 975);

            using (Font font1 = new Font("Arial", 11, FontStyle.Regular, GraphicsUnit.Point))
            {
                RectangleF rectF1 = new RectangleF(73, 920, 150, 60);
                e.Graphics.DrawString(totalPricetb.Text+" INR", font1, Brushes.Black, rectF1);
                e.Graphics.DrawRectangle(Pens.Transparent, Rectangle.Round(rectF1));
            }




            // Total Discount 

            using (Font font1 = new Font("Arial", 11, FontStyle.Bold, GraphicsUnit.Point))
            {
                RectangleF rectF1 = new RectangleF(220, 890, 150, 75);
                e.Graphics.DrawString("Total Discount ", font1, Brushes.Black, rectF1);
                e.Graphics.DrawRectangle(Pens.Transparent, Rectangle.Round(rectF1));
            }


            using (Font font1 = new Font("Arial", 11, FontStyle.Regular, GraphicsUnit.Point))
            {
                RectangleF rectF1 = new RectangleF(235, 920, 150, 60);
                e.Graphics.DrawString(totalDiscounttb.Text+" INR", font1, Brushes.Black, rectF1);
                e.Graphics.DrawRectangle(Pens.Transparent, Rectangle.Round(rectF1));
            }



            // Payable Amount

            using (Font font1 = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point))
            {
                RectangleF rectF1 = new RectangleF(590, 890, 165, 20);
                e.Graphics.DrawString("Payable Amount", font1, Brushes.Black, rectF1);
                e.Graphics.DrawRectangle(Pens.Transparent, Rectangle.Round(rectF1));
            }

            using (Font font1 = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point))
            {
                RectangleF rectF1 = new RectangleF(590, 935, 165, 60);
                e.Graphics.DrawString(grandtotaltb.Text+" INR", font1, Brushes.Black, rectF1);
                e.Graphics.DrawRectangle(Pens.Transparent, Rectangle.Round(rectF1));
            }


            // Payment Method Details

            e.Graphics.DrawLine(new Pen(Color.Black, 2), 599, 975, 599, 1050);
            e.Graphics.DrawString("Payment Details", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(34, 979));

            if(paymenttypecb.Text== "Cash")
            {
                paymentDetailstb.Text = "";
            }
            using (Font font1 = new Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Point))
            {
                RectangleF rectF1 = new RectangleF(34, 1000, 550, 45);
                e.Graphics.DrawString("Type of Payment : "+ paymenttypecb.Text+"\n"+ paymentDetailstb.Text, font1, Brushes.Black, rectF1);
                e.Graphics.DrawRectangle(Pens.Transparent, Rectangle.Round(rectF1));
            }   
        }

    }
}
