namespace QuickBill
{
    partial class rmvCatagory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rmvCatagory));
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rmvcid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.catsgstrmv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.catnamermv = new System.Windows.Forms.TextBox();
            this.catmurmv = new System.Windows.Forms.TextBox();
            this.cancel = new System.Windows.Forms.Button();
            this.catAddbtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.catcgstrmv = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Remove Catagory Details";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(105, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Catagory ID";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // rmvcid
            // 
            this.rmvcid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rmvcid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rmvcid.Cursor = System.Windows.Forms.Cursors.No;
            this.rmvcid.Enabled = false;
            this.rmvcid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rmvcid.Location = new System.Drawing.Point(251, 91);
            this.rmvcid.Name = "rmvcid";
            this.rmvcid.Size = new System.Drawing.Size(246, 22);
            this.rmvcid.TabIndex = 12;
            this.rmvcid.TextChanged += new System.EventHandler(this.rmvcid_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(105, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Measuring Unit";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "SGST (%)";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // catsgstrmv
            // 
            this.catsgstrmv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.catsgstrmv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.catsgstrmv.Cursor = System.Windows.Forms.Cursors.No;
            this.catsgstrmv.Enabled = false;
            this.catsgstrmv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catsgstrmv.Location = new System.Drawing.Point(251, 252);
            this.catsgstrmv.Name = "catsgstrmv";
            this.catsgstrmv.Size = new System.Drawing.Size(246, 22);
            this.catsgstrmv.TabIndex = 16;
            this.catsgstrmv.TextChanged += new System.EventHandler(this.cattaxrmv_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Catagory Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // catnamermv
            // 
            this.catnamermv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.catnamermv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.catnamermv.Cursor = System.Windows.Forms.Cursors.No;
            this.catnamermv.Enabled = false;
            this.catnamermv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catnamermv.Location = new System.Drawing.Point(251, 143);
            this.catnamermv.Name = "catnamermv";
            this.catnamermv.Size = new System.Drawing.Size(246, 22);
            this.catnamermv.TabIndex = 14;
            this.catnamermv.TextChanged += new System.EventHandler(this.catnamermv_TextChanged);
            // 
            // catmurmv
            // 
            this.catmurmv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.catmurmv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.catmurmv.Cursor = System.Windows.Forms.Cursors.No;
            this.catmurmv.Enabled = false;
            this.catmurmv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catmurmv.Location = new System.Drawing.Point(251, 198);
            this.catmurmv.Name = "catmurmv";
            this.catmurmv.Size = new System.Drawing.Size(246, 22);
            this.catmurmv.TabIndex = 20;
            this.catmurmv.TextChanged += new System.EventHandler(this.catmurmv_TextChanged);
            // 
            // cancel
            // 
            this.cancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(29, 387);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(154, 32);
            this.cancel.TabIndex = 22;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = false;
            // 
            // catAddbtn
            // 
            this.catAddbtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.catAddbtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.catAddbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.catAddbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catAddbtn.Location = new System.Drawing.Point(476, 387);
            this.catAddbtn.Name = "catAddbtn";
            this.catAddbtn.Size = new System.Drawing.Size(144, 32);
            this.catAddbtn.TabIndex = 21;
            this.catAddbtn.Text = "Delete";
            this.catAddbtn.UseVisualStyleBackColor = false;
            this.catAddbtn.Click += new System.EventHandler(this.catAddbtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(45, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(564, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "*   Caution:  Removing Catagory from the Catagory List will also remove all the a" +
    "ssociated Sub-Catagory";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(105, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "CGST  (%)";
            // 
            // catcgstrmv
            // 
            this.catcgstrmv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.catcgstrmv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.catcgstrmv.Cursor = System.Windows.Forms.Cursors.No;
            this.catcgstrmv.Enabled = false;
            this.catcgstrmv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catcgstrmv.Location = new System.Drawing.Point(251, 306);
            this.catcgstrmv.Name = "catcgstrmv";
            this.catcgstrmv.Size = new System.Drawing.Size(246, 22);
            this.catcgstrmv.TabIndex = 24;
            // 
            // rmvCatagory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.CancelButton = this.cancel;
            this.ClientSize = new System.Drawing.Size(650, 453);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.catcgstrmv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.catAddbtn);
            this.Controls.Add(this.catmurmv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.catsgstrmv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.catnamermv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rmvcid);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "rmvCatagory";
            this.Text = "QuickBill-Invoice";
            this.Load += new System.EventHandler(this.rmvCatagory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox rmvcid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox catsgstrmv;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox catnamermv;
        internal System.Windows.Forms.TextBox catmurmv;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button catAddbtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        internal System.Windows.Forms.TextBox catcgstrmv;
    }
}