using System;

namespace QuickBill
{
    partial class billing
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(billing));
            this.billingHeader = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.billingDone = new System.Windows.Forms.Button();
            this.billstockbtn = new System.Windows.Forms.Button();
            this.searchItemcb = new System.Windows.Forms.ComboBox();
            this.billcat = new System.Windows.Forms.TextBox();
            this.spricetb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.discounttb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cgsttb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.billList = new System.Windows.Forms.DataGridView();
            this.item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantiy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.munit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellingTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sgst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cgst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addbtnbill = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.sgsttb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.desc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mu = new System.Windows.Forms.TextBox();
            this.withoutstock = new System.Windows.Forms.CheckBox();
            this.rmvbillitem = new System.Windows.Forms.Button();
            this.Editqty = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.manualinvoiceno = new System.Windows.Forms.TextBox();
            this.manualprefix = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.currentstocklbl = new System.Windows.Forms.Label();
            this.resetbtn = new System.Windows.Forms.Button();
            this.usrswitch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.billList)).BeginInit();
            this.SuspendLayout();
            // 
            // billingHeader
            // 
            this.billingHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.billingHeader.AutoSize = true;
            this.billingHeader.Font = new System.Drawing.Font("Lucida Sans Unicode", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billingHeader.Location = new System.Drawing.Point(474, 32);
            this.billingHeader.Name = "billingHeader";
            this.billingHeader.Size = new System.Drawing.Size(159, 23);
            this.billingHeader.TabIndex = 0;
            this.billingHeader.Text = "Create Invoice";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search For Items";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // billingDone
            // 
            this.billingDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.billingDone.BackColor = System.Drawing.Color.LightSteelBlue;
            this.billingDone.Location = new System.Drawing.Point(885, 698);
            this.billingDone.Name = "billingDone";
            this.billingDone.Size = new System.Drawing.Size(98, 37);
            this.billingDone.TabIndex = 7;
            this.billingDone.Text = "Done";
            this.billingDone.UseVisualStyleBackColor = false;
            // 
            // billstockbtn
            // 
            this.billstockbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.billstockbtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.billstockbtn.Location = new System.Drawing.Point(23, 698);
            this.billstockbtn.Name = "billstockbtn";
            this.billstockbtn.Size = new System.Drawing.Size(183, 36);
            this.billstockbtn.TabIndex = 10;
            this.billstockbtn.Text = "Check and Update Stock";
            this.billstockbtn.UseVisualStyleBackColor = false;
            this.billstockbtn.Click += new System.EventHandler(this.billstockbtn_Click);
            // 
            // searchItemcb
            // 
            this.searchItemcb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.searchItemcb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.searchItemcb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.searchItemcb.DropDownWidth = 450;
            this.searchItemcb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchItemcb.FormattingEnabled = true;
            this.searchItemcb.Location = new System.Drawing.Point(12, 120);
            this.searchItemcb.Name = "searchItemcb";
            this.searchItemcb.Size = new System.Drawing.Size(298, 23);
            this.searchItemcb.TabIndex = 11;
            this.searchItemcb.SelectedIndexChanged += new System.EventHandler(this.searchItemcb_SelectedIndexChanged);
            this.searchItemcb.TextChanged += new System.EventHandler(this.searchItemcb_TextChanged);
            // 
            // billcat
            // 
            this.billcat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.billcat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.billcat.Enabled = false;
            this.billcat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billcat.Location = new System.Drawing.Point(333, 120);
            this.billcat.Name = "billcat";
            this.billcat.Size = new System.Drawing.Size(126, 21);
            this.billcat.TabIndex = 12;
            // 
            // spricetb
            // 
            this.spricetb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.spricetb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spricetb.Enabled = false;
            this.spricetb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spricetb.Location = new System.Drawing.Point(623, 120);
            this.spricetb.Name = "spricetb";
            this.spricetb.Size = new System.Drawing.Size(103, 21);
            this.spricetb.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(620, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Price/Unit";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(330, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Catagory";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(748, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Discount (INR)";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // discounttb
            // 
            this.discounttb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.discounttb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.discounttb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discounttb.Location = new System.Drawing.Point(751, 120);
            this.discounttb.Name = "discounttb";
            this.discounttb.Size = new System.Drawing.Size(91, 21);
            this.discounttb.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(938, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "CGST(%)";
            // 
            // cgsttb
            // 
            this.cgsttb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cgsttb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cgsttb.Enabled = false;
            this.cgsttb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cgsttb.Location = new System.Drawing.Point(940, 120);
            this.cgsttb.Name = "cgsttb";
            this.cgsttb.Size = new System.Drawing.Size(53, 21);
            this.cgsttb.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(487, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "Measuring Unit";
            // 
            // billList
            // 
            this.billList.AllowUserToAddRows = false;
            this.billList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.billList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.billList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.billList.BackgroundColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.billList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.billList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.billList.DefaultCellStyle = dataGridViewCellStyle3;
            this.billList.Location = new System.Drawing.Point(12, 232);
            this.billList.Name = "billList";
            this.billList.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.billList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.billList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.billList.Size = new System.Drawing.Size(984, 372);
            this.billList.TabIndex = 25;
            this.billList.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.billList_RowsAdded);
            this.billList.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.billList_RowsRemoved);
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
            // addbtnbill
            // 
            this.addbtnbill.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addbtnbill.BackColor = System.Drawing.Color.LightSteelBlue;
            this.addbtnbill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addbtnbill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtnbill.Location = new System.Drawing.Point(614, 179);
            this.addbtnbill.Name = "addbtnbill";
            this.addbtnbill.Size = new System.Drawing.Size(94, 32);
            this.addbtnbill.TabIndex = 26;
            this.addbtnbill.Text = "Add";
            this.addbtnbill.UseVisualStyleBackColor = false;
            this.addbtnbill.Click += new System.EventHandler(this.addbtnbill_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Location = new System.Drawing.Point(357, 697);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 37);
            this.button1.TabIndex = 27;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button2.Location = new System.Drawing.Point(629, 698);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 37);
            this.button2.TabIndex = 28;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(862, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "SGST(%)";
            // 
            // sgsttb
            // 
            this.sgsttb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.sgsttb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sgsttb.Enabled = false;
            this.sgsttb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sgsttb.Location = new System.Drawing.Point(865, 120);
            this.sgsttb.Name = "sgsttb";
            this.sgsttb.Size = new System.Drawing.Size(53, 21);
            this.sgsttb.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(-89, 159);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 16);
            this.label10.TabIndex = 32;
            this.label10.Text = "Description";
            // 
            // desc
            // 
            this.desc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.desc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc.Location = new System.Drawing.Point(13, 169);
            this.desc.Multiline = true;
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(229, 37);
            this.desc.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 33;
            this.label5.Text = "Description";
            // 
            // mu
            // 
            this.mu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.mu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mu.Enabled = false;
            this.mu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mu.Location = new System.Drawing.Point(488, 120);
            this.mu.Name = "mu";
            this.mu.Size = new System.Drawing.Size(105, 21);
            this.mu.TabIndex = 34;
            // 
            // withoutstock
            // 
            this.withoutstock.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.withoutstock.AutoCheck = false;
            this.withoutstock.AutoSize = true;
            this.withoutstock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withoutstock.Location = new System.Drawing.Point(459, 189);
            this.withoutstock.Name = "withoutstock";
            this.withoutstock.Size = new System.Drawing.Size(149, 17);
            this.withoutstock.TabIndex = 35;
            this.withoutstock.Text = "Disable Stock Maintaining";
            this.withoutstock.UseVisualStyleBackColor = true;
            this.withoutstock.CheckedChanged += new System.EventHandler(this.withoutstock_CheckedChanged);
            this.withoutstock.Click += new System.EventHandler(this.withoutstock_Click);
            // 
            // rmvbillitem
            // 
            this.rmvbillitem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rmvbillitem.BackColor = System.Drawing.Color.Thistle;
            this.rmvbillitem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rmvbillitem.Location = new System.Drawing.Point(13, 622);
            this.rmvbillitem.Name = "rmvbillitem";
            this.rmvbillitem.Size = new System.Drawing.Size(75, 36);
            this.rmvbillitem.TabIndex = 36;
            this.rmvbillitem.Text = "Remove";
            this.rmvbillitem.UseVisualStyleBackColor = false;
            this.rmvbillitem.Click += new System.EventHandler(this.rmvbillitem_Click);
            // 
            // Editqty
            // 
            this.Editqty.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Editqty.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Editqty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Editqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editqty.Location = new System.Drawing.Point(309, 622);
            this.Editqty.Name = "Editqty";
            this.Editqty.Size = new System.Drawing.Size(94, 36);
            this.Editqty.TabIndex = 37;
            this.Editqty.Text = "Edit Quantity";
            this.Editqty.UseVisualStyleBackColor = false;
            this.Editqty.Click += new System.EventHandler(this.Editqty_Click);
            // 
            // next
            // 
            this.next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.next.BackColor = System.Drawing.Color.LightSteelBlue;
            this.next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.next.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.Location = new System.Drawing.Point(902, 622);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(94, 36);
            this.next.TabIndex = 38;
            this.next.Text = "Next";
            this.next.UseVisualStyleBackColor = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(261, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 15);
            this.label11.TabIndex = 41;
            this.label11.Text = "Invoice No";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // manualinvoiceno
            // 
            this.manualinvoiceno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.manualinvoiceno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.manualinvoiceno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manualinvoiceno.Location = new System.Drawing.Point(318, 185);
            this.manualinvoiceno.Name = "manualinvoiceno";
            this.manualinvoiceno.Size = new System.Drawing.Size(126, 21);
            this.manualinvoiceno.TabIndex = 40;
            this.manualinvoiceno.TextChanged += new System.EventHandler(this.manualinvoiceno_TextChanged);
            // 
            // manualprefix
            // 
            this.manualprefix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.manualprefix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.manualprefix.Enabled = false;
            this.manualprefix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manualprefix.Location = new System.Drawing.Point(264, 185);
            this.manualprefix.Name = "manualprefix";
            this.manualprefix.Size = new System.Drawing.Size(48, 21);
            this.manualprefix.TabIndex = 42;
            this.manualprefix.TextChanged += new System.EventHandler(this.manualprefix_TextChanged);
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(321, 155);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(13, 16);
            this.label17.TabIndex = 64;
            this.label17.Text = "*";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // currentstocklbl
            // 
            this.currentstocklbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.currentstocklbl.AutoSize = true;
            this.currentstocklbl.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.currentstocklbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentstocklbl.ForeColor = System.Drawing.Color.White;
            this.currentstocklbl.Location = new System.Drawing.Point(12, 209);
            this.currentstocklbl.Name = "currentstocklbl";
            this.currentstocklbl.Size = new System.Drawing.Size(0, 13);
            this.currentstocklbl.TabIndex = 65;
            // 
            // resetbtn
            // 
            this.resetbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.resetbtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.resetbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetbtn.Location = new System.Drawing.Point(616, 622);
            this.resetbtn.Name = "resetbtn";
            this.resetbtn.Size = new System.Drawing.Size(94, 36);
            this.resetbtn.TabIndex = 66;
            this.resetbtn.Text = "Reset";
            this.resetbtn.UseVisualStyleBackColor = false;
            this.resetbtn.Click += new System.EventHandler(this.resetbtn_Click);
            // 
            // usrswitch
            // 
            this.usrswitch.AutoSize = true;
            this.usrswitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usrswitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrswitch.ForeColor = System.Drawing.Color.Blue;
            this.usrswitch.Location = new System.Drawing.Point(931, 19);
            this.usrswitch.Name = "usrswitch";
            this.usrswitch.Size = new System.Drawing.Size(64, 13);
            this.usrswitch.TabIndex = 67;
            this.usrswitch.Text = "Switch User";
            this.usrswitch.Click += new System.EventHandler(this.usrswitch_Click);
            this.usrswitch.MouseEnter += new System.EventHandler(this.usrswitch_MouseEnter);
            this.usrswitch.MouseLeave += new System.EventHandler(this.usrswitch_MouseLeave);
            // 
            // billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1008, 682);
            this.Controls.Add(this.usrswitch);
            this.Controls.Add(this.resetbtn);
            this.Controls.Add(this.currentstocklbl);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.manualprefix);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.manualinvoiceno);
            this.Controls.Add(this.next);
            this.Controls.Add(this.Editqty);
            this.Controls.Add(this.rmvbillitem);
            this.Controls.Add(this.withoutstock);
            this.Controls.Add(this.mu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.sgsttb);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addbtnbill);
            this.Controls.Add(this.billList);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cgsttb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.discounttb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.spricetb);
            this.Controls.Add(this.billcat);
            this.Controls.Add(this.searchItemcb);
            this.Controls.Add(this.billstockbtn);
            this.Controls.Add(this.billingDone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.billingHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "billing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuickBill-Invoice";
            this.Activated += new System.EventHandler(this.billing_Activated);
            this.Load += new System.EventHandler(this.billing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.billList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label17_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void manualprefix_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void manualinvoiceno_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label billingHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button billingDone;
        private System.Windows.Forms.Button billstockbtn;
        private System.Windows.Forms.ComboBox searchItemcb;
        private System.Windows.Forms.TextBox billcat;
        private System.Windows.Forms.TextBox spricetb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox discounttb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox cgsttb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button addbtnbill;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox sgsttb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox desc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox mu;
        internal System.Windows.Forms.DataGridView billList;
        private System.Windows.Forms.DataGridViewTextBoxColumn item;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantiy;
        private System.Windows.Forms.DataGridViewTextBoxColumn munit;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellingTotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn sgst;
        private System.Windows.Forms.DataGridViewTextBoxColumn cgst;
        private System.Windows.Forms.CheckBox withoutstock;
        private System.Windows.Forms.Button rmvbillitem;
        private System.Windows.Forms.Button Editqty;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox manualinvoiceno;
        private System.Windows.Forms.TextBox manualprefix;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label currentstocklbl;
        private System.Windows.Forms.Button resetbtn;
        private System.Windows.Forms.Label usrswitch;
    }
}