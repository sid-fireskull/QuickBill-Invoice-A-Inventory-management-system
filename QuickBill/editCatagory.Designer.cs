namespace QuickBill
{
    partial class editCatagory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editCatagory));
            this.label1 = new System.Windows.Forms.Label();
            this.catnameupdate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.updatesgst = new System.Windows.Forms.TextBox();
            this.updatemu = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.catAddbtn = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.updatecgst = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Catagory Details";
            // 
            // catnameupdate
            // 
            this.catnameupdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.catnameupdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.catnameupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catnameupdate.Location = new System.Drawing.Point(249, 152);
            this.catnameupdate.Name = "catnameupdate";
            this.catnameupdate.Size = new System.Drawing.Size(205, 22);
            this.catnameupdate.TabIndex = 1;
            this.catnameupdate.TextChanged += new System.EventHandler(this.catnameupdate_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Catagory Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "SGST (%)";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // updatesgst
            // 
            this.updatesgst.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.updatesgst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.updatesgst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatesgst.Location = new System.Drawing.Point(249, 280);
            this.updatesgst.Name = "updatesgst";
            this.updatesgst.Size = new System.Drawing.Size(205, 22);
            this.updatesgst.TabIndex = 3;
            this.updatesgst.TextChanged += new System.EventHandler(this.updatetax_TextChanged);
            // 
            // updatemu
            // 
            this.updatemu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.updatemu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatemu.FormattingEnabled = true;
            this.updatemu.Items.AddRange(new object[] {
            "pcs",
            "litre",
            "gram",
            "kilogram"});
            this.updatemu.Location = new System.Drawing.Point(249, 219);
            this.updatemu.Name = "updatemu";
            this.updatemu.Size = new System.Drawing.Size(205, 24);
            this.updatemu.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(85, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Measuring Unit";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // catAddbtn
            // 
            this.catAddbtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.catAddbtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.catAddbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.catAddbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catAddbtn.Location = new System.Drawing.Point(481, 391);
            this.catAddbtn.Name = "catAddbtn";
            this.catAddbtn.Size = new System.Drawing.Size(113, 32);
            this.catAddbtn.TabIndex = 7;
            this.catAddbtn.Text = "Update";
            this.catAddbtn.UseVisualStyleBackColor = false;
            this.catAddbtn.Click += new System.EventHandler(this.catAddbtn_Click);
            // 
            // cancel
            // 
            this.cancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(26, 391);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(113, 32);
            this.cancel.TabIndex = 8;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(85, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Catagory ID";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cid
            // 
            this.cid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cid.Enabled = false;
            this.cid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cid.Location = new System.Drawing.Point(249, 94);
            this.cid.Name = "cid";
            this.cid.Size = new System.Drawing.Size(205, 22);
            this.cid.TabIndex = 9;
            this.cid.TextChanged += new System.EventHandler(this.cid_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(85, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "CGST (%)";
            // 
            // updatecgst
            // 
            this.updatecgst.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.updatecgst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.updatecgst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatecgst.Location = new System.Drawing.Point(249, 338);
            this.updatecgst.Name = "updatecgst";
            this.updatecgst.Size = new System.Drawing.Size(205, 22);
            this.updatecgst.TabIndex = 11;
            this.updatecgst.TextChanged += new System.EventHandler(this.updatecgst_TextChanged);
            // 
            // editCatagory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.CancelButton = this.cancel;
            this.ClientSize = new System.Drawing.Size(638, 458);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.updatecgst);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cid);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.catAddbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.updatemu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.updatesgst);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.catnameupdate);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "editCatagory";
            this.Text = "QuickBill-Invoice";
            this.Load += new System.EventHandler(this.editCatagory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox catnameupdate;
        internal System.Windows.Forms.TextBox updatesgst;
        internal System.Windows.Forms.ComboBox updatemu;
        private System.Windows.Forms.Button catAddbtn;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox cid;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox updatecgst;
    }
}