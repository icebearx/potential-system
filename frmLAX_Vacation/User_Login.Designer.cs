namespace frmLAX_Vacation
{
    partial class User_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Login));
            this.lblUserName = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.mnuHeading = new System.Windows.Forms.MenuStrip();
            this.mnuEmployeeLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.grpUserLogin = new System.Windows.Forms.GroupBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.mnuHeading.SuspendLayout();
            this.grpUserLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblUserName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.Teal;
            this.lblUserName.Location = new System.Drawing.Point(40, 30);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(88, 21);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "Username:";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(385, 11);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 197);
            this.vScrollBar1.TabIndex = 4;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Teal;
            this.lblPassword.Location = new System.Drawing.Point(40, 98);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(88, 21);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Black;
            this.txtPassword.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtPassword.Location = new System.Drawing.Point(40, 123);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(309, 29);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // mnuHeading
            // 
            this.mnuHeading.BackColor = System.Drawing.Color.Black;
            this.mnuHeading.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEmployeeLogin});
            this.mnuHeading.Location = new System.Drawing.Point(0, 0);
            this.mnuHeading.Name = "mnuHeading";
            this.mnuHeading.Size = new System.Drawing.Size(426, 34);
            this.mnuHeading.TabIndex = 7;
            this.mnuHeading.Text = "menuStrip1";
            // 
            // mnuEmployeeLogin
            // 
            this.mnuEmployeeLogin.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuEmployeeLogin.ForeColor = System.Drawing.Color.RoyalBlue;
            this.mnuEmployeeLogin.Name = "mnuEmployeeLogin";
            this.mnuEmployeeLogin.Size = new System.Drawing.Size(191, 30);
            this.mnuEmployeeLogin.Text = "Employee Login";
            // 
            // grpUserLogin
            // 
            this.grpUserLogin.AutoSize = true;
            this.grpUserLogin.BackColor = System.Drawing.Color.Transparent;
            this.grpUserLogin.Controls.Add(this.btnQuit);
            this.grpUserLogin.Controls.Add(this.btnLogin);
            this.grpUserLogin.Controls.Add(this.vScrollBar1);
            this.grpUserLogin.Controls.Add(this.txtPassword);
            this.grpUserLogin.Controls.Add(this.lblPassword);
            this.grpUserLogin.Controls.Add(this.lblUserName);
            this.grpUserLogin.Controls.Add(this.txtUserName);
            this.grpUserLogin.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpUserLogin.ForeColor = System.Drawing.Color.RoyalBlue;
            this.grpUserLogin.Location = new System.Drawing.Point(12, 56);
            this.grpUserLogin.Name = "grpUserLogin";
            this.grpUserLogin.Size = new System.Drawing.Size(405, 296);
            this.grpUserLogin.TabIndex = 8;
            this.grpUserLogin.TabStop = false;
            this.grpUserLogin.Text = "Log in";
            // 
            // btnQuit
            // 
            this.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnQuit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQuit.Location = new System.Drawing.Point(254, 158);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(95, 29);
            this.btnQuit.TabIndex = 8;
            this.btnQuit.Text = "&Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLogin.Location = new System.Drawing.Point(153, 158);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(95, 29);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "&Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.Black;
            this.txtUserName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtUserName.Location = new System.Drawing.Point(40, 55);
            this.txtUserName.MaxLength = 8;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(309, 29);
            this.txtUserName.TabIndex = 3;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // User_Login
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::frmLAX_Vacation.Properties.Resources.nasa_earth_day_gallery_6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CancelButton = this.btnQuit;
            this.ClientSize = new System.Drawing.Size(426, 364);
            this.Controls.Add(this.mnuHeading);
            this.Controls.Add(this.grpUserLogin);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.mnuHeading;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "User_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter Your Credentials";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.User_Login_Load);
            this.mnuHeading.ResumeLayout(false);
            this.mnuHeading.PerformLayout();
            this.grpUserLogin.ResumeLayout(false);
            this.grpUserLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.MenuStrip mnuHeading;
        private System.Windows.Forms.ToolStripMenuItem mnuEmployeeLogin;
        private System.Windows.Forms.GroupBox grpUserLogin;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtUserName;
    }
}