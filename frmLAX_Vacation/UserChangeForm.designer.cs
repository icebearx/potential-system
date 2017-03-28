using System;

namespace frmLAX_Vacation
{
    partial class UserChangeForm
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
            this.lblWelcomeMessage = new System.Windows.Forms.Label();
            this.tmrCurrent = new System.Windows.Forms.Timer(this.components);
            this.cldUserSelection = new System.Windows.Forms.MonthCalendar();
            this.btnQuit = new System.Windows.Forms.Button();
            this.grpMainControls = new System.Windows.Forms.GroupBox();
            this.btnSubmitChange = new System.Windows.Forms.Button();
            this.flwUserChangeVacation = new System.Windows.Forms.FlowLayoutPanel();
            this.lblWantTo = new System.Windows.Forms.Label();
            this.cbxFromUnit = new System.Windows.Forms.ComboBox();
            this.lblFor = new System.Windows.Forms.Label();
            this.cbxToUnit = new System.Windows.Forms.ComboBox();
            this.grpLeftSide = new System.Windows.Forms.GroupBox();
            this.btnChangeRestDays = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUserRestDays = new System.Windows.Forms.Label();
            this.lstCurrentUserInfo = new System.Windows.Forms.ListBox();
            this.loginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersDataSet = new frmLAX_Vacation.usersDataSet();
            this.lblHU = new System.Windows.Forms.Label();
            this.lblHA = new System.Windows.Forms.Label();
            this.lblRequiredInfo = new System.Windows.Forms.Label();
            this.lblHoursUsed = new System.Windows.Forms.Label();
            this.lblHoursAvailable = new System.Windows.Forms.Label();
            this.lblSelectedWeekOfYear = new System.Windows.Forms.Label();
            this.btnChangeUnit = new System.Windows.Forms.Button();
            this.lblCurrentTimer = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.loginTableAdapter = new frmLAX_Vacation.usersDataSetTableAdapters.LoginTableAdapter();
            this.usersDataSet1 = new frmLAX_Vacation.usersDataSet();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpMainControls.SuspendLayout();
            this.flwUserChangeVacation.SuspendLayout();
            this.grpLeftSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcomeMessage
            // 
            this.lblWelcomeMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcomeMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblWelcomeMessage.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeMessage.ForeColor = System.Drawing.Color.Black;
            this.lblWelcomeMessage.Location = new System.Drawing.Point(0, 0);
            this.lblWelcomeMessage.Name = "lblWelcomeMessage";
            this.lblWelcomeMessage.Size = new System.Drawing.Size(818, 54);
            this.lblWelcomeMessage.TabIndex = 10;
            this.lblWelcomeMessage.Text = "Welcome FirstName LastnName. \r\nPlease make a selection.\r\n";
            this.lblWelcomeMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrCurrent
            // 
            this.tmrCurrent.Enabled = true;
            this.tmrCurrent.Tick += new System.EventHandler(this.tmrCurrent_Tick);
            // 
            // cldUserSelection
            // 
            this.cldUserSelection.AnnuallyBoldedDates = new System.DateTime[] {
        new System.DateTime(2017, 12, 25, 0, 0, 0, 0),
        new System.DateTime(2017, 1, 1, 0, 0, 0, 0)};
            this.cldUserSelection.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.cldUserSelection.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cldUserSelection.ForeColor = System.Drawing.Color.Turquoise;
            this.cldUserSelection.Location = new System.Drawing.Point(446, 18);
            this.cldUserSelection.MaxDate = new System.DateTime(2017, 12, 31, 0, 0, 0, 0);
            this.cldUserSelection.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.cldUserSelection.Name = "cldUserSelection";
            this.cldUserSelection.ShowWeekNumbers = true;
            this.cldUserSelection.TabIndex = 7;
            this.cldUserSelection.TitleBackColor = System.Drawing.Color.Teal;
            this.cldUserSelection.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.cldUserSelection_DateChanged);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Transparent;
            this.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuit.ForeColor = System.Drawing.Color.Gold;
            this.btnQuit.Location = new System.Drawing.Point(633, 265);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(125, 34);
            this.btnQuit.TabIndex = 9;
            this.btnQuit.Text = "&Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // grpMainControls
            // 
            this.grpMainControls.BackColor = System.Drawing.Color.Transparent;
            this.grpMainControls.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grpMainControls.Controls.Add(this.btnSubmitChange);
            this.grpMainControls.Controls.Add(this.flwUserChangeVacation);
            this.grpMainControls.Controls.Add(this.grpLeftSide);
            this.grpMainControls.Controls.Add(this.lblSelectedWeekOfYear);
            this.grpMainControls.Controls.Add(this.btnChangeUnit);
            this.grpMainControls.Controls.Add(this.btnQuit);
            this.grpMainControls.Controls.Add(this.cldUserSelection);
            this.grpMainControls.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpMainControls.Location = new System.Drawing.Point(25, 89);
            this.grpMainControls.Name = "grpMainControls";
            this.grpMainControls.Size = new System.Drawing.Size(781, 363);
            this.grpMainControls.TabIndex = 11;
            this.grpMainControls.TabStop = false;
            this.grpMainControls.Enter += new System.EventHandler(this.grpMainControls_Enter);
            // 
            // btnSubmitChange
            // 
            this.btnSubmitChange.BackColor = System.Drawing.Color.Transparent;
            this.btnSubmitChange.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmitChange.ForeColor = System.Drawing.Color.Gold;
            this.btnSubmitChange.Location = new System.Drawing.Point(484, 265);
            this.btnSubmitChange.Name = "btnSubmitChange";
            this.btnSubmitChange.Size = new System.Drawing.Size(125, 34);
            this.btnSubmitChange.TabIndex = 25;
            this.btnSubmitChange.Text = "Submit";
            this.btnSubmitChange.UseVisualStyleBackColor = false;
            this.btnSubmitChange.Visible = false;
            this.btnSubmitChange.Click += new System.EventHandler(this.btnSubmitChange_Click);
            // 
            // flwUserChangeVacation
            // 
            this.flwUserChangeVacation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flwUserChangeVacation.Controls.Add(this.lblWantTo);
            this.flwUserChangeVacation.Controls.Add(this.cbxFromUnit);
            this.flwUserChangeVacation.Controls.Add(this.lblFor);
            this.flwUserChangeVacation.Controls.Add(this.cbxToUnit);
            this.flwUserChangeVacation.Location = new System.Drawing.Point(382, 220);
            this.flwUserChangeVacation.Name = "flwUserChangeVacation";
            this.flwUserChangeVacation.Size = new System.Drawing.Size(376, 44);
            this.flwUserChangeVacation.TabIndex = 24;
            this.flwUserChangeVacation.Visible = false;
            this.flwUserChangeVacation.WrapContents = false;
            // 
            // lblWantTo
            // 
            this.lblWantTo.AutoSize = true;
            this.lblWantTo.ForeColor = System.Drawing.Color.Gold;
            this.lblWantTo.Location = new System.Drawing.Point(3, 0);
            this.lblWantTo.Name = "lblWantTo";
            this.lblWantTo.Size = new System.Drawing.Size(180, 21);
            this.lblWantTo.TabIndex = 21;
            this.lblWantTo.Text = "I want to change unit #";
            // 
            // cbxFromUnit
            // 
            this.cbxFromUnit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFromUnit.FormattingEnabled = true;
            this.cbxFromUnit.Location = new System.Drawing.Point(189, 3);
            this.cbxFromUnit.Name = "cbxFromUnit";
            this.cbxFromUnit.Size = new System.Drawing.Size(38, 27);
            this.cbxFromUnit.TabIndex = 25;
            this.cbxFromUnit.SelectedIndexChanged += new System.EventHandler(this.cbxFromUnit_SelectedIndexChanged);
            // 
            // lblFor
            // 
            this.lblFor.AutoSize = true;
            this.lblFor.ForeColor = System.Drawing.Color.Gold;
            this.lblFor.Location = new System.Drawing.Point(233, 0);
            this.lblFor.Name = "lblFor";
            this.lblFor.Size = new System.Drawing.Size(79, 21);
            this.lblFor.TabIndex = 22;
            this.lblFor.Text = "for unit #";
            // 
            // cbxToUnit
            // 
            this.cbxToUnit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxToUnit.FormattingEnabled = true;
            this.cbxToUnit.Location = new System.Drawing.Point(318, 3);
            this.cbxToUnit.Name = "cbxToUnit";
            this.cbxToUnit.Size = new System.Drawing.Size(38, 27);
            this.cbxToUnit.TabIndex = 26;
            this.cbxToUnit.SelectedIndexChanged += new System.EventHandler(this.cbxToUnit_SelectedIndexChanged);
            // 
            // grpLeftSide
            // 
            this.grpLeftSide.Controls.Add(this.btnChangeRestDays);
            this.grpLeftSide.Controls.Add(this.label1);
            this.grpLeftSide.Controls.Add(this.lblUserRestDays);
            this.grpLeftSide.Controls.Add(this.lstCurrentUserInfo);
            this.grpLeftSide.Controls.Add(this.lblHU);
            this.grpLeftSide.Controls.Add(this.lblHA);
            this.grpLeftSide.Controls.Add(this.lblRequiredInfo);
            this.grpLeftSide.Controls.Add(this.lblHoursUsed);
            this.grpLeftSide.Controls.Add(this.lblHoursAvailable);
            this.grpLeftSide.ForeColor = System.Drawing.Color.Gold;
            this.grpLeftSide.Location = new System.Drawing.Point(6, 18);
            this.grpLeftSide.Name = "grpLeftSide";
            this.grpLeftSide.Size = new System.Drawing.Size(267, 339);
            this.grpLeftSide.TabIndex = 20;
            this.grpLeftSide.TabStop = false;
            this.grpLeftSide.Text = "Information";
            // 
            // btnChangeRestDays
            // 
            this.btnChangeRestDays.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangeRestDays.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeRestDays.ForeColor = System.Drawing.Color.Gold;
            this.btnChangeRestDays.Location = new System.Drawing.Point(59, 165);
            this.btnChangeRestDays.Name = "btnChangeRestDays";
            this.btnChangeRestDays.Size = new System.Drawing.Size(141, 33);
            this.btnChangeRestDays.TabIndex = 20;
            this.btnChangeRestDays.Text = "Change Rest Days";
            this.btnChangeRestDays.UseVisualStyleBackColor = true;
            this.btnChangeRestDays.Click += new System.EventHandler(this.btnChangeRestDays_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Rest Days:";
            // 
            // lblUserRestDays
            // 
            this.lblUserRestDays.AutoSize = true;
            this.lblUserRestDays.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserRestDays.ForeColor = System.Drawing.Color.Gold;
            this.lblUserRestDays.Location = new System.Drawing.Point(105, 143);
            this.lblUserRestDays.Name = "lblUserRestDays";
            this.lblUserRestDays.Size = new System.Drawing.Size(120, 19);
            this.lblUserRestDays.TabIndex = 18;
            this.lblUserRestDays.Text = "Saturday / Sunday";
            // 
            // lstCurrentUserInfo
            // 
            this.lstCurrentUserInfo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.loginBindingSource, "ASSIGNED_UNIT2", true));
            this.lstCurrentUserInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstCurrentUserInfo.FormattingEnabled = true;
            this.lstCurrentUserInfo.ItemHeight = 21;
            this.lstCurrentUserInfo.Location = new System.Drawing.Point(3, 206);
            this.lstCurrentUserInfo.Name = "lstCurrentUserInfo";
            this.lstCurrentUserInfo.Size = new System.Drawing.Size(261, 130);
            this.lstCurrentUserInfo.TabIndex = 17;
            this.lstCurrentUserInfo.SelectedIndexChanged += new System.EventHandler(this.lstCurrentUserInfo_SelectedIndexChanged);
            // 
            // loginBindingSource
            // 
            this.loginBindingSource.DataMember = "Login";
            this.loginBindingSource.DataSource = this.usersDataSet;
            // 
            // usersDataSet
            // 
            this.usersDataSet.DataSetName = "usersDataSet";
            this.usersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblHU
            // 
            this.lblHU.AutoSize = true;
            this.lblHU.BackColor = System.Drawing.Color.Transparent;
            this.lblHU.ForeColor = System.Drawing.Color.Black;
            this.lblHU.Location = new System.Drawing.Point(6, 58);
            this.lblHU.Name = "lblHU";
            this.lblHU.Size = new System.Drawing.Size(104, 21);
            this.lblHU.TabIndex = 13;
            this.lblHU.Text = "Hours Used:";
            this.lblHU.Click += new System.EventHandler(this.lblHU_Click);
            // 
            // lblHA
            // 
            this.lblHA.AutoSize = true;
            this.lblHA.BackColor = System.Drawing.Color.Transparent;
            this.lblHA.ForeColor = System.Drawing.Color.Black;
            this.lblHA.Location = new System.Drawing.Point(6, 26);
            this.lblHA.Name = "lblHA";
            this.lblHA.Size = new System.Drawing.Size(131, 21);
            this.lblHA.TabIndex = 12;
            this.lblHA.Text = "Hours Available:";
            this.lblHA.Click += new System.EventHandler(this.lblHA_Click);
            // 
            // lblRequiredInfo
            // 
            this.lblRequiredInfo.AutoSize = true;
            this.lblRequiredInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblRequiredInfo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredInfo.Location = new System.Drawing.Point(6, 90);
            this.lblRequiredInfo.Name = "lblRequiredInfo";
            this.lblRequiredInfo.Size = new System.Drawing.Size(194, 34);
            this.lblRequiredInfo.TabIndex = 16;
            this.lblRequiredInfo.Text = "*48 Hour Minimum to Change\r\nVacation starts after rest day(s)\r\n";
            this.lblRequiredInfo.Click += new System.EventHandler(this.lblRequiredInfo_Click);
            // 
            // lblHoursUsed
            // 
            this.lblHoursUsed.AutoSize = true;
            this.lblHoursUsed.BackColor = System.Drawing.Color.Transparent;
            this.lblHoursUsed.ForeColor = System.Drawing.Color.Gold;
            this.lblHoursUsed.Location = new System.Drawing.Point(172, 58);
            this.lblHoursUsed.Name = "lblHoursUsed";
            this.lblHoursUsed.Size = new System.Drawing.Size(28, 21);
            this.lblHoursUsed.TabIndex = 15;
            this.lblHoursUsed.Text = "00";
            // 
            // lblHoursAvailable
            // 
            this.lblHoursAvailable.AutoSize = true;
            this.lblHoursAvailable.BackColor = System.Drawing.Color.Transparent;
            this.lblHoursAvailable.ForeColor = System.Drawing.Color.Gold;
            this.lblHoursAvailable.Location = new System.Drawing.Point(172, 26);
            this.lblHoursAvailable.Name = "lblHoursAvailable";
            this.lblHoursAvailable.Size = new System.Drawing.Size(28, 21);
            this.lblHoursAvailable.TabIndex = 14;
            this.lblHoursAvailable.Text = "00";
            // 
            // lblSelectedWeekOfYear
            // 
            this.lblSelectedWeekOfYear.AutoSize = true;
            this.lblSelectedWeekOfYear.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectedWeekOfYear.ForeColor = System.Drawing.Color.White;
            this.lblSelectedWeekOfYear.Location = new System.Drawing.Point(494, 189);
            this.lblSelectedWeekOfYear.Name = "lblSelectedWeekOfYear";
            this.lblSelectedWeekOfYear.Size = new System.Drawing.Size(15, 21);
            this.lblSelectedWeekOfYear.TabIndex = 11;
            this.lblSelectedWeekOfYear.Text = " ";
            this.lblSelectedWeekOfYear.Visible = false;
            this.lblSelectedWeekOfYear.Click += new System.EventHandler(this.lblSelectedWeekOfYear_Click);
            // 
            // btnChangeUnit
            // 
            this.btnChangeUnit.BackColor = System.Drawing.Color.Transparent;
            this.btnChangeUnit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangeUnit.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnChangeUnit.Location = new System.Drawing.Point(484, 265);
            this.btnChangeUnit.Name = "btnChangeUnit";
            this.btnChangeUnit.Size = new System.Drawing.Size(125, 34);
            this.btnChangeUnit.TabIndex = 10;
            this.btnChangeUnit.Text = "&Change Unit";
            this.btnChangeUnit.UseVisualStyleBackColor = false;
            this.btnChangeUnit.Click += new System.EventHandler(this.btnChangeUnit_Click);
            // 
            // lblCurrentTimer
            // 
            this.lblCurrentTimer.AutoSize = true;
            this.lblCurrentTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentTimer.ForeColor = System.Drawing.Color.White;
            this.lblCurrentTimer.Location = new System.Drawing.Point(250, 65);
            this.lblCurrentTimer.Name = "lblCurrentTimer";
            this.lblCurrentTimer.Size = new System.Drawing.Size(320, 21);
            this.lblCurrentTimer.TabIndex = 12;
            this.lblCurrentTimer.Text = "00:00:00 PM Thursday, October 20, 2016";
            // 
            // loginTableAdapter
            // 
            this.loginTableAdapter.ClearBeforeFill = true;
            // 
            // usersDataSet1
            // 
            this.usersDataSet1.DataSetName = "usersDataSet";
            this.usersDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UserChangeForm
            // 
            this.AcceptButton = this.btnChangeUnit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::frmLAX_Vacation.Properties.Resources.BlueSkyFly;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnQuit;
            this.ClientSize = new System.Drawing.Size(818, 476);
            this.Controls.Add(this.lblCurrentTimer);
            this.Controls.Add(this.lblWelcomeMessage);
            this.Controls.Add(this.grpMainControls);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UserChangeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome User.";
            this.Load += new System.EventHandler(this.UserChangeForm_Load);
            this.grpMainControls.ResumeLayout(false);
            this.grpMainControls.PerformLayout();
            this.flwUserChangeVacation.ResumeLayout(false);
            this.flwUserChangeVacation.PerformLayout();
            this.grpLeftSide.ResumeLayout(false);
            this.grpLeftSide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal void ShowDialog(string firstName, string lastName, int hours, string _role)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label lblWelcomeMessage;
        private System.Windows.Forms.Timer tmrCurrent;
        private System.Windows.Forms.MonthCalendar cldUserSelection;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.GroupBox grpMainControls;
        private System.Windows.Forms.Button btnChangeUnit;
        private System.Windows.Forms.Label lblSelectedWeekOfYear;
        private System.Windows.Forms.Label lblCurrentTimer;
        private System.Windows.Forms.Label lblHA;
        private System.Windows.Forms.Label lblHU;
        private System.Windows.Forms.Label lblHoursUsed;
        private System.Windows.Forms.Label lblHoursAvailable;
        private System.Windows.Forms.Label lblRequiredInfo;
        private System.Windows.Forms.Label lblFor;
        private System.Windows.Forms.Label lblWantTo;
        private System.Windows.Forms.GroupBox grpLeftSide;
        private System.Windows.Forms.FlowLayoutPanel flwUserChangeVacation;
        private System.Windows.Forms.ComboBox cbxFromUnit;
        private System.Windows.Forms.ComboBox cbxToUnit;
        private usersDataSet usersDataSet;
        private System.Windows.Forms.BindingSource loginBindingSource;
        private usersDataSetTableAdapters.LoginTableAdapter loginTableAdapter;
        private System.Windows.Forms.ListBox lstCurrentUserInfo;
        private System.Windows.Forms.Label lblUserRestDays;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmitChange;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private usersDataSet usersDataSet1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnChangeRestDays;
    }
}