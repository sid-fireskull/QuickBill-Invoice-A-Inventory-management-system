namespace QuickBill
{
    partial class quantityandconversion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(quantityandconversion));
            this.qtyac = new System.Windows.Forms.TextBox();
            this.qtybc = new System.Windows.Forms.TextBox();
            this.qtyAddbtn = new System.Windows.Forms.Button();
            this.unitSelect = new System.Windows.Forms.ComboBox();
            this.itemmu = new System.Windows.Forms.TextBox();
            this.convert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // qtyac
            // 
            this.qtyac.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.qtyac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.qtyac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyac.Location = new System.Drawing.Point(431, 119);
            this.qtyac.Name = "qtyac";
            this.qtyac.Size = new System.Drawing.Size(99, 22);
            this.qtyac.TabIndex = 13;
            this.qtyac.TextChanged += new System.EventHandler(this.qtyac_TextChanged);
            // 
            // qtybc
            // 
            this.qtybc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.qtybc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.qtybc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtybc.Location = new System.Drawing.Point(12, 118);
            this.qtybc.Name = "qtybc";
            this.qtybc.Size = new System.Drawing.Size(137, 22);
            this.qtybc.TabIndex = 12;
            this.qtybc.TextChanged += new System.EventHandler(this.qtybc_TextChanged);
            // 
            // qtyAddbtn
            // 
            this.qtyAddbtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.qtyAddbtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.qtyAddbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.qtyAddbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyAddbtn.Location = new System.Drawing.Point(470, 214);
            this.qtyAddbtn.Name = "qtyAddbtn";
            this.qtyAddbtn.Size = new System.Drawing.Size(132, 32);
            this.qtyAddbtn.TabIndex = 11;
            this.qtyAddbtn.Text = "Add";
            this.qtyAddbtn.UseVisualStyleBackColor = false;
            this.qtyAddbtn.Click += new System.EventHandler(this.qtyAddbtn_Click);
            // 
            // unitSelect
            // 
            this.unitSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.unitSelect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.unitSelect.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.unitSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitSelect.FormattingEnabled = true;
            this.unitSelect.Location = new System.Drawing.Point(157, 118);
            this.unitSelect.Name = "unitSelect";
            this.unitSelect.Size = new System.Drawing.Size(84, 23);
            this.unitSelect.TabIndex = 14;
            this.unitSelect.SelectedIndexChanged += new System.EventHandler(this.unitSelect_SelectedIndexChanged);
            // 
            // itemmu
            // 
            this.itemmu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemmu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemmu.Cursor = System.Windows.Forms.Cursors.No;
            this.itemmu.Enabled = false;
            this.itemmu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemmu.Location = new System.Drawing.Point(540, 119);
            this.itemmu.Name = "itemmu";
            this.itemmu.Size = new System.Drawing.Size(79, 22);
            this.itemmu.TabIndex = 15;
            this.itemmu.TextChanged += new System.EventHandler(this.itemmu_TextChanged);
            // 
            // convert
            // 
            this.convert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.convert.BackColor = System.Drawing.Color.LightSteelBlue;
            this.convert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.convert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convert.Location = new System.Drawing.Point(261, 116);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(148, 29);
            this.convert.TabIndex = 16;
            this.convert.Text = "Convert";
            this.convert.UseVisualStyleBackColor = false;
            this.convert.Click += new System.EventHandler(this.convert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Quantity";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Quantity to Convert";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Select M U";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(428, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Quantity";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(537, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Item M U";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // quantityandconversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(631, 278);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.convert);
            this.Controls.Add(this.itemmu);
            this.Controls.Add(this.unitSelect);
            this.Controls.Add(this.qtyac);
            this.Controls.Add(this.qtybc);
            this.Controls.Add(this.qtyAddbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "quantityandconversion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quickbill Invoice";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.quantityandconversion_FormClosing);
            this.Load += new System.EventHandler(this.quantityandconversion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button qtyAddbtn;
        private System.Windows.Forms.Button convert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox qtyac;
        internal System.Windows.Forms.TextBox itemmu;
        private System.Windows.Forms.TextBox qtybc;
        private System.Windows.Forms.ComboBox unitSelect;
    }
}