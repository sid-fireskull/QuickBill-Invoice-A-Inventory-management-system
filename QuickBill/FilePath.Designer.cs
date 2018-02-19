namespace QuickBill
{
    partial class FilePath
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilePath));
            this.label1 = new System.Windows.Forms.Label();
            this.browsedbpath = new System.Windows.Forms.TextBox();
            this.browsedbbtn = new System.Windows.Forms.Button();
            this.savedestinationbtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.backFilePath = new System.Windows.Forms.Button();
            this.browsebackupdbbtn = new System.Windows.Forms.Button();
            this.browsebackupdbpath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Set the Destination Database Location";
            // 
            // browsedbpath
            // 
            this.browsedbpath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.browsedbpath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browsedbpath.Location = new System.Drawing.Point(26, 92);
            this.browsedbpath.Name = "browsedbpath";
            this.browsedbpath.Size = new System.Drawing.Size(431, 24);
            this.browsedbpath.TabIndex = 1;
            this.browsedbpath.TextChanged += new System.EventHandler(this.browsedbpath_TextChanged);
            // 
            // browsedbbtn
            // 
            this.browsedbbtn.BackColor = System.Drawing.Color.Gainsboro;
            this.browsedbbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.browsedbbtn.Image = ((System.Drawing.Image)(resources.GetObject("browsedbbtn.Image")));
            this.browsedbbtn.Location = new System.Drawing.Point(483, 90);
            this.browsedbbtn.Name = "browsedbbtn";
            this.browsedbbtn.Size = new System.Drawing.Size(51, 26);
            this.browsedbbtn.TabIndex = 2;
            this.browsedbbtn.UseVisualStyleBackColor = false;
            this.browsedbbtn.Click += new System.EventHandler(this.browsedbbtn_Click);
            // 
            // savedestinationbtn
            // 
            this.savedestinationbtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.savedestinationbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.savedestinationbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savedestinationbtn.Location = new System.Drawing.Point(584, 271);
            this.savedestinationbtn.Name = "savedestinationbtn";
            this.savedestinationbtn.Size = new System.Drawing.Size(75, 33);
            this.savedestinationbtn.TabIndex = 3;
            this.savedestinationbtn.Text = "Save";
            this.savedestinationbtn.UseVisualStyleBackColor = false;
            this.savedestinationbtn.Click += new System.EventHandler(this.savedestinationbtn_Click);
            // 
            // backFilePath
            // 
            this.backFilePath.BackColor = System.Drawing.Color.LightSteelBlue;
            this.backFilePath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backFilePath.Location = new System.Drawing.Point(26, 271);
            this.backFilePath.Name = "backFilePath";
            this.backFilePath.Size = new System.Drawing.Size(75, 32);
            this.backFilePath.TabIndex = 6;
            this.backFilePath.Text = "Back";
            this.backFilePath.UseVisualStyleBackColor = false;
            this.backFilePath.Click += new System.EventHandler(this.backFilePath_Click);
            // 
            // browsebackupdbbtn
            // 
            this.browsebackupdbbtn.BackColor = System.Drawing.Color.Gainsboro;
            this.browsebackupdbbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.browsebackupdbbtn.Image = ((System.Drawing.Image)(resources.GetObject("browsebackupdbbtn.Image")));
            this.browsebackupdbbtn.Location = new System.Drawing.Point(483, 194);
            this.browsebackupdbbtn.Name = "browsebackupdbbtn";
            this.browsebackupdbbtn.Size = new System.Drawing.Size(51, 26);
            this.browsebackupdbbtn.TabIndex = 8;
            this.browsebackupdbbtn.UseVisualStyleBackColor = false;
            this.browsebackupdbbtn.Click += new System.EventHandler(this.browsebackupdbbtn_Click);
            // 
            // browsebackupdbpath
            // 
            this.browsebackupdbpath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.browsebackupdbpath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browsebackupdbpath.Location = new System.Drawing.Point(26, 196);
            this.browsebackupdbpath.Name = "browsebackupdbpath";
            this.browsebackupdbpath.Size = new System.Drawing.Size(431, 24);
            this.browsebackupdbpath.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Set the  Backup Database Location";
            // 
            // FilePath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(687, 333);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.browsebackupdbbtn);
            this.Controls.Add(this.browsebackupdbpath);
            this.Controls.Add(this.backFilePath);
            this.Controls.Add(this.savedestinationbtn);
            this.Controls.Add(this.browsedbbtn);
            this.Controls.Add(this.browsedbpath);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FilePath";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Path Setup";
            this.Load += new System.EventHandler(this.FilePath_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox browsedbpath;
        private System.Windows.Forms.Button browsedbbtn;
        private System.Windows.Forms.Button savedestinationbtn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button backFilePath;
        private System.Windows.Forms.Button browsebackupdbbtn;
        private System.Windows.Forms.TextBox browsebackupdbpath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}