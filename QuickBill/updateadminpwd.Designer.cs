namespace QuickBill
{
    partial class updateadminpwd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updateadminpwd));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.adminoldpwd = new System.Windows.Forms.TextBox();
            this.newadminpwd1 = new System.Windows.Forms.TextBox();
            this.newadminpwd2 = new System.Windows.Forms.TextBox();
            this.updateadminpwdbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cancelpwdchange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Old Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(129, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "New Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(129, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirm Password";
            // 
            // adminoldpwd
            // 
            this.adminoldpwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adminoldpwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminoldpwd.Location = new System.Drawing.Point(265, 98);
            this.adminoldpwd.MaxLength = 40;
            this.adminoldpwd.Name = "adminoldpwd";
            this.adminoldpwd.PasswordChar = '*';
            this.adminoldpwd.Size = new System.Drawing.Size(147, 21);
            this.adminoldpwd.TabIndex = 3;
            // 
            // newadminpwd1
            // 
            this.newadminpwd1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newadminpwd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newadminpwd1.Location = new System.Drawing.Point(265, 144);
            this.newadminpwd1.MaxLength = 40;
            this.newadminpwd1.Name = "newadminpwd1";
            this.newadminpwd1.PasswordChar = '*';
            this.newadminpwd1.Size = new System.Drawing.Size(147, 21);
            this.newadminpwd1.TabIndex = 4;
            // 
            // newadminpwd2
            // 
            this.newadminpwd2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newadminpwd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newadminpwd2.Location = new System.Drawing.Point(265, 190);
            this.newadminpwd2.MaxLength = 40;
            this.newadminpwd2.Name = "newadminpwd2";
            this.newadminpwd2.PasswordChar = '*';
            this.newadminpwd2.Size = new System.Drawing.Size(147, 21);
            this.newadminpwd2.TabIndex = 5;
            this.newadminpwd2.TextChanged += new System.EventHandler(this.newadminpwd2_TextChanged);
            // 
            // updateadminpwdbtn
            // 
            this.updateadminpwdbtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.updateadminpwdbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateadminpwdbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.updateadminpwdbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateadminpwdbtn.Location = new System.Drawing.Point(459, 259);
            this.updateadminpwdbtn.Name = "updateadminpwdbtn";
            this.updateadminpwdbtn.Size = new System.Drawing.Size(75, 32);
            this.updateadminpwdbtn.TabIndex = 6;
            this.updateadminpwdbtn.Text = "Update";
            this.updateadminpwdbtn.UseVisualStyleBackColor = false;
            this.updateadminpwdbtn.Click += new System.EventHandler(this.updateadminpwdbtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(182, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Update Admin Password";
            // 
            // cancelpwdchange
            // 
            this.cancelpwdchange.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cancelpwdchange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelpwdchange.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelpwdchange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelpwdchange.Location = new System.Drawing.Point(12, 259);
            this.cancelpwdchange.Name = "cancelpwdchange";
            this.cancelpwdchange.Size = new System.Drawing.Size(75, 32);
            this.cancelpwdchange.TabIndex = 8;
            this.cancelpwdchange.Text = "Cancel";
            this.cancelpwdchange.UseVisualStyleBackColor = false;
            this.cancelpwdchange.Click += new System.EventHandler(this.cancelpwdchange_Click);
            // 
            // updateadminpwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.CancelButton = this.cancelpwdchange;
            this.ClientSize = new System.Drawing.Size(562, 314);
            this.Controls.Add(this.cancelpwdchange);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.updateadminpwdbtn);
            this.Controls.Add(this.newadminpwd2);
            this.Controls.Add(this.newadminpwd1);
            this.Controls.Add(this.adminoldpwd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "updateadminpwd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuickBill-Invoice";
            this.Load += new System.EventHandler(this.updateadminpwd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox adminoldpwd;
        private System.Windows.Forms.TextBox newadminpwd1;
        private System.Windows.Forms.TextBox newadminpwd2;
        private System.Windows.Forms.Button updateadminpwdbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cancelpwdchange;
    }
}