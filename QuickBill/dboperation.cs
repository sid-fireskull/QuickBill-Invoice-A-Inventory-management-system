using System;
using System.Data.SqlServerCe;
using System.IO;
using QuickBill.Properties;
using System.Text;
using System.Security.Cryptography;

namespace QuickBill
{
    
    class dboperation
    {
        private securityController vault;
        private static string queryreguser = "CREATE TABLE regdetails (Id INT NOT NULL, companyName NVARCHAR(30) NOT NULL, companyAddr NVARCHAR (100) NOT NULL, companyMobile NVARCHAR (25) NOT NULL,companyEmail  NVARCHAR (40)  NULL, companygstin  NVARCHAR (30) NOT NULL, companyVAT NVARCHAR (30) NULL,companyCST NVARCHAR(30) NULL, companyPAN NVARCHAR (30) NULL,regkey NVARCHAR(30) NOT NULL, prefix NCHAR(10) NOT NULL DEFAULT 0, logo IMAGE NULL)";
        private static string querytableUser = "CREATE TABLE users (UserId INT NOT NULL PRIMARY KEY IDENTITY, UserName NVARCHAR(50) NOT NULL, Password NVARCHAR(50) NOT NULL)";
        private static string querytablecatagory = "CREATE TABLE catagory (CatId BIGINT NOT NULL PRIMARY KEY IDENTITY, Catagory NVARCHAR(70) NOT NULL, sgst FLOAT NULL DEFAULT 0, cgst FLOAT NULL DEFAULT 0, MeasuringUnit NVARCHAR(20) NOT NULL,hsn NVARCHAR(15) NULL)";
        private static string querytablesubcat = "CREATE TABLE sub_catagory (ItemId BIGINT NOT NULL PRIMARY KEY IDENTITY,ItemName NVARCHAR(60) NOT NULL,stock_Quantity NVARCHAR(25) NOT NULL DEFAULT 0,purchase_price FLOAT NOT NULL,selling_price FLOAT NOT NULL,undercatagory BIGINT NOT NULL, CONSTRAINT FK_sub_catagory_ToCatagory FOREIGN KEY(undercatagory) REFERENCES catagory(CatId))";
        private static string querycustdetails = "CREATE TABLE customerDetails( InvoiceNo BIGINT NOT NULL PRIMARY KEY IDENTITY(20170001, 1), customerName NVARCHAR(50) NOT NULL, custAddress NVARCHAR(120) NULL, custMobile NVARCHAR(50) NULL, paymentDetails NVARCHAR(80) NOT NULL, InvoiceTime DATETIME NOT NULL, totalSGST NVARCHAR(20) NOT NULL DEFAULT 0, totalCGST NVARCHAR(20) NOT NULL DEFAULT 0, totalDiscount NVARCHAR(20) NOT NULL DEFAULT 0, totalItemPrice NVARCHAR(20) NOT NULL DEFAULT 0, percentSGST NVARCHAR(20) NOT NULL DEFAULT 0, percentCGST NVARCHAR(20) NOT NULL DEFAULT 0)";
        private static string queryinvoicedetails = "CREATE TABLE invoiceDetails( SerialId BIGINT NOT NULL PRIMARY KEY IDENTITY(1, 1), InvoiceNo BIGINT NOT NULL, ItemName NVARCHAR(90) NOT NULL, quantity NVARCHAR(50) NOT NULL DEFAULT 0, TotalSellingPrice NVARCHAR(30) NOT NULL DEFAULT 0, TotalPurchasedPrice NVARCHAR(30) NOT NULL DEFAULT 0, perItemSGST FLOAT NOT NULL DEFAULT 0, perItemCGST FLOAT NOT NULL DEFAULT 0, discountPerItemType NVARCHAR(20) NOT NULL DEFAULT 0, measuringUnit NVARCHAR(20) NULL, description NVARCHAR(120) NULL, CONSTRAINT FK_Table_ToTable FOREIGN KEY (InvoiceNo) REFERENCES customerDetails(InvoiceNo))";
        

        // Create Database in Configured Path

        internal bool createDatabase(string dbpath)
        {
            string completePath = dbpath + "\\" + Global.ROOT_DATA_FOLDER + "\\" +Global.DB_NAME_PREFIX+".sdf" ;
            string dbconnstr = "Data Source =" + completePath + "; Persist Security Info=False; " +
                "Password=" + Settings.Default.dbpwd + "; Max Database Size=2048; Max Buffer Size=2048;";
            try
            {
                if (!File.Exists(completePath))
                {
                    SqlCeEngine engine = new SqlCeEngine(dbconnstr);
                    engine.CreateDatabase();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        // Create Database Connection

        internal SqlCeConnection dbConnection(string path)
        {
            string completepath = Settings.Default.DatabasePath + "\\" + Global.ROOT_DATA_FOLDER + "\\" + Global.DB_NAME_PREFIX + ".sdf";
            SqlCeConnection conn = null; 
            string connectionString = "Data Source=" + completepath + "; Password=" + Settings.Default.dbpwd;
            try
            {
                conn = new SqlCeConnection(connectionString);
                conn.Open();
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    return conn;
                }
                throw new Exception("Connection to the database couldn't be made due to some unknown reason.");
            }
            catch (Exception ex)
            {
                return null;
            }
            
        }

        // Close Database Connection

        internal bool closeDBConnection(SqlCeConnection conn)
        {
            try
            {
                conn.Close();
                return true;
            }catch(Exception ex)
            {
                return false;
            }
        }

        // Create Table 

        internal string createTable(SqlCeConnection conn)
        {
            
            SqlCeCommand cmduser,cmdcat,cmdsubcat,cmdcust,cmdinvoice,cmdreg;
            cmduser = new SqlCeCommand(querytableUser, conn);
            cmdcat = new SqlCeCommand(querytablecatagory, conn);
            cmdsubcat = new SqlCeCommand(querytablesubcat, conn);
            cmdcust = new SqlCeCommand(querycustdetails, conn);
            cmdinvoice = new SqlCeCommand(queryinvoicedetails,conn);
            cmdreg = new SqlCeCommand(queryreguser, conn);

            try
            {

                cmdreg.ExecuteNonQuery();
                cmduser.ExecuteNonQuery();
                cmdcat.ExecuteNonQuery();
                cmdsubcat.ExecuteNonQuery();
                cmdcust.ExecuteNonQuery();
                cmdinvoice.ExecuteNonQuery();
                conn.Close();
                return "s";
                
            }            
            catch (SqlCeException ex1)
            {
                
                return ex1.ToString();
            }

            
        }

        // Product Key Validation

        internal bool keyvalidation(string key,string gstno)
        {
            /*string salt= System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(Settings.Default.salt));
            string x = gstno + salt;
            if (key == CalculateMD5Hash(x))
            {
                return true;
            }
            else
            {
                return true;
            }*/
            return true;
            
        }

        internal bool keyvalidation()
        {
            return true;
        }

    }
}
