namespace RunMeAs
{
    partial class RunAs
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.btnSeatch = new System.Windows.Forms.Button();
            this.cbRunAsAdmin = new System.Windows.Forms.CheckBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.PUser = new System.Windows.Forms.Panel();
            this.PUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbFilePath
            // 
            this.tbFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFilePath.Location = new System.Drawing.Point(13, 11);
            this.tbFilePath.Margin = new System.Windows.Forms.Padding(4);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(524, 26);
            this.tbFilePath.TabIndex = 0;
            // 
            // btnSeatch
            // 
            this.btnSeatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeatch.Location = new System.Drawing.Point(545, 10);
            this.btnSeatch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSeatch.Name = "btnSeatch";
            this.btnSeatch.Size = new System.Drawing.Size(32, 27);
            this.btnSeatch.TabIndex = 1;
            this.btnSeatch.Text = "...";
            this.btnSeatch.UseVisualStyleBackColor = true;
            this.btnSeatch.Click += new System.EventHandler(this.btnSeatch_Click);
            // 
            // cbRunAsAdmin
            // 
            this.cbRunAsAdmin.AutoSize = true;
            this.cbRunAsAdmin.Location = new System.Drawing.Point(13, 49);
            this.cbRunAsAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.cbRunAsAdmin.Name = "cbRunAsAdmin";
            this.cbRunAsAdmin.Size = new System.Drawing.Size(161, 22);
            this.cbRunAsAdmin.TabIndex = 2;
            this.cbRunAsAdmin.Text = "Run as administrator";
            this.cbRunAsAdmin.UseVisualStyleBackColor = true;
            this.cbRunAsAdmin.CheckedChanged += new System.EventHandler(this.cbRunAsAdmin_CheckedChanged);
            // 
            // tbUserName
            // 
            this.tbUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUserName.Location = new System.Drawing.Point(93, 2);
            this.tbUserName.Margin = new System.Windows.Forms.Padding(4);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(164, 26);
            this.tbUserName.TabIndex = 3;
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPassword.Location = new System.Drawing.Point(93, 33);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(164, 26);
            this.tbPassword.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "User:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password:";
            // 
            // btnRun
            // 
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRun.Location = new System.Drawing.Point(490, 121);
            this.btnRun.Margin = new System.Windows.Forms.Padding(4);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(86, 27);
            this.btnRun.TabIndex = 7;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(396, 121);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 27);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // PUser
            // 
            this.PUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PUser.Controls.Add(this.label2);
            this.PUser.Controls.Add(this.tbUserName);
            this.PUser.Controls.Add(this.tbPassword);
            this.PUser.Controls.Add(this.label1);
            this.PUser.Location = new System.Drawing.Point(319, 45);
            this.PUser.Name = "PUser";
            this.PUser.Size = new System.Drawing.Size(257, 69);
            this.PUser.TabIndex = 9;
            // 
            // RunAs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 163);
            this.Controls.Add(this.PUser);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.cbRunAsAdmin);
            this.Controls.Add(this.btnSeatch);
            this.Controls.Add(this.tbFilePath);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RunAs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Run As";
            this.PUser.ResumeLayout(false);
            this.PUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbFilePath;
        private Button btnSeatch;
        private CheckBox cbRunAsAdmin;
        private TextBox tbUserName;
        private TextBox tbPassword;
        private Label label1;
        private Label label2;
        private Button btnRun;
        private Button btnClose;
        private Panel PUser;
    }
}