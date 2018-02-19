using System;
using System.Drawing;
using System.Windows.Forms;
using QuickBill.Properties;

namespace QuickBill
{
    public partial class updateadminpwd : Form
    {
        public updateadminpwd()
        {
            InitializeComponent();
        }

        private void cancelpwdchange_Click(object sender, EventArgs e)
        {

        }

        private void updateadminpwd_Load(object sender, EventArgs e)
        {
            updateadminpwdbtn.Enabled = false;
            updateadminpwdbtn.BackColor = Color.LightSteelBlue;
        }

        private void updateadminpwdbtn_Click(object sender, EventArgs e)
        {
            String oldpwd = adminoldpwd.Text;
            String newpwd = newadminpwd1.Text;
            if (newpwd.Length < 5)
            {
                MessageBox.Show("Error! Password strength should be atleast 5 charecter long");
                newadminpwd1.Clear();
                newadminpwd2.Clear();
                return;
            }
            if (Settings.Default.useradminpwd == oldpwd)
            {
                DialogResult res = MessageBox.Show("Are you sure to change the admin password?", "Confirm Selction", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == System.Windows.Forms.DialogResult.Yes)
                {
                    Settings.Default.useradminpwd = newpwd;
                    Settings.Default.Save();
                }
                else
                {
                    return;
                }
                
            }
            else
            {
                MessageBox.Show("You are not authorized to change the admin password");
                return;
            }


        }

        private void newadminpwd2_TextChanged(object sender, EventArgs e)
        {
            if (newadminpwd1.Text == newadminpwd2.Text)
            {
                updateadminpwdbtn.Enabled = true;
                updateadminpwdbtn.BackColor = Color.LightSkyBlue;
            }
            else
            {
                updateadminpwdbtn.Enabled = false;
                updateadminpwdbtn.BackColor = Color.LightSteelBlue;
            }
        }
    }
}
