namespace QuickBill
{
    partial class Preferences
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Preferences));
            this.updatedbpathbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dbpathpref = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.backupdbpathpref = new System.Windows.Forms.TextBox();
            this.updatebackupdbbtn = new System.Windows.Forms.Button();
            this.createuserlbl = new System.Windows.Forms.Label();
            this.updatecurrntuserpwd = new System.Windows.Forms.Label();
            this.addupdatecat = new System.Windows.Forms.Label();
            this.prefexitbtn = new System.Windows.Forms.Button();
            this.contactus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addandupdatesubcat = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.chkstockpref = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.detailReport = new System.Windows.Forms.Label();
            this.previnvoice = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.updateInfo = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.warningbackup = new System.Windows.Forms.Label();
            this.backupDBbtn = new System.Windows.Forms.Button();
            this.usrswitch = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // updatedbpathbtn
            // 
            this.updatedbpathbtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.updatedbpathbtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.updatedbpathbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updatedbpathbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatedbpathbtn.Location = new System.Drawing.Point(512, 102);
            this.updatedbpathbtn.Name = "updatedbpathbtn";
            this.updatedbpathbtn.Size = new System.Drawing.Size(85, 25);
            this.updatedbpathbtn.TabIndex = 1;
            this.updatedbpathbtn.Text = "Update";
            this.updatedbpathbtn.UseVisualStyleBackColor = false;
            this.updatedbpathbtn.Click += new System.EventHandler(this.updatedbpathbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current Database Path";
            // 
            // dbpathpref
            // 
            this.dbpathpref.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dbpathpref.Cursor = System.Windows.Forms.Cursors.No;
            this.dbpathpref.Enabled = false;
            this.dbpathpref.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbpathpref.Location = new System.Drawing.Point(35, 103);
            this.dbpathpref.Name = "dbpathpref";
            this.dbpathpref.Size = new System.Drawing.Size(446, 22);
            this.dbpathpref.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Current Backup Path";
            // 
            // backupdbpathpref
            // 
            this.backupdbpathpref.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.backupdbpathpref.Cursor = System.Windows.Forms.Cursors.Default;
            this.backupdbpathpref.Enabled = false;
            this.backupdbpathpref.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backupdbpathpref.Location = new System.Drawing.Point(35, 172);
            this.backupdbpathpref.Name = "backupdbpathpref";
            this.backupdbpathpref.Size = new System.Drawing.Size(446, 22);
            this.backupdbpathpref.TabIndex = 5;
            this.backupdbpathpref.TextChanged += new System.EventHandler(this.backupdbpathpref_TextChanged);
            // 
            // updatebackupdbbtn
            // 
            this.updatebackupdbbtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.updatebackupdbbtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.updatebackupdbbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updatebackupdbbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebackupdbbtn.Location = new System.Drawing.Point(512, 171);
            this.updatebackupdbbtn.Name = "updatebackupdbbtn";
            this.updatebackupdbbtn.Size = new System.Drawing.Size(85, 25);
            this.updatebackupdbbtn.TabIndex = 6;
            this.updatebackupdbbtn.Text = "Update";
            this.updatebackupdbbtn.UseVisualStyleBackColor = false;
            this.updatebackupdbbtn.Click += new System.EventHandler(this.updatebackupdbbtn_Click);
            // 
            // createuserlbl
            // 
            this.createuserlbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.createuserlbl.AutoSize = true;
            this.createuserlbl.BackColor = System.Drawing.Color.Transparent;
            this.createuserlbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createuserlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createuserlbl.ForeColor = System.Drawing.Color.Blue;
            this.createuserlbl.Location = new System.Drawing.Point(57, 28);
            this.createuserlbl.Name = "createuserlbl";
            this.createuserlbl.Size = new System.Drawing.Size(137, 16);
            this.createuserlbl.TabIndex = 7;
            this.createuserlbl.Text = "Create User for Billing";
            this.createuserlbl.Click += new System.EventHandler(this.createuserlbl_Click);
            this.createuserlbl.MouseEnter += new System.EventHandler(this.createuserlbl_MouseEnter);
            this.createuserlbl.MouseLeave += new System.EventHandler(this.createuserlbl_MouseLeave);
            // 
            // updatecurrntuserpwd
            // 
            this.updatecurrntuserpwd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.updatecurrntuserpwd.AutoSize = true;
            this.updatecurrntuserpwd.BackColor = System.Drawing.Color.Transparent;
            this.updatecurrntuserpwd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updatecurrntuserpwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatecurrntuserpwd.ForeColor = System.Drawing.Color.Blue;
            this.updatecurrntuserpwd.Location = new System.Drawing.Point(56, 61);
            this.updatecurrntuserpwd.Name = "updatecurrntuserpwd";
            this.updatecurrntuserpwd.Size = new System.Drawing.Size(193, 16);
            this.updatecurrntuserpwd.TabIndex = 8;
            this.updatecurrntuserpwd.Text = "Update Current User Password";
            this.updatecurrntuserpwd.Click += new System.EventHandler(this.updatecurrntuserpwd_Click);
            this.updatecurrntuserpwd.MouseEnter += new System.EventHandler(this.updatecurrntuserpwd_MouseEnter);
            this.updatecurrntuserpwd.MouseLeave += new System.EventHandler(this.updatecurrntuserpwd_MouseLeave);
            // 
            // addupdatecat
            // 
            this.addupdatecat.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addupdatecat.AutoSize = true;
            this.addupdatecat.BackColor = System.Drawing.Color.Transparent;
            this.addupdatecat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addupdatecat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addupdatecat.ForeColor = System.Drawing.Color.Blue;
            this.addupdatecat.Location = new System.Drawing.Point(57, 127);
            this.addupdatecat.Name = "addupdatecat";
            this.addupdatecat.Size = new System.Drawing.Size(165, 16);
            this.addupdatecat.TabIndex = 9;
            this.addupdatecat.Text = "Add and Update Catagory";
            this.addupdatecat.Click += new System.EventHandler(this.addupdatecat_Click);
            this.addupdatecat.MouseEnter += new System.EventHandler(this.addupdatecat_MouseEnter);
            this.addupdatecat.MouseLeave += new System.EventHandler(this.addupdatecat_MouseLeave);
            // 
            // prefexitbtn
            // 
            this.prefexitbtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.prefexitbtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.prefexitbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.prefexitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prefexitbtn.Location = new System.Drawing.Point(711, 574);
            this.prefexitbtn.Name = "prefexitbtn";
            this.prefexitbtn.Size = new System.Drawing.Size(137, 35);
            this.prefexitbtn.TabIndex = 10;
            this.prefexitbtn.Text = "Exit";
            this.prefexitbtn.UseVisualStyleBackColor = false;
            this.prefexitbtn.Click += new System.EventHandler(this.prefexitbtn_Click);
            // 
            // contactus
            // 
            this.contactus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.contactus.AutoSize = true;
            this.contactus.BackColor = System.Drawing.Color.Transparent;
            this.contactus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.contactus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactus.ForeColor = System.Drawing.Color.Blue;
            this.contactus.Location = new System.Drawing.Point(56, 292);
            this.contactus.Name = "contactus";
            this.contactus.Size = new System.Drawing.Size(73, 16);
            this.contactus.TabIndex = 11;
            this.contactus.Text = "Contact Us";
            this.contactus.Click += new System.EventHandler(this.contactus_Click);
            this.contactus.MouseEnter += new System.EventHandler(this.aboutus_MouseEnter);
            this.contactus.MouseLeave += new System.EventHandler(this.aboutus_MouseLeave);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(376, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Preferences";
            // 
            // addandupdatesubcat
            // 
            this.addandupdatesubcat.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addandupdatesubcat.AutoSize = true;
            this.addandupdatesubcat.BackColor = System.Drawing.Color.Transparent;
            this.addandupdatesubcat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addandupdatesubcat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addandupdatesubcat.ForeColor = System.Drawing.Color.Blue;
            this.addandupdatesubcat.Location = new System.Drawing.Point(56, 160);
            this.addandupdatesubcat.Name = "addandupdatesubcat";
            this.addandupdatesubcat.Size = new System.Drawing.Size(193, 16);
            this.addandupdatesubcat.TabIndex = 13;
            this.addandupdatesubcat.Text = "Add and Update Sub-Catagory";
            this.addandupdatesubcat.Click += new System.EventHandler(this.addandupdatesubcat_Click);
            this.addandupdatesubcat.MouseEnter += new System.EventHandler(this.addandupdatesubcat_MouseEnter);
            this.addandupdatesubcat.MouseLeave += new System.EventHandler(this.addandupdatesubcat_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumBlue;
            this.label4.Location = new System.Drawing.Point(34, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumBlue;
            this.label5.Location = new System.Drawing.Point(34, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MediumBlue;
            this.label6.Location = new System.Drawing.Point(34, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MediumBlue;
            this.label7.Location = new System.Drawing.Point(34, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 24);
            this.label7.TabIndex = 17;
            this.label7.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MediumBlue;
            this.label8.Location = new System.Drawing.Point(34, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 24);
            this.label8.TabIndex = 18;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MediumBlue;
            this.label9.Location = new System.Drawing.Point(34, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 24);
            this.label9.TabIndex = 20;
            this.label9.Text = "*";
            // 
            // chkstockpref
            // 
            this.chkstockpref.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkstockpref.AutoSize = true;
            this.chkstockpref.BackColor = System.Drawing.Color.Transparent;
            this.chkstockpref.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkstockpref.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkstockpref.ForeColor = System.Drawing.Color.Blue;
            this.chkstockpref.Location = new System.Drawing.Point(58, 193);
            this.chkstockpref.Name = "chkstockpref";
            this.chkstockpref.Size = new System.Drawing.Size(157, 16);
            this.chkstockpref.TabIndex = 19;
            this.chkstockpref.Text = "Check and Update Stock";
            this.chkstockpref.Click += new System.EventHandler(this.chkstockpref_Click);
            this.chkstockpref.MouseEnter += new System.EventHandler(this.chkstockpref_MouseEnter);
            this.chkstockpref.MouseLeave += new System.EventHandler(this.chkstockpref_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.detailReport);
            this.panel1.Controls.Add(this.previnvoice);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.updateInfo);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.chkstockpref);
            this.panel1.Controls.Add(this.addandupdatesubcat);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.addupdatecat);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.updatecurrntuserpwd);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.createuserlbl);
            this.panel1.Controls.Add(this.contactus);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Location = new System.Drawing.Point(-3, 226);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(868, 328);
            this.panel1.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.MediumBlue;
            this.label14.Location = new System.Drawing.Point(34, 259);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 24);
            this.label14.TabIndex = 27;
            this.label14.Text = "*";
            // 
            // detailReport
            // 
            this.detailReport.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.detailReport.AutoSize = true;
            this.detailReport.BackColor = System.Drawing.Color.Transparent;
            this.detailReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.detailReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailReport.ForeColor = System.Drawing.Color.Blue;
            this.detailReport.Location = new System.Drawing.Point(56, 259);
            this.detailReport.Name = "detailReport";
            this.detailReport.Size = new System.Drawing.Size(147, 16);
            this.detailReport.TabIndex = 26;
            this.detailReport.Text = "Detail Summary Report";
            this.detailReport.Click += new System.EventHandler(this.detailReport_Click);
            this.detailReport.MouseEnter += new System.EventHandler(this.detailReport_MouseEnter);
            this.detailReport.MouseLeave += new System.EventHandler(this.detailReport_MouseLeave);
            // 
            // previnvoice
            // 
            this.previnvoice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.previnvoice.AutoSize = true;
            this.previnvoice.BackColor = System.Drawing.Color.Transparent;
            this.previnvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.previnvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previnvoice.ForeColor = System.Drawing.Color.Blue;
            this.previnvoice.Location = new System.Drawing.Point(58, 226);
            this.previnvoice.Name = "previnvoice";
            this.previnvoice.Size = new System.Drawing.Size(136, 16);
            this.previnvoice.TabIndex = 24;
            this.previnvoice.Text = "Print Previous Invoice";
            this.previnvoice.Click += new System.EventHandler(this.previnvoice_Click);
            this.previnvoice.MouseEnter += new System.EventHandler(this.previnvoice_MouseEnter);
            this.previnvoice.MouseLeave += new System.EventHandler(this.previnvoice_MouseLeave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.MediumBlue;
            this.label13.Location = new System.Drawing.Point(34, 226);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 24);
            this.label13.TabIndex = 25;
            this.label13.Text = "*";
            // 
            // updateInfo
            // 
            this.updateInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.updateInfo.AutoSize = true;
            this.updateInfo.BackColor = System.Drawing.Color.Transparent;
            this.updateInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateInfo.ForeColor = System.Drawing.Color.Blue;
            this.updateInfo.Location = new System.Drawing.Point(57, 94);
            this.updateInfo.Name = "updateInfo";
            this.updateInfo.Size = new System.Drawing.Size(182, 16);
            this.updateInfo.TabIndex = 21;
            this.updateInfo.Text = "Update Company Information";
            this.updateInfo.Click += new System.EventHandler(this.updateInfo_Click);
            this.updateInfo.MouseEnter += new System.EventHandler(this.updateInfo_MouseEnter);
            this.updateInfo.MouseLeave += new System.EventHandler(this.updateInfo_MouseLeave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.MediumBlue;
            this.label12.Location = new System.Drawing.Point(34, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 24);
            this.label12.TabIndex = 22;
            this.label12.Text = "*";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label10.Location = new System.Drawing.Point(765, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "User: Admin";
            // 
            // warningbackup
            // 
            this.warningbackup.AutoSize = true;
            this.warningbackup.BackColor = System.Drawing.Color.Transparent;
            this.warningbackup.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningbackup.ForeColor = System.Drawing.Color.Red;
            this.warningbackup.Location = new System.Drawing.Point(32, 205);
            this.warningbackup.Name = "warningbackup";
            this.warningbackup.Size = new System.Drawing.Size(0, 15);
            this.warningbackup.TabIndex = 23;
            // 
            // backupDBbtn
            // 
            this.backupDBbtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.backupDBbtn.BackColor = System.Drawing.Color.PaleGreen;
            this.backupDBbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backupDBbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backupDBbtn.Location = new System.Drawing.Point(627, 172);
            this.backupDBbtn.Name = "backupDBbtn";
            this.backupDBbtn.Size = new System.Drawing.Size(100, 25);
            this.backupDBbtn.TabIndex = 24;
            this.backupDBbtn.Text = "Backup Now";
            this.backupDBbtn.UseVisualStyleBackColor = false;
            this.backupDBbtn.Click += new System.EventHandler(this.backupDBbtn_Click);
            // 
            // usrswitch
            // 
            this.usrswitch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.usrswitch.AutoSize = true;
            this.usrswitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usrswitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrswitch.ForeColor = System.Drawing.Color.Blue;
            this.usrswitch.Location = new System.Drawing.Point(776, 30);
            this.usrswitch.Name = "usrswitch";
            this.usrswitch.Size = new System.Drawing.Size(72, 15);
            this.usrswitch.TabIndex = 40;
            this.usrswitch.Text = "Switch User";
            this.usrswitch.Click += new System.EventHandler(this.usrswitch_Click);
            this.usrswitch.MouseEnter += new System.EventHandler(this.usrswitch_MouseEnter);
            this.usrswitch.MouseLeave += new System.EventHandler(this.usrswitch_MouseLeave);
            // 
            // Preferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(864, 625);
            this.Controls.Add(this.usrswitch);
            this.Controls.Add(this.backupDBbtn);
            this.Controls.Add(this.warningbackup);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.prefexitbtn);
            this.Controls.Add(this.updatebackupdbbtn);
            this.Controls.Add(this.backupdbpathpref);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dbpathpref);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updatedbpathbtn);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Preferences";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuickBill-Invoice";
            this.Activated += new System.EventHandler(this.Preferences_Activated);
            this.Load += new System.EventHandler(this.Preferences_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updatedbpathbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dbpathpref;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox backupdbpathpref;
        private System.Windows.Forms.Button updatebackupdbbtn;
        private System.Windows.Forms.Label createuserlbl;
        private System.Windows.Forms.Label updatecurrntuserpwd;
        private System.Windows.Forms.Label addupdatecat;
        private System.Windows.Forms.Button prefexitbtn;
        private System.Windows.Forms.Label contactus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label addandupdatesubcat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label chkstockpref;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label warningbackup;
        private System.Windows.Forms.Label updateInfo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label previnvoice;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button backupDBbtn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label detailReport;
        private System.Windows.Forms.Label usrswitch;
    }
}