using System;
using System.Windows.Forms;
using QuickBill.Properties;
using System.Data.SqlServerCe;
using System.IO;
using System.Drawing;
using System.Threading;
using Microsoft.VisualBasic.FileIO;

namespace QuickBill
{
    public partial class Preferences : Form
    {
        Thread thread;
        public Preferences()
        {
            InitializeComponent();
        }

        private void Preferences_Load(object sender, EventArgs e)
        {
            string dbpath, pathbackup;
            dbpath = Settings.Default.DatabasePath;
            dbpathpref.Text = dbpath;
            pathbackup = Settings.Default.BackupLocation;
            backupdbpathpref.Text = pathbackup;
            if (pathbackup == "")
            {
                warningbackup.Text = "*  Please mention a path for database to Backup, prevent you to protect the data from system failure.";
            }
            if (dbpath == "")
            {
                var filepath = new FilePath();
                filepath.ShowDialog();

            }
            
            else
            {

                FilePath createDBfolder = new FilePath();
                string db = Settings.Default.DatabasePath + "\\" + Global.ROOT_DATA_FOLDER + "\\" + Global.DB_NAME_PREFIX + ".sdf";

                //    If Database file not exist then create a database file

                createDBfolder.CreateRootFolder(Settings.Default.DatabasePath);

                if (!File.Exists(db))
                {
                    
                    Boolean flagdb;
                    string flagtable;
                    dboperation operation = new dboperation();
                    flagdb = operation.createDatabase(Settings.Default.DatabasePath);
                    SqlCeConnection conn = null;
                    conn = operation.dbConnection(Settings.Default.DatabasePath);
                    if (conn.State == System.Data.ConnectionState.Open && flagdb == true)
                    {
                        flagtable = operation.createTable(conn);
                        if (flagtable!="s")
                        {
                            MessageBox.Show("An error occured to create table in the database  "+flagtable);
                        }
                        operation.closeDBConnection(conn);
                    }
                    else
                    {
                        MessageBox.Show("An error occured to build connection with databases");
                    }
                }
                else
                {
                  //  MessageBox.Show("Database File already Exist");
                }
            }

            if (dbpathpref.Text == "" && backupdbpathpref.Text == "")
            {
                backupDBbtn.Enabled = false;
            }
        }

        private void addupdatecat_Click(object sender, EventArgs e)
        {
            
            var opencatagory = new catagoryInitiation();
            opencatagory.ShowDialog();

        }

        private void updatedbpathbtn_Click(object sender, EventArgs e)
        {
            var updatedbpath = new FilePath();
            updatedbpath.ShowDialog();
            
        }

        private void addandupdatesubcat_Click(object sender, EventArgs e)
        {
            var opensubcat = new subCatagoryInitiation();
            opensubcat.ShowDialog();
        }

        private void prefexitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkstockpref_Click(object sender, EventArgs e)
        {
            var openCUstock = new checkupdatestock();
            openCUstock.ShowDialog();
        }

        private void createuserlbl_Click(object sender, EventArgs e)
        {
            var createuser = new CreateUser();
            createuser.ShowDialog();
        }

        private void updatecurrntuserpwd_Click(object sender, EventArgs e)
        {
            var chngpwd = new updateadminpwd();
            chngpwd.ShowDialog();
        }

        private void Preferences_Activated(object sender, EventArgs e)
        {
            dbpathpref.Clear();
            dbpathpref.Text = Settings.Default.DatabasePath;
            if (Settings.Default.BackupLocation== "")
            {
                warningbackup.Text = "*  Please select a path for database to Backup, prevent you to protect the data from system failure.";
            }
            else
            {
                warningbackup.Text = "";
                backupdbpathpref.Text = Settings.Default.BackupLocation;
            }
            if (dbpathpref.Text == "" && backupdbpathpref.Text == "")
            {
                backupDBbtn.Enabled = false;
            }
        }

        private void updatebackupdbbtn_Click(object sender, EventArgs e)
        {
            var pathupdateBackup = new FilePath();
            pathupdateBackup.ShowDialog();
        }

        private void updateInfo_Click(object sender, EventArgs e)
        {
            var updateCompInfo = new registration();
            updateCompInfo.regtag.Text = "Update Information";
            updateCompInfo.regtag.Location = new Point(430, 57);
            updateCompInfo.regkeytb.Enabled = false;
            updateCompInfo.gstuintb.Enabled = false;
            updateCompInfo.prefix.Enabled = false;
            updateCompInfo.flag = true;
            updateCompInfo.regbtn.Text = "Update";

            updateCompInfo.ShowDialog(); 
        }

        private void previnvoice_Click(object sender, EventArgs e)
        {
            prevInvoice invoice = new prevInvoice();
            invoice.ShowDialog();
        }

        private void backupDBbtn_Click(object sender, EventArgs e)
        {
            string sourcePath = Settings.Default.DatabasePath + "\\" + Global.ROOT_DATA_FOLDER + "\\" + Global.DB_NAME_PREFIX + ".sdf";
            string destinationPath = Settings.Default.BackupLocation;
            if (File.Exists(sourcePath)&&destinationPath!="")
            {
                backupDBbtn.Enabled = false;
                // copy File to backup path
                FileSystem.CopyFile(sourcePath, destinationPath + "\\" +DateTime.Now.ToString("dd.MM.yyyy.hh.mm") + ".sdf",UIOption.AllDialogs);
                backupDBbtn.Enabled = true;
            }
            
        }

        private void detailReport_Click(object sender, EventArgs e)
        {
            //  transaction trans = new transaction();
            //  trans.ShowDialog();
            Summary summery = new Summary();
            summery.ShowDialog();
        }

        private void createuserlbl_MouseEnter(object sender, EventArgs e)
        {
            mouse_enter(this.createuserlbl);
            
        }

        private void createuserlbl_MouseLeave(object sender, EventArgs e)
        {
            mouse_leave(this.createuserlbl);
        }

        private void mouse_enter(Label ctrl)
        {
            float size = 10.50F;
            ctrl.ForeColor = Color.BlueViolet;
            ctrl.Font = new Font(ctrl.Font.FontFamily, size);
        }
        private void mouse_leave(Label ctrl)
        {
            float size = 9.75F;
            ctrl.ForeColor = Color.Blue;
            ctrl.Font = new Font(ctrl.Font.FontFamily,size,FontStyle.Underline);
        }

        private void updatecurrntuserpwd_MouseEnter(object sender, EventArgs e)
        {
            mouse_enter(this.updatecurrntuserpwd);
        }

        private void updatecurrntuserpwd_MouseLeave(object sender, EventArgs e)
        {
            mouse_leave(this.updatecurrntuserpwd);
        }

        private void updateInfo_MouseEnter(object sender, EventArgs e)
        {
            mouse_enter(this.updateInfo);
        }

        private void updateInfo_MouseLeave(object sender, EventArgs e)
        {
            mouse_leave(this.updateInfo);
        }

        private void addupdatecat_MouseEnter(object sender, EventArgs e)
        {
            mouse_enter(this.addupdatecat);
        }

        private void addupdatecat_MouseLeave(object sender, EventArgs e)
        {
            mouse_leave(this.addupdatecat);
        }

        private void addandupdatesubcat_MouseEnter(object sender, EventArgs e)
        {
            mouse_enter(this.addandupdatesubcat);
        }

        private void addandupdatesubcat_MouseLeave(object sender, EventArgs e)
        {
            mouse_leave(this.addandupdatesubcat);
        }

        private void chkstockpref_MouseEnter(object sender, EventArgs e)
        {
            mouse_enter(this.chkstockpref);
        }

        private void chkstockpref_MouseLeave(object sender, EventArgs e)
        {
            mouse_leave(this.chkstockpref);
        }

        private void previnvoice_MouseEnter(object sender, EventArgs e)
        {
            mouse_enter(this.previnvoice);
        }

        private void previnvoice_MouseLeave(object sender, EventArgs e)
        {
            mouse_leave(this.previnvoice);
        }

        private void detailReport_MouseEnter(object sender, EventArgs e)
        {
            mouse_enter(this.detailReport);
        }

        private void detailReport_MouseLeave(object sender, EventArgs e)
        {
            mouse_leave(this.detailReport);
        }

        private void aboutus_MouseEnter(object sender, EventArgs e)
        {
            mouse_enter(this.contactus);
        }

        private void aboutus_MouseLeave(object sender, EventArgs e)
        {
            mouse_leave(this.contactus);
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

        private void backupdbpathpref_TextChanged(object sender, EventArgs e)
        {

        }

        private void contactus_Click(object sender, EventArgs e)
        {
            contact cnt = new contact();
            cnt.ShowDialog();
        }
    }
}
