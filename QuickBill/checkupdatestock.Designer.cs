namespace QuickBill
{
    partial class checkupdatestock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(checkupdatestock));
            this.label1 = new System.Windows.Forms.Label();
            this.stocksearchtb = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.itemdetails = new System.Windows.Forms.DataGridView();
            this.ItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockitems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remainingstock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockmsgunit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockcat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cancel = new System.Windows.Forms.Button();
            this.updatestock = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemdetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Check  and Update Stock";
            // 
            // stocksearchtb
            // 
            this.stocksearchtb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.stocksearchtb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stocksearchtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stocksearchtb.Location = new System.Drawing.Point(12, 62);
            this.stocksearchtb.Name = "stocksearchtb";
            this.stocksearchtb.Size = new System.Drawing.Size(253, 22);
            this.stocksearchtb.TabIndex = 1;
            this.stocksearchtb.TextChanged += new System.EventHandler(this.stocksearchtxtbox_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Location = new System.Drawing.Point(29, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 330);
            this.panel1.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.stocksearchtb);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.LightGray;
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.itemdetails);
            this.splitContainer1.Size = new System.Drawing.Size(796, 330);
            this.splitContainer1.SplitterDistance = 278;
            this.splitContainer1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search For Items";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Search Results";
            // 
            // itemdetails
            // 
            this.itemdetails.AllowUserToAddRows = false;
            this.itemdetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.itemdetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.itemdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemdetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemId,
            this.stockitems,
            this.remainingstock,
            this.stockmsgunit,
            this.stockcat,
            this.pprice,
            this.sprice});
            this.itemdetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.itemdetails.Location = new System.Drawing.Point(0, 62);
            this.itemdetails.Name = "itemdetails";
            this.itemdetails.ReadOnly = true;
            this.itemdetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itemdetails.Size = new System.Drawing.Size(514, 268);
            this.itemdetails.TabIndex = 0;
            // 
            // ItemId
            // 
            this.ItemId.DataPropertyName = "ItemId";
            this.ItemId.HeaderText = "ItemId";
            this.ItemId.Name = "ItemId";
            this.ItemId.ReadOnly = true;
            this.ItemId.Visible = false;
            // 
            // stockitems
            // 
            this.stockitems.DataPropertyName = "ItemName";
            this.stockitems.HeaderText = "Items";
            this.stockitems.Name = "stockitems";
            this.stockitems.ReadOnly = true;
            this.stockitems.Width = 200;
            // 
            // remainingstock
            // 
            this.remainingstock.DataPropertyName = "stock_Quantity";
            this.remainingstock.HeaderText = "Remaining Stock";
            this.remainingstock.Name = "remainingstock";
            this.remainingstock.ReadOnly = true;
            // 
            // stockmsgunit
            // 
            this.stockmsgunit.DataPropertyName = "MeasuringUnit";
            this.stockmsgunit.HeaderText = "Measuring Unit";
            this.stockmsgunit.Name = "stockmsgunit";
            this.stockmsgunit.ReadOnly = true;
            this.stockmsgunit.Width = 70;
            // 
            // stockcat
            // 
            this.stockcat.DataPropertyName = "Catagory";
            this.stockcat.HeaderText = "Catagory";
            this.stockcat.Name = "stockcat";
            this.stockcat.ReadOnly = true;
            // 
            // pprice
            // 
            this.pprice.DataPropertyName = "purchase_price";
            this.pprice.HeaderText = "Purchased Price";
            this.pprice.Name = "pprice";
            this.pprice.ReadOnly = true;
            this.pprice.Visible = false;
            // 
            // sprice
            // 
            this.sprice.DataPropertyName = "selling_price";
            this.sprice.HeaderText = "Selling Price";
            this.sprice.Name = "sprice";
            this.sprice.ReadOnly = true;
            this.sprice.Visible = false;
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(29, 426);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(100, 33);
            this.cancel.TabIndex = 4;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.backBilling_Click);
            // 
            // updatestock
            // 
            this.updatestock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.updatestock.BackColor = System.Drawing.Color.LightSkyBlue;
            this.updatestock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updatestock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatestock.Location = new System.Drawing.Point(683, 426);
            this.updatestock.Name = "updatestock";
            this.updatestock.Size = new System.Drawing.Size(142, 33);
            this.updatestock.TabIndex = 5;
            this.updatestock.Text = "Update Stock";
            this.updatestock.UseVisualStyleBackColor = false;
            this.updatestock.Click += new System.EventHandler(this.updatestock_Click);
            // 
            // checkupdatestock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CancelButton = this.cancel;
            this.ClientSize = new System.Drawing.Size(851, 480);
            this.Controls.Add(this.updatestock);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "checkupdatestock";
            this.Text = "QuickBill";
            this.Activated += new System.EventHandler(this.checkupdatestock_Activated);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itemdetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox stocksearchtb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView itemdetails;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button updatestock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockitems;
        private System.Windows.Forms.DataGridViewTextBoxColumn remainingstock;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockmsgunit;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockcat;
        private System.Windows.Forms.DataGridViewTextBoxColumn pprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn sprice;
    }
}