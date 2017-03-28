namespace frmLAX_Vacation
{
    partial class frmLAX_VacationPlanner
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
            this.grpWelcomeHome = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnNewUser = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblWelcomeMessage = new System.Windows.Forms.Label();
            this.grpWelcomeHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpWelcomeHome
            // 
            this.grpWelcomeHome.BackColor = System.Drawing.Color.Transparent;
            this.grpWelcomeHome.Controls.Add(this.btnExit);
            this.grpWelcomeHome.Controls.Add(this.btnNewUser);
            this.grpWelcomeHome.Controls.Add(this.btnLogin);
            this.grpWelcomeHome.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpWelcomeHome.ForeColor = System.Drawing.Color.Fuchsia;
            this.grpWelcomeHome.Location = new System.Drawing.Point(14, 68);
            this.grpWelcomeHome.Margin = new System.Windows.Forms.Padding(5);
            this.grpWelcomeHome.Name = "grpWelcomeHome";
            this.grpWelcomeHome.Padding = new System.Windows.Forms.Padding(5);
            this.grpWelcomeHome.Size = new System.Drawing.Size(566, 98);
            this.grpWelcomeHome.TabIndex = 0;
            this.grpWelcomeHome.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Teal;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnExit.Location = new System.Drawing.Point(413, 24);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 50);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnNewUser
            // 
            this.btnNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewUser.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewUser.ForeColor = System.Drawing.Color.Teal;
            this.btnNewUser.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNewUser.Location = new System.Drawing.Point(230, 24);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(100, 50);
            this.btnNewUser.TabIndex = 1;
            this.btnNewUser.Text = "&New User";
            this.btnNewUser.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Teal;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(54, 24);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 50);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "&Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblWelcomeMessage
            // 
            this.lblWelcomeMessage.AutoSize = true;
            this.lblWelcomeMessage.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeMessage.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblWelcomeMessage.Location = new System.Drawing.Point(82, 9);
            this.lblWelcomeMessage.Name = "lblWelcomeMessage";
            this.lblWelcomeMessage.Size = new System.Drawing.Size(431, 54);
            this.lblWelcomeMessage.TabIndex = 3;
            this.lblWelcomeMessage.Text = "Welcome to your vacation planning system.\r\nPlease make a selection.";
            this.lblWelcomeMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmLAX_VacationPlanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::frmLAX_Vacation.Properties.Resources.nasa_earth_day_gallery_6;
            this.ClientSize = new System.Drawing.Size(594, 440);
            this.Controls.Add(this.lblWelcomeMessage);
            this.Controls.Add(this.grpWelcomeHome);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLAX_VacationPlanner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LAX Vacation Planner";
            this.Load += new System.EventHandler(this.frmLAX_VacationPlanner_Load);
            this.grpWelcomeHome.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpWelcomeHome;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnNewUser;
        private System.Windows.Forms.Label lblWelcomeMessage;
    }
}

