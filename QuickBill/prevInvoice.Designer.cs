namespace QuickBill
{
    partial class prevInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(prevInvoice));
            this.label3 = new System.Windows.Forms.Label();
            this.searchinvoicebtn = new System.Windows.Forms.Button();
            this.invoicenotb = new System.Windows.Forms.TextBox();
            this.prefixtb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Print Previous Invoice";
            // 
            // searchinvoicebtn
            // 
            this.searchinvoicebtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchinvoicebtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.searchinvoicebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchinvoicebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchinvoicebtn.Location = new System.Drawing.Point(171, 148);
            this.searchinvoicebtn.Name = "searchinvoicebtn";
            this.searchinvoicebtn.Size = new System.Drawing.Size(85, 31);
            this.searchinvoicebtn.TabIndex = 15;
            this.searchinvoicebtn.Text = "Search";
            this.searchinvoicebtn.UseVisualStyleBackColor = false;
            this.searchinvoicebtn.Click += new System.EventHandler(this.searchinvoicebtn_Click);
            // 
            // invoicenotb
            // 
            this.invoicenotb.AcceptsTab = true;
            this.invoicenotb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.invoicenotb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.invoicenotb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoicenotb.Location = new System.Drawing.Point(165, 104);
            this.invoicenotb.Name = "invoicenotb";
            this.invoicenotb.Size = new System.Drawing.Size(148, 22);
            this.invoicenotb.TabIndex = 14;
            this.invoicenotb.TextChanged += new System.EventHandler(this.invoicenotb_TextChanged);
            this.invoicenotb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.invoicenotb_KeyPress);
            // 
            // prefixtb
            // 
            this.prefixtb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prefixtb.Cursor = System.Windows.Forms.Cursors.No;
            this.prefixtb.Enabled = false;
            this.prefixtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prefixtb.Location = new System.Drawing.Point(114, 104);
            this.prefixtb.Name = "prefixtb";
            this.prefixtb.Size = new System.Drawing.Size(45, 22);
            this.prefixtb.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Search for Invoice";
            // 
            // prevInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(417, 227);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prefixtb);
            this.Controls.Add(this.searchinvoicebtn);
            this.Controls.Add(this.invoicenotb);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "prevInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuickBill-Invoice";
            this.Load += new System.EventHandler(this.prevInvoice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button searchinvoicebtn;
        private System.Windows.Forms.TextBox invoicenotb;
        private System.Windows.Forms.TextBox prefixtb;
        private System.Windows.Forms.Label label1;
    }
}