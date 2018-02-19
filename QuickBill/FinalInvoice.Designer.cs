namespace QuickBill
{
    partial class FinalInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinalInvoice));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.custNametb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addrtb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mobiletb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.finalsgsttb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.finalcgsttb = new System.Windows.Forms.TextBox();
            this.saveprint = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.totalsgsttb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.totalcgsttb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.totalPricetb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.totalDiscounttb = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.grandtotaltb = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.paymenttypecb = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.paymentDetailstb = new System.Windows.Forms.TextBox();
            this.ItemList = new System.Windows.Forms.DataGridView();
            this.item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantiy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.munit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellingTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sgst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cgst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printpreviewdialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printinvoice = new System.Drawing.Printing.PrintDocument();
            this.printpreviewbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(428, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create and Print Invoice";
            // 
            // custNametb
            // 
            this.custNametb.AllowDrop = true;
            this.custNametb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.custNametb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.custNametb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custNametb.Location = new System.Drawing.Point(32, 96);
            this.custNametb.Name = "custNametb";
            this.custNametb.Size = new System.Drawing.Size(266, 22);
            this.custNametb.TabIndex = 1;
            this.custNametb.TextChanged += new System.EventHandler(this.custNametb_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer\'s Name";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(320, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Address";
            // 
            // addrtb
            // 
            this.addrtb.AllowDrop = true;
            this.addrtb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addrtb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addrtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addrtb.Location = new System.Drawing.Point(319, 96);
            this.addrtb.Multiline = true;
            this.addrtb.Name = "addrtb";
            this.addrtb.Size = new System.Drawing.Size(314, 22);
            this.addrtb.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(655, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Contact No.";
            // 
            // mobiletb
            // 
            this.mobiletb.AllowDrop = true;
            this.mobiletb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mobiletb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mobiletb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobiletb.Location = new System.Drawing.Point(658, 96);
            this.mobiletb.Name = "mobiletb";
            this.mobiletb.Size = new System.Drawing.Size(170, 22);
            this.mobiletb.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(849, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "SGST (%)";
            // 
            // finalsgsttb
            // 
            this.finalsgsttb.AllowDrop = true;
            this.finalsgsttb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.finalsgsttb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.finalsgsttb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalsgsttb.Location = new System.Drawing.Point(852, 96);
            this.finalsgsttb.Name = "finalsgsttb";
            this.finalsgsttb.Size = new System.Drawing.Size(59, 22);
            this.finalsgsttb.TabIndex = 9;
            this.finalsgsttb.Text = "0";
            this.finalsgsttb.TextChanged += new System.EventHandler(this.finalsgsttb_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(931, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "CGST (%)";
            // 
            // finalcgsttb
            // 
            this.finalcgsttb.AllowDrop = true;
            this.finalcgsttb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.finalcgsttb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.finalcgsttb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalcgsttb.Location = new System.Drawing.Point(934, 96);
            this.finalcgsttb.Name = "finalcgsttb";
            this.finalcgsttb.Size = new System.Drawing.Size(56, 22);
            this.finalcgsttb.TabIndex = 11;
            this.finalcgsttb.Text = "0";
            this.finalcgsttb.TextChanged += new System.EventHandler(this.finalcgsttb_TextChanged);
            // 
            // saveprint
            // 
            this.saveprint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveprint.BackColor = System.Drawing.Color.SkyBlue;
            this.saveprint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveprint.BackgroundImage")));
            this.saveprint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveprint.Enabled = false;
            this.saveprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveprint.Location = new System.Drawing.Point(857, 630);
            this.saveprint.Name = "saveprint";
            this.saveprint.Size = new System.Drawing.Size(145, 32);
            this.saveprint.TabIndex = 13;
            this.saveprint.Text = "Save and Print";
            this.saveprint.UseVisualStyleBackColor = false;
            this.saveprint.Click += new System.EventHandler(this.saveprint_Click);
            // 
            // cancel
            // 
            this.cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(20, 630);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(115, 32);
            this.cancel.TabIndex = 15;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(464, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "SGST (INR)";
            // 
            // totalsgsttb
            // 
            this.totalsgsttb.AllowDrop = true;
            this.totalsgsttb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalsgsttb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalsgsttb.Location = new System.Drawing.Point(463, 49);
            this.totalsgsttb.Name = "totalsgsttb";
            this.totalsgsttb.ReadOnly = true;
            this.totalsgsttb.Size = new System.Drawing.Size(72, 22);
            this.totalsgsttb.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(619, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "CGST (INR)";
            // 
            // totalcgsttb
            // 
            this.totalcgsttb.AllowDrop = true;
            this.totalcgsttb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalcgsttb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalcgsttb.Location = new System.Drawing.Point(622, 49);
            this.totalcgsttb.Name = "totalcgsttb";
            this.totalcgsttb.ReadOnly = true;
            this.totalcgsttb.Size = new System.Drawing.Size(72, 22);
            this.totalcgsttb.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(43, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "Total Item Price (INR)";
            // 
            // totalPricetb
            // 
            this.totalPricetb.AllowDrop = true;
            this.totalPricetb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalPricetb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPricetb.Location = new System.Drawing.Point(46, 49);
            this.totalPricetb.Name = "totalPricetb";
            this.totalPricetb.ReadOnly = true;
            this.totalPricetb.Size = new System.Drawing.Size(121, 22);
            this.totalPricetb.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(249, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 15);
            this.label11.TabIndex = 23;
            this.label11.Text = "Total Discount (INR)";
            // 
            // totalDiscounttb
            // 
            this.totalDiscounttb.AllowDrop = true;
            this.totalDiscounttb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalDiscounttb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalDiscounttb.Location = new System.Drawing.Point(252, 49);
            this.totalDiscounttb.Name = "totalDiscounttb";
            this.totalDiscounttb.ReadOnly = true;
            this.totalDiscounttb.Size = new System.Drawing.Size(113, 22);
            this.totalDiscounttb.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(772, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(148, 15);
            this.label12.TabIndex = 25;
            this.label12.Text = "Grand Total Amount (INR)";
            // 
            // grandtotaltb
            // 
            this.grandtotaltb.AllowDrop = true;
            this.grandtotaltb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grandtotaltb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grandtotaltb.Location = new System.Drawing.Point(775, 49);
            this.grandtotaltb.Name = "grandtotaltb";
            this.grandtotaltb.ReadOnly = true;
            this.grandtotaltb.Size = new System.Drawing.Size(154, 22);
            this.grandtotaltb.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.totalsgsttb);
            this.panel1.Controls.Add(this.grandtotaltb);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.totalcgsttb);
            this.panel1.Controls.Add(this.totalDiscounttb);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.totalPricetb);
            this.panel1.Location = new System.Drawing.Point(20, 518);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 90);
            this.panel1.TabIndex = 26;
            // 
            // paymenttypecb
            // 
            this.paymenttypecb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.paymenttypecb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paymenttypecb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymenttypecb.FormattingEnabled = true;
            this.paymenttypecb.Items.AddRange(new object[] {
            "Cash",
            "Credit/Debit Card",
            "Others"});
            this.paymenttypecb.Location = new System.Drawing.Point(32, 159);
            this.paymenttypecb.Name = "paymenttypecb";
            this.paymenttypecb.Size = new System.Drawing.Size(121, 24);
            this.paymenttypecb.TabIndex = 27;
            this.paymenttypecb.SelectedIndexChanged += new System.EventHandler(this.paymenttypecb_SelectedIndexChanged);
            this.paymenttypecb.TextChanged += new System.EventHandler(this.paymenttypecb_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(29, 131);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 15);
            this.label13.TabIndex = 28;
            this.label13.Text = "Payment Type (%)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(130, 72);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 16);
            this.label14.TabIndex = 30;
            this.label14.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(130, 131);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 16);
            this.label15.TabIndex = 31;
            this.label15.Text = "*";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(189, 132);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 15);
            this.label16.TabIndex = 33;
            this.label16.Text = "Payment Details";
            // 
            // paymentDetailstb
            // 
            this.paymentDetailstb.AllowDrop = true;
            this.paymentDetailstb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.paymentDetailstb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paymentDetailstb.Enabled = false;
            this.paymentDetailstb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentDetailstb.Location = new System.Drawing.Point(192, 161);
            this.paymentDetailstb.Multiline = true;
            this.paymentDetailstb.Name = "paymentDetailstb";
            this.paymentDetailstb.Size = new System.Drawing.Size(272, 22);
            this.paymentDetailstb.TabIndex = 32;
            // 
            // ItemList
            // 
            this.ItemList.AllowUserToAddRows = false;
            this.ItemList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ItemList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ItemList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemList.BackgroundColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item,
            this.ItemName,
            this.description,
            this.quantiy,
            this.munit,
            this.sellingTotalPrice,
            this.discount,
            this.sgst,
            this.cgst});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemList.DefaultCellStyle = dataGridViewCellStyle3;
            this.ItemList.Location = new System.Drawing.Point(20, 208);
            this.ItemList.Name = "ItemList";
            this.ItemList.ReadOnly = true;
            this.ItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItemList.Size = new System.Drawing.Size(982, 310);
            this.ItemList.TabIndex = 34;
            // 
            // item
            // 
            this.item.HeaderText = "ItemId";
            this.item.Name = "item";
            this.item.ReadOnly = true;
            this.item.Visible = false;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "Item(s)";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Width = 270;
            // 
            // description
            // 
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Width = 203;
            // 
            // quantiy
            // 
            this.quantiy.HeaderText = "Quantity";
            this.quantiy.Name = "quantiy";
            this.quantiy.ReadOnly = true;
            this.quantiy.Width = 80;
            // 
            // munit
            // 
            this.munit.HeaderText = "Measuring Unit";
            this.munit.Name = "munit";
            this.munit.ReadOnly = true;
            this.munit.Width = 80;
            // 
            // sellingTotalPrice
            // 
            this.sellingTotalPrice.HeaderText = "Price (INR)";
            this.sellingTotalPrice.Name = "sellingTotalPrice";
            this.sellingTotalPrice.ReadOnly = true;
            // 
            // discount
            // 
            this.discount.HeaderText = "Total Discount(INR)";
            this.discount.Name = "discount";
            this.discount.ReadOnly = true;
            this.discount.Width = 85;
            // 
            // sgst
            // 
            this.sgst.HeaderText = "SGST(%)";
            this.sgst.Name = "sgst";
            this.sgst.ReadOnly = true;
            this.sgst.Width = 60;
            // 
            // cgst
            // 
            this.cgst.HeaderText = "CGST (%)";
            this.cgst.Name = "cgst";
            this.cgst.ReadOnly = true;
            this.cgst.Width = 60;
            // 
            // printpreviewdialog
            // 
            this.printpreviewdialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printpreviewdialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printpreviewdialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printpreviewdialog.Enabled = true;
            this.printpreviewdialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printpreviewdialog.Icon")));
            this.printpreviewdialog.Name = "printpreviewdialog";
            this.printpreviewdialog.Visible = false;
            this.printpreviewdialog.Load += new System.EventHandler(this.printpreviewdialog_Load);
            // 
            // printinvoice
            // 
            this.printinvoice.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printinvoice_PrintPage);
            // 
            // printpreviewbtn
            // 
            this.printpreviewbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.printpreviewbtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.printpreviewbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.printpreviewbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.printpreviewbtn.Enabled = false;
            this.printpreviewbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printpreviewbtn.Location = new System.Drawing.Point(483, 630);
            this.printpreviewbtn.Name = "printpreviewbtn";
            this.printpreviewbtn.Size = new System.Drawing.Size(115, 32);
            this.printpreviewbtn.TabIndex = 35;
            this.printpreviewbtn.Text = "Print Preview";
            this.printpreviewbtn.UseVisualStyleBackColor = false;
            this.printpreviewbtn.Click += new System.EventHandler(this.printpreviewbtn_Click);
            // 
            // FinalInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1018, 683);
            this.Controls.Add(this.printpreviewbtn);
            this.Controls.Add(this.ItemList);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.paymentDetailstb);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.paymenttypecb);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.saveprint);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.finalcgsttb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.finalsgsttb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mobiletb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addrtb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.custNametb);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FinalInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quickbill Invoice";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FinalInvoice_FormClosed);
            this.Load += new System.EventHandler(this.FinalInvoice_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button saveprint;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        internal System.Windows.Forms.DataGridView ItemList;
        private System.Windows.Forms.DataGridViewTextBoxColumn item;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantiy;
        private System.Windows.Forms.DataGridViewTextBoxColumn munit;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellingTotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn sgst;
        private System.Windows.Forms.DataGridViewTextBoxColumn cgst;
        internal System.Windows.Forms.TextBox finalsgsttb;
        internal System.Windows.Forms.TextBox finalcgsttb;
        private System.Windows.Forms.PrintPreviewDialog printpreviewdialog;
        private System.Drawing.Printing.PrintDocument printinvoice;
        private System.Windows.Forms.Button printpreviewbtn;
        internal System.Windows.Forms.TextBox custNametb;
        internal System.Windows.Forms.TextBox addrtb;
        internal System.Windows.Forms.TextBox mobiletb;
        internal System.Windows.Forms.TextBox totalsgsttb;
        internal System.Windows.Forms.TextBox totalcgsttb;
        internal System.Windows.Forms.TextBox totalPricetb;
        internal System.Windows.Forms.TextBox totalDiscounttb;
        internal System.Windows.Forms.TextBox grandtotaltb;
        internal System.Windows.Forms.ComboBox paymenttypecb;
        internal System.Windows.Forms.TextBox paymentDetailstb;
    }
}