namespace QuickBill
{
    partial class catagoryInitiation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(catagoryInitiation));
            this.catHeader = new System.Windows.Forms.Label();
            this.catPanel = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.cgsttb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mucombobox = new System.Windows.Forms.ComboBox();
            this.sgsttb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.catAddbtn = new System.Windows.Forms.Button();
            this.insertcattextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.catSave = new System.Windows.Forms.Button();
            this.catEdit = new System.Windows.Forms.Button();
            this.catRmv = new System.Windows.Forms.Button();
            this.catDataShow = new System.Windows.Forms.DataGridView();
            this.catid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.munit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cattax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CGST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catDataShow)).BeginInit();
            this.SuspendLayout();
            // 
            // catHeader
            // 
            this.catHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.catHeader.AutoSize = true;
            this.catHeader.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catHeader.Location = new System.Drawing.Point(456, 40);
            this.catHeader.Name = "catHeader";
            this.catHeader.Size = new System.Drawing.Size(103, 24);
            this.catHeader.TabIndex = 1;
            this.catHeader.Text = "Catagory";
            this.catHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.catHeader.Click += new System.EventHandler(this.label1_Click);
            // 
            // catPanel
            // 
            this.catPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.catPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.catPanel.Controls.Add(this.splitContainer1);
            this.catPanel.Location = new System.Drawing.Point(50, 116);
            this.catPanel.Name = "catPanel";
            this.catPanel.Size = new System.Drawing.Size(925, 595);
            this.catPanel.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.DarkGray;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.cgsttb);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.mucombobox);
            this.splitContainer1.Panel1.Controls.Add(this.sgsttb);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.catAddbtn);
            this.splitContainer1.Panel1.Controls.Add(this.insertcattextbox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.LightGray;
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.catSave);
            this.splitContainer1.Panel2.Controls.Add(this.catEdit);
            this.splitContainer1.Panel2.Controls.Add(this.catRmv);
            this.splitContainer1.Panel2.Controls.Add(this.catDataShow);
            this.splitContainer1.Size = new System.Drawing.Size(925, 595);
            this.splitContainer1.SplitterDistance = 307;
            this.splitContainer1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "CGST (%)";
            // 
            // cgsttb
            // 
            this.cgsttb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cgsttb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cgsttb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cgsttb.Location = new System.Drawing.Point(16, 269);
            this.cgsttb.Name = "cgsttb";
            this.cgsttb.Size = new System.Drawing.Size(269, 22);
            this.cgsttb.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(116, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(159, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "SGST (%)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Select Measuring Unit";
            // 
            // mucombobox
            // 
            this.mucombobox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mucombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mucombobox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mucombobox.FormattingEnabled = true;
            this.mucombobox.Items.AddRange(new object[] {
            "pcs",
            "kilogram",
            "gram",
            "milligram",
            "litre",
            "millilitre"});
            this.mucombobox.Location = new System.Drawing.Point(16, 129);
            this.mucombobox.Name = "mucombobox";
            this.mucombobox.Size = new System.Drawing.Size(269, 23);
            this.mucombobox.TabIndex = 5;
            this.mucombobox.SelectedIndexChanged += new System.EventHandler(this.mucombobox_SelectedIndexChanged);
            // 
            // sgsttb
            // 
            this.sgsttb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sgsttb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sgsttb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sgsttb.Location = new System.Drawing.Point(16, 202);
            this.sgsttb.Name = "sgsttb";
            this.sgsttb.Size = new System.Drawing.Size(269, 22);
            this.sgsttb.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Insert Catagory";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // catAddbtn
            // 
            this.catAddbtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.catAddbtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.catAddbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.catAddbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catAddbtn.Location = new System.Drawing.Point(16, 329);
            this.catAddbtn.Name = "catAddbtn";
            this.catAddbtn.Size = new System.Drawing.Size(113, 32);
            this.catAddbtn.TabIndex = 1;
            this.catAddbtn.Text = "Add";
            this.catAddbtn.UseVisualStyleBackColor = false;
            this.catAddbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // insertcattextbox
            // 
            this.insertcattextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.insertcattextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.insertcattextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertcattextbox.Location = new System.Drawing.Point(16, 55);
            this.insertcattextbox.Name = "insertcattextbox";
            this.insertcattextbox.Size = new System.Drawing.Size(269, 22);
            this.insertcattextbox.TabIndex = 0;
            this.insertcattextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Catagories";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // catSave
            // 
            this.catSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.catSave.BackColor = System.Drawing.Color.LightSkyBlue;
            this.catSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.catSave.Location = new System.Drawing.Point(522, 547);
            this.catSave.Name = "catSave";
            this.catSave.Size = new System.Drawing.Size(75, 36);
            this.catSave.TabIndex = 3;
            this.catSave.Text = "Done";
            this.catSave.UseVisualStyleBackColor = false;
            this.catSave.Click += new System.EventHandler(this.button3_Click);
            // 
            // catEdit
            // 
            this.catEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.catEdit.BackColor = System.Drawing.Color.LightSteelBlue;
            this.catEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.catEdit.Location = new System.Drawing.Point(277, 547);
            this.catEdit.Name = "catEdit";
            this.catEdit.Size = new System.Drawing.Size(82, 36);
            this.catEdit.TabIndex = 2;
            this.catEdit.Text = "Edit";
            this.catEdit.UseVisualStyleBackColor = false;
            this.catEdit.Click += new System.EventHandler(this.button2_Click);
            // 
            // catRmv
            // 
            this.catRmv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.catRmv.BackColor = System.Drawing.Color.Thistle;
            this.catRmv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.catRmv.Location = new System.Drawing.Point(22, 547);
            this.catRmv.Name = "catRmv";
            this.catRmv.Size = new System.Drawing.Size(75, 36);
            this.catRmv.TabIndex = 1;
            this.catRmv.Text = "Remove";
            this.catRmv.UseVisualStyleBackColor = false;
            this.catRmv.Click += new System.EventHandler(this.catRmv_Click);
            // 
            // catDataShow
            // 
            this.catDataShow.AllowUserToAddRows = false;
            this.catDataShow.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.catDataShow.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.catDataShow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.catDataShow.BackgroundColor = System.Drawing.Color.Gray;
            this.catDataShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.catDataShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.catid,
            this.catname,
            this.munit,
            this.cattax,
            this.CGST});
            this.catDataShow.Location = new System.Drawing.Point(22, 55);
            this.catDataShow.Name = "catDataShow";
            this.catDataShow.ReadOnly = true;
            this.catDataShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.catDataShow.ShowCellErrors = false;
            this.catDataShow.Size = new System.Drawing.Size(575, 481);
            this.catDataShow.TabIndex = 0;
            // 
            // catid
            // 
            this.catid.DataPropertyName = "CatId";
            this.catid.HeaderText = "ID";
            this.catid.MinimumWidth = 2;
            this.catid.Name = "catid";
            this.catid.ReadOnly = true;
            this.catid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.catid.Visible = false;
            this.catid.Width = 2;
            // 
            // catname
            // 
            this.catname.DataPropertyName = "Catagory";
            this.catname.HeaderText = "Catagory Name";
            this.catname.Name = "catname";
            this.catname.ReadOnly = true;
            this.catname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.catname.Width = 270;
            // 
            // munit
            // 
            this.munit.DataPropertyName = "MeasuringUnit";
            this.munit.HeaderText = "Measuring Unit";
            this.munit.Name = "munit";
            this.munit.ReadOnly = true;
            this.munit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.munit.Width = 120;
            // 
            // cattax
            // 
            this.cattax.DataPropertyName = "sgst";
            this.cattax.HeaderText = "SGST (%)";
            this.cattax.Name = "cattax";
            this.cattax.ReadOnly = true;
            this.cattax.Width = 70;
            // 
            // CGST
            // 
            this.CGST.DataPropertyName = "cgst";
            this.CGST.HeaderText = "CGST (%)";
            this.CGST.Name = "CGST";
            this.CGST.ReadOnly = true;
            this.CGST.Width = 70;
            // 
            // catagoryInitiation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1016, 741);
            this.Controls.Add(this.catPanel);
            this.Controls.Add(this.catHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "catagoryInitiation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuickBill-Invoice";
            this.Activated += new System.EventHandler(this.catagoryInitiation_Activated);
            this.Load += new System.EventHandler(this.catagoryInitiation_Load);
            this.Resize += new System.EventHandler(this.catagoryInitiation_Resize);
            this.catPanel.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.catDataShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label catHeader;
        private System.Windows.Forms.Panel catPanel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button catAddbtn;
        private System.Windows.Forms.TextBox insertcattextbox;
        private System.Windows.Forms.DataGridView catDataShow;
        private System.Windows.Forms.Button catSave;
        private System.Windows.Forms.Button catEdit;
        private System.Windows.Forms.Button catRmv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox mucombobox;
        private System.Windows.Forms.TextBox sgsttb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cgsttb;
        private System.Windows.Forms.DataGridViewTextBoxColumn catid;
        private System.Windows.Forms.DataGridViewTextBoxColumn catname;
        private System.Windows.Forms.DataGridViewTextBoxColumn munit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cattax;
        private System.Windows.Forms.DataGridViewTextBoxColumn CGST;
    }
}