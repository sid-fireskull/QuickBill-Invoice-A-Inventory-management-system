namespace QuickBill
{
    partial class CreateUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateUser));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.newuser = new System.Windows.Forms.TextBox();
            this.newuserpwd1 = new System.Windows.Forms.TextBox();
            this.newusrpwd2 = new System.Windows.Forms.TextBox();
            this.Createuserbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Create Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirm Password";
            // 
            // newuser
            // 
            this.newuser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newuser.Location = new System.Drawing.Point(222, 113);
            this.newuser.MaxLength = 15;
            this.newuser.Name = "newuser";
            this.newuser.Size = new System.Drawing.Size(161, 21);
            this.newuser.TabIndex = 3;
            this.newuser.TextChanged += new System.EventHandler(this.newuser_TextChanged);
            this.newuser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.newuser_KeyPress);
            // 
            // newuserpwd1
            // 
            this.newuserpwd1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newuserpwd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newuserpwd1.Location = new System.Drawing.Point(222, 163);
            this.newuserpwd1.MaxLength = 15;
            this.newuserpwd1.Name = "newuserpwd1";
            this.newuserpwd1.PasswordChar = '*';
            this.newuserpwd1.Size = new System.Drawing.Size(161, 21);
            this.newuserpwd1.TabIndex = 4;
            // 
            // newusrpwd2
            // 
            this.newusrpwd2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newusrpwd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newusrpwd2.Location = new System.Drawing.Point(222, 212);
            this.newusrpwd2.MaxLength = 15;
            this.newusrpwd2.Name = "newusrpwd2";
            this.newusrpwd2.PasswordChar = '*';
            this.newusrpwd2.Size = new System.Drawing.Size(161, 21);
            this.newusrpwd2.TabIndex = 5;
            this.newusrpwd2.TextChanged += new System.EventHandler(this.newusrpwdconfirm_TextChanged);
            // 
            // Createuserbtn
            // 
            this.Createuserbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Createuserbtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Createuserbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Createuserbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Createuserbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Createuserbtn.Location = new System.Drawing.Point(416, 305);
            this.Createuserbtn.Name = "Createuserbtn";
            this.Createuserbtn.Size = new System.Drawing.Size(75, 28);
            this.Createuserbtn.TabIndex = 6;
            this.Createuserbtn.Text = "Create";
            this.Createuserbtn.UseVisualStyleBackColor = false;
            this.Createuserbtn.Click += new System.EventHandler(this.Createuserbtn_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(183, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Create User For Billing";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(38, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(533, 365);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Createuserbtn);
            this.Controls.Add(this.newusrpwd2);
            this.Controls.Add(this.newuserpwd1);
            this.Controls.Add(this.newuser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuickBill-Invoice";
            this.Load += new System.EventHandler(this.CreateUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newuser;
        private System.Windows.Forms.TextBox newuserpwd1;
        private System.Windows.Forms.TextBox newusrpwd2;
        private System.Windows.Forms.Button Createuserbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}