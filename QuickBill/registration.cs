using QuickBill.Properties;
using System;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace QuickBill
{
    public partial class registration : Form
    {
        internal Boolean flag = false;
        Thread thread;

        public registration()
        {
            InitializeComponent();
        }

        private void mu_TextChanged(object sender, EventArgs e)
        {

        }

        private void browselogobtn_Click(object sender, EventArgs e)
        {

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string logolocation = dialog.FileName.ToString();
                complogopb.ImageLocation = logolocation;
            }
        }

        private void regbtn_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                updateInformation();
            }
            else
            {
                if (compnametb.Text == "")
                {
                    MessageBox.Show("Company Name can't be empty");
                }
                else if (compaddrtb.Text == "")
                {
                    MessageBox.Show("Company Address can't be empty");
                }
                else if (compmbltb.Text == "")
                {
                    MessageBox.Show("Company Mobile number can't be empty");
                }
                else if (gstuintb.Text == "")
                {
                    MessageBox.Show("GSTIN/UIN field can't be empty");
                }
                else if (regkeytb.Text == "")
                {
                    MessageBox.Show("Please, specify a registration key or Contact buisness_quickbill@outlook.com");
                }
                else if(prefix.Text=="")
                {
                    MessageBox.Show("Please specify a prefix for invoice number");
                }
                else if (compemail.Text == "")
                {
                    compemail.Text = "0";
                }
                else if (compvattb.Text == "")
                {
                    compvattb.Text = "0";
                }
                else if (compcsttb.Text == "")
                {
                    compcsttb.Text = "0";
                }
                else if (comppantb.Text == "")
                {
                    comppantb.Text = "0";
                }
                else
                {
                    dboperation operation = new dboperation();
                    if (!(operation.keyvalidation(regkeytb.Text, gstuintb.Text)))
                    {
                        MessageBox.Show("Your Key is not Valid");
                        this.Close();
                    }


                    if (Settings.Default.DatabasePath == "" || !File.Exists(Settings.Default.DatabasePath + "\\" + Global.ROOT_DATA_FOLDER + "\\" + Global.DB_NAME_PREFIX + ".sdf"))
                    {
                        FilePath setpath = new FilePath();
                        setpath.ShowDialog();
                    }

                    else
                    {

                        SqlCeConnection conn = null;
                        SqlCeCommand cmd = null;
                        int flag;
                        byte[] photo_array = null;
                        MemoryStream ms = new MemoryStream();
                        if (complogopb.Image == null)
                        {
                            complogopb.Image = Resources.defaultlogo;
                        }
                            complogopb.Image.Save(ms, ImageFormat.Png);
                            photo_array = new byte[ms.Length];
                            ms.Position = 0;
                            ms.Read(photo_array, 0, photo_array.Length);
                        
                        string insertquery = "INSERT INTO regdetails(Id,companyName, companyAddr, companyMobile, companyEmail, companygstin, companyVAT, companyCST, companyPAN, regkey, prefix, logo) VALUES(@compid,@cname, @caddr, @mbl, @email, @gstin, @vat, @cst, @pan,@key,@prefix,@img)";
                        try
                        {
                            conn = operation.dbConnection(Settings.Default.DatabasePath);
                            cmd = new SqlCeCommand(insertquery, conn);
                            cmd.Parameters.AddWithValue("@compid", "1");
                            cmd.Parameters.AddWithValue("@cname", compnametb.Text);
                            cmd.Parameters.AddWithValue("@caddr", compaddrtb.Text);
                            cmd.Parameters.AddWithValue("@mbl", compmbltb.Text);
                            cmd.Parameters.AddWithValue("@email", compemail.Text);
                            cmd.Parameters.AddWithValue("@gstin", gstuintb.Text);
                            cmd.Parameters.AddWithValue("@vat", compvattb.Text);
                            cmd.Parameters.AddWithValue("@cst", compcsttb.Text);
                            cmd.Parameters.AddWithValue("@pan", comppantb.Text);
                            cmd.Parameters.AddWithValue("@key", regkeytb.Text);
                            cmd.Parameters.AddWithValue("@prefix", prefix.Text);
                            cmd.Parameters.AddWithValue("@img", photo_array);
                            flag = cmd.ExecuteNonQuery();
                            if (flag < 0)
                            {
                                MessageBox.Show("Error User to Register");
                                this.Close();
                            }
                            else
                            {
                                this.Close();
                                thread = new Thread(openlogin);
                                thread.SetApartmentState(ApartmentState.STA);
                                thread.Start();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occured to creating database" + ex);

                        }
                    }
                }
            }
        }



        private void openlogin(object obj)
        {
            Application.Run(new loginPanel());
        }

        private void registration_Load(object sender, EventArgs e)
        {
            if (flag)
            {
                fetchDetails();
                // Demo copy
                demo_activation_textbox_disable();

            }
            else
            {
                // Demo Copy Activation
                demo_activation_settext();
                demo_activation_textbox_disable();
                
            }

        }

        private void compmbltb_TextChanged(object sender, EventArgs e)
        {

        }

       private void updateInformation()
        {
            
            if (compnametb.Text == "")
            {
                MessageBox.Show("Company Name can't be empty");
            }
            else if (compaddrtb.Text == "")
            {
                MessageBox.Show("Company Address can't be empty");
            }
            else if (compmbltb.Text == "")
            {
                MessageBox.Show("Company Mobile number can't be empty");
            }           
            else if (compemail.Text == "")
            {
                compemail.Text = "0";
            }
            else if (compvattb.Text == "")
            {
                compvattb.Text = "0";
            }
            else if (compcsttb.Text == "")
            {
                compcsttb.Text = "0";
            }
            else if (comppantb.Text == "")
            {
                comppantb.Text = "0";
            }
            else
            {
                dboperation operation = new dboperation();
                SqlCeConnection conn = null;
                SqlCeCommand cmd = null;
                int flag;
                byte[] photo_array = null;
                MemoryStream ms = new MemoryStream();
                if (complogopb.Image != null)
                {
                    complogopb.Image.Save(ms, ImageFormat.Png);
                    photo_array = new byte[ms.Length];
                    ms.Position = 0;
                    ms.Read(photo_array, 0, photo_array.Length);
                }
                
                string updatequery = "UPDATE regdetails SET companyName = @cname, companyAddr = @caddr, companyMobile = @mbl, companyEmail = @email, companyVAT = @vat, companyCST = @cst, companyPAN = @pan, logo = @img WHERE Id = @compid";
                try
                {
                    conn = operation.dbConnection(Settings.Default.DatabasePath);
                    cmd = new SqlCeCommand(updatequery, conn);
                    cmd.Parameters.AddWithValue("@compid", "1");
                    cmd.Parameters.AddWithValue("@cname", compnametb.Text);
                    cmd.Parameters.AddWithValue("@caddr", compaddrtb.Text);
                    cmd.Parameters.AddWithValue("@mbl", compmbltb.Text);
                    cmd.Parameters.AddWithValue("@email", compemail.Text);
                   // cmd.Parameters.AddWithValue("@gstin", gstuintb.Text);
                    cmd.Parameters.AddWithValue("@vat", compvattb.Text);
                    cmd.Parameters.AddWithValue("@cst", compcsttb.Text);
                    cmd.Parameters.AddWithValue("@pan", comppantb.Text);
                  //  cmd.Parameters.AddWithValue("@key", regkeytb.Text);
                    cmd.Parameters.AddWithValue("@img", photo_array);
                    flag = cmd.ExecuteNonQuery();
                    if (flag < 0)
                    {
                        MessageBox.Show("Error User to Register");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Information updated successfully");
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occured to creating database" + ex);

                }


            }
            
        }


        private void fetchDetails()
        {
            dboperation operation = new dboperation();
            SqlCeConnection conn = operation.dbConnection(Settings.Default.DatabasePath);
            SqlCeCommand cmd = null;
            byte[] photo_array = null;
            SqlCeDataReader reader = null;
            MemoryStream ms = new MemoryStream();
            if (complogopb.Image != null)
            {
                complogopb.Image.Save(ms, ImageFormat.Png);
                photo_array = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(photo_array, 0, photo_array.Length);
            }
            string selectquery = "SELECT Id,companyName, companyAddr, companyMobile, companyEmail, companygstin, companyVAT, companyCST, companyPAN, regkey,prefix,logo FROM regdetails WHERE Id=1";
            cmd = new SqlCeCommand(selectquery, conn);
            try
            {
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    compnametb.Text = reader.GetString(1);
                    compaddrtb.Text = reader.GetString(2);
                    compmbltb.Text = reader.GetString(3);
                    compemail.Text = reader.GetString(4);
                    gstuintb.Text = reader.GetString(5);
                    compvattb.Text = reader.GetString(6);
                    compcsttb.Text = reader.GetString(7);
                    comppantb.Text = reader.GetString(8);
                    regkeytb.Text = "Hidden";
                    prefix.Text = reader.GetString(10);
                    photo_array = (byte[])reader["logo"];
                    MemoryStream mes = new MemoryStream(photo_array);
                    var bitmap = new Bitmap(mes);

                    complogopb.Image = bitmap;
                }
            }
            catch (Exception ex)
            {
               // MessageBox.Show("" + ex);
            }
        }

        private void prefix_TextChanged(object sender, EventArgs e)
        {
            if (prefix.Text != "")
            {
                prefix.Text.ToUpper();
            }
        }

        private void complogopb_Click(object sender, EventArgs e)
        {
            if (complogopb.Image == null)
            {
                complogopb.Image = Resources.defaultlogo;
            }
        }


        private void demo_activation_settext()
        {
            compnametb.Text = "THE COMPUTER SHOP";
            compaddrtb.Text = "Delhi, India";
            compmbltb.Text = "1800-3842-5846";
            compemail.Text = "support@computershop.com";
            prefix.Text = "TCS";
            regkeytb.Text = "TESTKEY";
            gstuintb.Text = "GST123456";
            compvattb.Text = "VAT123456";
            compcsttb.Text = "CST123456";
            comppantb.Text = "PAN123456";
            
        }

        private void demo_activation_textbox_disable()
        {
            compnametb.Enabled = false;
            compaddrtb.Enabled = false;
            compmbltb.Enabled = false;
            compemail.Enabled = false;
            prefix.Enabled = false;
            regkeytb.Enabled = false;
            gstuintb.Enabled = false;
            compvattb.Enabled = false;
            compcsttb.Enabled = false;
            comppantb.Enabled = false;
        }
    }
}