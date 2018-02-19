using System;
using System.Windows.Forms;
using System.IO;
using QuickBill.Properties;
using System.Media;
using System.Data.SqlServerCe;
using System.Drawing;

namespace QuickBill
{
    public partial class FilePath : Form
    {
        public FilePath()
        {
            InitializeComponent();
        }

        private void browsedbbtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderbrowse = new FolderBrowserDialog();
            String dbpath = browsedbpath.Text;
            if(Directory.Exists(dbpath))
            {
                folderbrowse.SelectedPath = dbpath;

            }
            folderbrowse.ShowNewFolderButton=true;
            folderbrowse.Description= "Select the folder where the data files will be store.";
            while(true)
            {
                DialogResult result = folderbrowse.ShowDialog();
                if(result!=System.Windows.Forms.DialogResult.OK)
                {
                    return;
                }
                if(dbpath.Equals(folderbrowse.SelectedPath))
                {
                    String msg = "The existing path and the new path are same. Do you want to keep the same path?";
                    DialogResult res = MessageBox.Show(msg, "Confirm Selction", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (res == System.Windows.Forms.DialogResult.Yes)
                    {
                        break; 
                    }
                }
                else
                {
                    break;
                }
            }
            browsedbpath.Text = folderbrowse.SelectedPath;
            toolTip1.SetToolTip(browsedbpath, browsedbpath.Text);
        }

        private void savedestinationbtn_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren(ValidationConstraints.Enabled))
            {
                System.Media.SystemSounds.Exclamation.Play();
                return;
            }
            Settings.Default.DatabasePath = browsedbpath.Text;
            Settings.Default.BackupLocation = browsebackupdbpath.Text;
            if (!CreateRootFolder(browsedbpath.Text))
            {
                return;
            }
            try
            {
                Boolean flag;
                Settings.Default.Save();
                dboperation operation = new dboperation();
                SqlCeConnection conn = null;
                
                if (!File.Exists(Settings.Default.DatabasePath + "\\" + Global.ROOT_DATA_FOLDER + "\\" + Global.DB_NAME_PREFIX + ".sdf"))
                {
                    flag = operation.createDatabase(Settings.Default.DatabasePath);
                }
                else
                {
                    throw new Exception("Database already exist in selected path");
                }
                if (flag)
                {
                    conn = operation.dbConnection(Settings.Default.DatabasePath);
                    string tabflag = operation.createTable(conn);
                    if (tabflag == "s")
                    {
                        MessageBox.Show("Database Created Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Error creating database");
                    }
                    }
                else
                    {
                        MessageBox.Show("An error Occured to create the Database or Database already Exist");
                    }               
            }
            catch (Exception ex)
            {
                string message = "An error occurred to save the settings." +
                    "\nThe error text is as follows: \n" + Global.getExceptionText(ex);
                SystemSounds.Hand.Play();
                MessageBox.Show(message, "Error Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Close();
        }


        internal bool CreateRootFolder(String FolderPath)
        {
            FolderPath = FolderPath + "\\" + Global.ROOT_DATA_FOLDER;
            if(Directory.Exists(FolderPath))
            {
                return true;
            }
            try
            {
                DirectoryInfo dirinfo = Directory.CreateDirectory(FolderPath);
                if (dirinfo == null)
                {
                    throw new ApplicationException("An Unknown Error Occured in Creating the Folder");
                }
            }
            catch(Exception ex)
            {
                String msg= "An error occurred in creating a folder under the selected folder." +
                    "\nThe error text is as follows:\n" + Global.getExceptionText(ex);
                SystemSounds.Hand.Play();
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               // ErrorLogger.LogError(ex);
                return false;

            }
            return true;
        }


        private void browsedbpath_TextChanged(object sender, EventArgs e)
        {
            if (browsedbpath.Text != "")
            {
                savedestinationbtn.Enabled = true;
                savedestinationbtn.BackColor = Color.LightSteelBlue;
            }
        }

        private void FilePath_Load(object sender, EventArgs e)
        {
            browsedbpath.ReadOnly = Enabled;
            browsedbpath.Text = Properties.Settings.Default.DatabasePath;
            browsebackupdbpath.ReadOnly = Enabled;
            browsebackupdbpath.Text = Settings.Default.BackupLocation;
            if (browsedbpath.Text == "")
            {
                savedestinationbtn.Enabled = false;
                savedestinationbtn.BackColor = Color.LightSkyBlue;
            }
     
        }

        private void backFilePath_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void browsebackupdbbtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderbrowse = new FolderBrowserDialog();
            string backupdbpath = browsebackupdbpath.Text;
            if (Directory.Exists(backupdbpath))
            {
                folderbrowse.SelectedPath=backupdbpath;
            }
            folderbrowse.ShowNewFolderButton = true;
            folderbrowse.Description = "Select the folder where the Backup data files will be store.";
                while (true)
                {
                    DialogResult result = folderbrowse.ShowDialog();
                    if (result != System.Windows.Forms.DialogResult.OK)
                    {
                        return;
                    }
                    if (backupdbpath.Equals(folderbrowse.SelectedPath))
                    {
                        String msg = "The existing path and the new path are same. Do you want to keep the same path?";
                        DialogResult res = MessageBox.Show(msg, "Confirm Selction", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (res == System.Windows.Forms.DialogResult.Yes)
                        {
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            browsebackupdbpath.Text = folderbrowse.SelectedPath;
            toolTip2.SetToolTip(browsebackupdbpath, browsebackupdbpath.Text);
        }
    }
    
}
