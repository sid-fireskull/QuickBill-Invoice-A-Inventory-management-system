namespace QuickBill
{
    partial class subCatagoryInitiation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(subCatagoryInitiation));
            this.label1 = new System.Windows.Forms.Label();
            this.subcattb = new System.Windows.Forms.TextBox();
            this.stockqty = new System.Windows.Forms.TextBox();
            this.pprice = new System.Windows.Forms.TextBox();
            this.selectcatcombo = new System.Windows.Forms.ComboBox();
            this.sellprice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addsubcatbtn = new System.Windows.Forms.Button();
            this.subCatList = new System.Windows.Forms.DataGridView();
            this.ItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subcat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subCatDone = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.mulabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.subCatList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(440, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sub - Catagory";
            // 
            // subcattb
            // 
            this.subcattb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subcattb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subcattb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subcattb.Location = new System.Drawing.Point(27, 133);
            this.subcattb.Name = "subcattb";
            this.subcattb.Size = new System.Drawing.Size(392, 22);
            this.subcattb.TabIndex = 1;
            this.subcattb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // stockqty
            // 
            this.stockqty.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.stockqty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stockqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockqty.Location = new System.Drawing.Point(599, 133);
            this.stockqty.Name = "stockqty";
            this.stockqty.Size = new System.Drawing.Size(114, 22);
            this.stockqty.TabIndex = 2;
            this.stockqty.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // pprice
            // 
            this.pprice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pprice.Location = new System.Drawing.Point(739, 133);
            this.pprice.Name = "pprice";
            this.pprice.Size = new System.Drawing.Size(111, 22);
            this.pprice.TabIndex = 4;
            this.pprice.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // selectcatcombo
            // 
            this.selectcatcombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectcatcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectcatcombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectcatcombo.FormattingEnabled = true;
            this.selectcatcombo.Location = new System.Drawing.Point(444, 133);
            this.selectcatcombo.Name = "selectcatcombo";
            this.selectcatcombo.Size = new System.Drawing.Size(134, 24);
            this.selectcatcombo.TabIndex = 5;
            this.selectcatcombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // sellprice
            // 
            this.sellprice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sellprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sellprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellprice.Location = new System.Drawing.Point(873, 133);
            this.sellprice.Name = "sellprice";
            this.sellprice.Size = new System.Drawing.Size(108, 22);
            this.sellprice.TabIndex = 6;
            this.sellprice.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Insert Sub-Catagory (Items)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(441, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Select Catagory";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(596, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Stock Quantity";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(736, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Purchase Price";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(870, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Selling Price";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // addsubcatbtn
            // 
            this.addsubcatbtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.addsubcatbtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.addsubcatbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addsubcatbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addsubcatbtn.Location = new System.Drawing.Point(840, 166);
            this.addsubcatbtn.Name = "addsubcatbtn";
            this.addsubcatbtn.Size = new System.Drawing.Size(141, 35);
            this.addsubcatbtn.TabIndex = 14;
            this.addsubcatbtn.Text = "Add";
            this.addsubcatbtn.UseVisualStyleBackColor = false;
            this.addsubcatbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // subCatList
            // 
            this.subCatList.AllowUserToAddRows = false;
            this.subCatList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.subCatList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.subCatList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subCatList.BackgroundColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.subCatList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.subCatList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subCatList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemId,
            this.subcat,
            this.cat,
            this.qty,
            this.sprice,
            this.bprice,
            this.unit});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.subCatList.DefaultCellStyle = dataGridViewCellStyle3;
            this.subCatList.GridColor = System.Drawing.SystemColors.Control;
            this.subCatList.Location = new System.Drawing.Point(27, 223);
            this.subCatList.Name = "subCatList";
            this.subCatList.ReadOnly = true;
            this.subCatList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.subCatList.Size = new System.Drawing.Size(954, 401);
            this.subCatList.TabIndex = 15;
            this.subCatList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.subCatList_CellContentClick);
            // 
            // ItemId
            // 
            this.ItemId.DataPropertyName = "ItemId";
            this.ItemId.HeaderText = "ItemId";
            this.ItemId.MinimumWidth = 2;
            this.ItemId.Name = "ItemId";
            this.ItemId.ReadOnly = true;
            this.ItemId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemId.Visible = false;
            this.ItemId.Width = 30;
            // 
            // subcat
            // 
            this.subcat.DataPropertyName = "ItemName";
            this.subcat.HeaderText = "Items(Sub-Catagory)";
            this.subcat.Name = "subcat";
            this.subcat.ReadOnly = true;
            this.subcat.Width = 350;
            // 
            // cat
            // 
            this.cat.DataPropertyName = "Catagory";
            this.cat.HeaderText = "Catagory";
            this.cat.Name = "cat";
            this.cat.ReadOnly = true;
            this.cat.Width = 197;
            // 
            // qty
            // 
            this.qty.DataPropertyName = "stock_Quantity";
            this.qty.HeaderText = "Stock Quantity";
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            // 
            // sprice
            // 
            this.sprice.DataPropertyName = "selling_price";
            this.sprice.HeaderText = "Selling Price";
            this.sprice.Name = "sprice";
            this.sprice.ReadOnly = true;
            this.sprice.Width = 85;
            // 
            // bprice
            // 
            this.bprice.DataPropertyName = "purchase_price";
            this.bprice.HeaderText = "Purchased Price";
            this.bprice.Name = "bprice";
            this.bprice.ReadOnly = true;
            this.bprice.Width = 85;
            // 
            // unit
            // 
            this.unit.DataPropertyName = "MeasuringUnit";
            this.unit.HeaderText = "Measuring Unit";
            this.unit.Name = "unit";
            this.unit.ReadOnly = true;
            this.unit.Width = 85;
            // 
            // subCatDone
            // 
            this.subCatDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.subCatDone.BackColor = System.Drawing.Color.LightSkyBlue;
            this.subCatDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.subCatDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subCatDone.Location = new System.Drawing.Point(881, 648);
            this.subCatDone.Name = "subCatDone";
            this.subCatDone.Size = new System.Drawing.Size(100, 36);
            this.subCatDone.TabIndex = 16;
            this.subCatDone.Text = "Done";
            this.subCatDone.UseVisualStyleBackColor = false;
            this.subCatDone.Click += new System.EventHandler(this.subCatDone_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(191, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "*";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(541, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(686, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(831, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(948, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "*";
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(27, 648);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(100, 36);
            this.cancel.TabIndex = 22;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = false;
            // 
            // mulabel
            // 
            this.mulabel.AutoSize = true;
            this.mulabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mulabel.ForeColor = System.Drawing.Color.DimGray;
            this.mulabel.Location = new System.Drawing.Point(455, 171);
            this.mulabel.Name = "mulabel";
            this.mulabel.Size = new System.Drawing.Size(0, 12);
            this.mulabel.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackColor = System.Drawing.Color.Thistle;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(318, 648);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 36);
            this.button1.TabIndex = 24;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(626, 648);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 36);
            this.button2.TabIndex = 25;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // subCatagoryInitiation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.cancel;
            this.ClientSize = new System.Drawing.Size(1018, 733);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mulabel);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.subCatDone);
            this.Controls.Add(this.subCatList);
            this.Controls.Add(this.addsubcatbtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sellprice);
            this.Controls.Add(this.selectcatcombo);
            this.Controls.Add(this.pprice);
            this.Controls.Add(this.stockqty);
            this.Controls.Add(this.subcattb);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "subCatagoryInitiation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuickBill-Invoice";
            this.Load += new System.EventHandler(this.subCatagoryInitiation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.subCatList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox subcattb;
        private System.Windows.Forms.TextBox stockqty;
        private System.Windows.Forms.TextBox pprice;
        private System.Windows.Forms.ComboBox selectcatcombo;
        private System.Windows.Forms.TextBox sellprice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addsubcatbtn;
        private System.Windows.Forms.DataGridView subCatList;
        private System.Windows.Forms.Button subCatDone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label mulabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn subcat;
        private System.Windows.Forms.DataGridViewTextBoxColumn cat;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn sprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn bprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
    }
}