using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using QuickBill.Properties;
using System.Data.SqlServerCe;
using System.Collections.Generic;
using System.Drawing;

namespace QuickBill
{
    public partial class Summary : Form
    {
        Excel.Application exc = new Excel.Application();
        Excel.Workbook workbook;
        Excel.Worksheet sheet;
        int rowcounter = 2;
        string invoiceno = "", totaldiscount = "", totalcgst = "", totalsgst = "", totalsp = "";
        double purchashed_price = 0;

        public Summary()
        {
            InitializeComponent();
        }

        private void Summary_Load(object sender, EventArgs e)
        {
            todtp.Value = DateTime.Now;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            object misvalue = System.Reflection.Missing.Value;
            string report = "";
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.InitialDirectory = "C:\\";
            dialog.Title = "Save Report as Excel Document";
            dialog.RestoreDirectory = true;
            dialog.Filter = "Excel files (*.xls)|*.xls | All files (*.*)|*.*";
            dialog.CheckPathExists = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                report = dialog.FileName;
            }
            else
            {
                this.Close();
            }
            if (exc == null)
            {
                MessageBox.Show("Excel is not properly installed");
                return;
            }
            workbook = exc.Workbooks.Add(misvalue);
            sheet = (Excel.Worksheet)workbook.Worksheets.get_Item(1);
            Excel.Range formatrange = null;
            formatrange = sheet.get_Range("a1", "j1");
            formatrange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);
            Excel.Borders xborder = formatrange.Borders;
            xborder.LineStyle = Excel.XlLineStyle.xlContinuous;
            xborder.Weight = 3d;

            // Column Names

            sheet.Cells[1, 1] = "Invoice No";
            sheet.Cells[1, 2] = "Date";
            sheet.Cells[1, 3] = "Name of the Item(s)";
            sheet.Cells[1, 4] = "Quantity";
            sheet.Cells[1, 5] = "Purchased Price";
            sheet.Cells[1, 6] = "Selling Price";
            sheet.Cells[1, 7] = "Discount";
            sheet.Cells[1, 8] = "SGST";
            sheet.Cells[1, 9] = "CGST";
            sheet.Cells[1, 10] = "Profit";
            content1();

            sheet.Columns.AutoFit();

            workbook.SaveAs(report, Excel.XlFileFormat.xlWorkbookNormal, misvalue, misvalue, misvalue, misvalue, Excel.XlSaveAsAccessMode.xlExclusive, misvalue, misvalue, misvalue, misvalue, misvalue);
            workbook.Close(true, misvalue, misvalue);
            exc.Quit();

            Marshal.ReleaseComObject(sheet);
            Marshal.ReleaseComObject(workbook);
            Marshal.ReleaseComObject(exc);
            this.Close();

        }

        private void content1()
        {
            List<int> bucket = new List<int>();
            DateTime fdt, tdt;
            fdt = fromdtp.Value;
            tdt = todtp.Value;
            dboperation operation = new dboperation();
            SqlCeConnection conn = operation.dbConnection(Settings.Default.DatabasePath);
            string query1 = "SELECT InvoiceNo, totalSGST, totalCGST, totalDiscount, InvoiceTime, totalItemPrice FROM customerDetails WHERE InvoiceTime>=@start AND InvoiceTime<=@end";
            //                          0           1           2           3           4               5        
            string query2 = "SELECT ItemName, quantity, TotalSellingPrice, TotalPurchasedPrice, perItemSGST, perItemCGST, discountPerItemType FROM invoiceDetails WHERE InvoiceNo=";
            SqlCeCommand cmd = new SqlCeCommand(query1, conn);
            SqlCeDataReader reader = null;
            try
            {
                cmd.Parameters.AddWithValue("@start", fdt);
                cmd.Parameters.AddWithValue("@end", tdt);

                
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    invoiceno = reader.GetInt64(0).ToString();
                    totaldiscount = reader.GetString(3);
                    totalsgst = reader.GetString(1);
                    totalcgst = reader.GetString(2);
                    totalsp = reader.GetString(5);
                    sheet.Cells[rowcounter, 1] = invoiceno;
                    sheet.Cells[rowcounter, 2] = reader.GetDateTime(4).ToString("dd/MM/yyyy");
                    getinfoperinvoice(conn, query2 + invoiceno);
                    string totalPP = purchashed_price.ToString();

                    // Insert data to excel;
                    sheet.Cells[rowcounter, 2] = "Total";
                    sheet.Cells[rowcounter, 5] = totalPP;
                    sheet.Cells[rowcounter, 6] = totalsp;
                    sheet.Cells[rowcounter, 7] = totaldiscount;
                    sheet.Cells[rowcounter, 8] = totalsgst;
                    sheet.Cells[rowcounter, 9] = totalcgst;
                    sheet.Cells[rowcounter, 9].EntireRow.Font.Bold = true;
                    sheet.Cells[rowcounter, 10] = double.Parse(totalsp) - double.Parse(totalPP) - double.Parse(totaldiscount);
                    bucket.Add(rowcounter);
                    rowcounter++;
                    
                }
                if (bucket.Count > 0)
                {
                    
                    

                    string grandpp, grandsp, grandsgst, grandcgst, granddisc, grandprofit;
                    grandpp = "=SUM(";
                    grandsp= "=SUM(";
                    grandsgst = "=SUM(";
                    grandcgst = "=SUM(";
                    granddisc = "=SUM(";
                    grandprofit = "=SUM(";
                    for (int i = 0; i < bucket.Count; i++)
                    {
                        // Function for total Sum
                        if(grandpp== "=SUM(")
                        {
                            grandpp += " E"+bucket[i];
                            grandsp += " F" + bucket[i];
                            grandsgst += " H" + bucket[i];
                            grandcgst += " I" + bucket[i];
                            granddisc += " G" + bucket[i];
                            grandprofit += " J" + bucket[i];
                        }
                        else
                        {
                            grandpp += " , E" + bucket[i];
                            grandsp += " , F" + bucket[i];
                            grandsgst += " , H" + bucket[i];
                            grandcgst += " , I" + bucket[i];
                            granddisc += " , G" + bucket[i];
                            grandprofit += " , J" + bucket[i];
                        }

                    }
                    grandpp += " )";
                    grandsp += " )";
                    grandsgst += " )";
                    grandcgst += " )";
                    granddisc += " )";
                    grandprofit += " )";

                    rowcounter++;
                    sheet.Range["E" + rowcounter].Formula = grandpp;
                    sheet.Range["F" + rowcounter].Formula = grandsp;
                    sheet.Range["H" + rowcounter].Formula = grandsgst;
                    sheet.Range["I" + rowcounter].Formula = grandcgst;
                    sheet.Range["G" + rowcounter].Formula = granddisc;
                    sheet.Range["J" + rowcounter].Formula = grandprofit;
                    sheet.Cells[rowcounter, 2] = "GRAND TOTAL";
                    sheet.Cells[rowcounter, 3].EntireRow.Font.Bold = true;
                    sheet.get_Range("A" + rowcounter, "J" + rowcounter).Cells.Font.Size = 14;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void getinfoperinvoice(SqlCeConnection conn, string query)
        {
            purchashed_price = 0;
            string item, qty, itemtotalsp, itemtotalpp, percentsgst, percentcgst, discperitem;
            SqlCeCommand cmd = new SqlCeCommand(query, conn);
            SqlCeDataAdapter adapter = null;
            System.Data.DataTable dt = new System.Data.DataTable();
            try
            {
                // ItemName, quantity, TotalSellingPrice, TotalPurchasedPrice, perItemSGST, perItemCGST, discountPerItemType

                adapter = new SqlCeDataAdapter(query, conn);
                adapter.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {


                    item = dt.Rows[i]["ItemName"].ToString();
                    qty = dt.Rows[i]["quantity"].ToString();
                    itemtotalsp = dt.Rows[i]["TotalSellingPrice"].ToString();
                    itemtotalpp = dt.Rows[i]["TotalPurchasedPrice"].ToString();
                    percentsgst = dt.Rows[i]["perItemSGST"].ToString();
                    percentcgst = dt.Rows[i]["perItemCGST"].ToString();
                    discperitem = dt.Rows[i]["discountPerItemType"].ToString();
                    purchashed_price += double.Parse(itemtotalpp);

                    sheet.Cells[rowcounter, 3] = item;
                    sheet.Cells[rowcounter, 4] = qty;
                    sheet.Cells[rowcounter, 5] = itemtotalpp;
                    sheet.Cells[rowcounter, 6] = itemtotalsp;
                    sheet.Cells[rowcounter, 7] = discperitem;
                    sheet.Cells[rowcounter, 8] = percentsgst+"%";
                    sheet.Cells[rowcounter, 9] = percentcgst+"%";
                    
                    
                    rowcounter++;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }
    }
}
