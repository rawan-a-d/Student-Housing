namespace Project
{
    partial class FrmStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStudent));
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "10-11-19",
            "Clean after you use the kitchen.",
            "Peter Young"}, -1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "17-11-19",
            "Please be quiet after 23:59.",
            "Sarah Harrings"}, -1);
            this.pHeader = new System.Windows.Forms.Panel();
            this.btnMinimizeWindow = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.lbl_LoggedInAsName = new System.Windows.Forms.Label();
            this.lbl_LoggedInAsPicture = new System.Windows.Forms.PictureBox();
            this.lbl_LoggedInAs = new System.Windows.Forms.Label();
            this.mtcStudent = new MetroFramework.Controls.MetroTabControl();
            this.mtpSchedule = new MetroFramework.Controls.MetroTabPage();
            this.cb_FilterAssignee = new System.Windows.Forms.ComboBox();
            this.cbx_FilterTasks = new System.Windows.Forms.CheckBox();
            this.cbx_FilterEvents = new System.Windows.Forms.CheckBox();
            this.lblAsignee = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.cb_EventFloor = new System.Windows.Forms.ComboBox();
            this.label32 = new System.Windows.Forms.Label();
            this.tb_EventLocation = new System.Windows.Forms.TextBox();
            this.DTP_EventDateTime = new System.Windows.Forms.DateTimePicker();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblFloor = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_EventVoteSelectedNO = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_EventVoteSelectedYES = new System.Windows.Forms.Button();
            this.lv_PendingEvents = new System.Windows.Forms.ListView();
            this.tb_EventDescription = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.btn_EventSendRequest = new System.Windows.Forms.Button();
            this.lblCreateEvent = new System.Windows.Forms.Label();
            this.lblFilter = new System.Windows.Forms.Label();
            this.dgvSchedule = new System.Windows.Forms.DataGridView();
            this.chAsignee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_FilterSearch = new System.Windows.Forms.Button();
            this.mtpHouseRules = new MetroFramework.Controls.MetroTabPage();
            this.dgvHouseRulesStudent = new System.Windows.Forms.DataGridView();
            this.chIdStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chDateStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chDescriptionStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mtpAgreements = new MetroFramework.Controls.MetroTabPage();
            this.btn_NewAgreementSubmit = new System.Windows.Forms.Button();
            this.tb_NewAgreementDescription = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lv_Agreements = new System.Windows.Forms.ListView();
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mtpMessages = new MetroFramework.Controls.MetroTabPage();
            this.tbxMessageDescription = new System.Windows.Forms.TextBox();
            this.cbxMessageType = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvMessageStudent = new System.Windows.Forms.DataGridView();
            this.chMessagesId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chMessagesDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chMessageType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chMessageText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chMessageReply = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbxAddMessage = new System.Windows.Forms.PictureBox();
            this.pbxRemoveMessage = new System.Windows.Forms.PictureBox();
            this.btnRemoveSelectedMessage = new System.Windows.Forms.Button();
            this.btnMessageAdd = new System.Windows.Forms.Button();
            this.mtpProfile = new MetroFramework.Controls.MetroTabPage();
            this.dgvStudentTasks = new System.Windows.Forms.DataGridView();
            this.chDateTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chTaskDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chStatusTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCompleteTask = new System.Windows.Forms.Button();
            this.tbxFloor = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxAddBalance = new System.Windows.Forms.TextBox();
            this.tbxRoom = new System.Windows.Forms.TextBox();
            this.lblProfileFloor = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblAddBalance = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.tbxScore = new System.Windows.Forms.TextBox();
            this.tbxBalance = new System.Windows.Forms.TextBox();
            this.tbxPhone = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxAge = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblMyTasks = new System.Windows.Forms.Label();
            this.lblGeneralInfo = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pbxDeposit = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.pHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_LoggedInAsPicture)).BeginInit();
            this.mtcStudent.SuspendLayout();
            this.mtpSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            this.mtpHouseRules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHouseRulesStudent)).BeginInit();
            this.mtpAgreements.SuspendLayout();
            this.mtpMessages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessageStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAddMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRemoveMessage)).BeginInit();
            this.mtpProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDeposit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pHeader
            // 
            this.pHeader.BackColor = System.Drawing.Color.Teal;
            this.pHeader.Controls.Add(this.btnMinimizeWindow);
            this.pHeader.Controls.Add(this.btnX);
            this.pHeader.Controls.Add(this.btn_Logout);
            this.pHeader.Controls.Add(this.lbl_LoggedInAsName);
            this.pHeader.Controls.Add(this.lbl_LoggedInAsPicture);
            this.pHeader.Controls.Add(this.lbl_LoggedInAs);
            this.pHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHeader.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pHeader.Location = new System.Drawing.Point(0, 0);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(1052, 100);
            this.pHeader.TabIndex = 43;
            // 
            // btnMinimizeWindow
            // 
            this.btnMinimizeWindow.BackColor = System.Drawing.Color.Teal;
            this.btnMinimizeWindow.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizeWindow.FlatAppearance.BorderSize = 0;
            this.btnMinimizeWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizeWindow.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizeWindow.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnMinimizeWindow.Location = new System.Drawing.Point(885, 0);
            this.btnMinimizeWindow.Name = "btnMinimizeWindow";
            this.btnMinimizeWindow.Size = new System.Drawing.Size(86, 100);
            this.btnMinimizeWindow.TabIndex = 17;
            this.btnMinimizeWindow.Text = "-";
            this.btnMinimizeWindow.UseVisualStyleBackColor = false;
            this.btnMinimizeWindow.Click += new System.EventHandler(this.btnMinimizeWindow_Click);
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.Teal;
            this.btnX.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnX.FlatAppearance.BorderSize = 0;
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnX.Location = new System.Drawing.Point(971, 0);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(81, 100);
            this.btnX.TabIndex = 16;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(223)))), ((int)(((byte)(225)))));
            this.btn_Logout.FlatAppearance.BorderSize = 0;
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.Location = new System.Drawing.Point(311, 26);
            this.btn_Logout.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(100, 49);
            this.btn_Logout.TabIndex = 15;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // lbl_LoggedInAsName
            // 
            this.lbl_LoggedInAsName.AutoSize = true;
            this.lbl_LoggedInAsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LoggedInAsName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_LoggedInAsName.Location = new System.Drawing.Point(86, 39);
            this.lbl_LoggedInAsName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_LoggedInAsName.Name = "lbl_LoggedInAsName";
            this.lbl_LoggedInAsName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_LoggedInAsName.Size = new System.Drawing.Size(181, 36);
            this.lbl_LoggedInAsName.TabIndex = 13;
            this.lbl_LoggedInAsName.Text = "Peter Young";
            // 
            // lbl_LoggedInAsPicture
            // 
            this.lbl_LoggedInAsPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_LoggedInAsPicture.Image = ((System.Drawing.Image)(resources.GetObject("lbl_LoggedInAsPicture.Image")));
            this.lbl_LoggedInAsPicture.Location = new System.Drawing.Point(26, 21);
            this.lbl_LoggedInAsPicture.Margin = new System.Windows.Forms.Padding(4);
            this.lbl_LoggedInAsPicture.Name = "lbl_LoggedInAsPicture";
            this.lbl_LoggedInAsPicture.Size = new System.Drawing.Size(55, 49);
            this.lbl_LoggedInAsPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lbl_LoggedInAsPicture.TabIndex = 12;
            this.lbl_LoggedInAsPicture.TabStop = false;
            // 
            // lbl_LoggedInAs
            // 
            this.lbl_LoggedInAs.AutoSize = true;
            this.lbl_LoggedInAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LoggedInAs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_LoggedInAs.Location = new System.Drawing.Point(90, 20);
            this.lbl_LoggedInAs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_LoggedInAs.Name = "lbl_LoggedInAs";
            this.lbl_LoggedInAs.Size = new System.Drawing.Size(92, 18);
            this.lbl_LoggedInAs.TabIndex = 11;
            this.lbl_LoggedInAs.Text = "Logged in as";
            // 
            // mtcStudent
            // 
            this.mtcStudent.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.mtcStudent.Controls.Add(this.mtpSchedule);
            this.mtcStudent.Controls.Add(this.mtpHouseRules);
            this.mtcStudent.Controls.Add(this.mtpAgreements);
            this.mtcStudent.Controls.Add(this.mtpMessages);
            this.mtcStudent.Controls.Add(this.mtpProfile);
            this.mtcStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtcStudent.CustomBackground = true;
            this.mtcStudent.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.mtcStudent.ItemSize = new System.Drawing.Size(86, 35);
            this.mtcStudent.Location = new System.Drawing.Point(0, 98);
            this.mtcStudent.Name = "mtcStudent";
            this.mtcStudent.SelectedIndex = 4;
            this.mtcStudent.Size = new System.Drawing.Size(1054, 521);
            this.mtcStudent.Style = MetroFramework.MetroColorStyle.Silver;
            this.mtcStudent.TabIndex = 44;
            this.mtcStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtcStudent.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtcStudent.UseStyleColors = true;
            // 
            // mtpSchedule
            // 
            this.mtpSchedule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mtpSchedule.Controls.Add(this.cb_FilterAssignee);
            this.mtpSchedule.Controls.Add(this.cbx_FilterTasks);
            this.mtpSchedule.Controls.Add(this.cbx_FilterEvents);
            this.mtpSchedule.Controls.Add(this.lblAsignee);
            this.mtpSchedule.Controls.Add(this.label33);
            this.mtpSchedule.Controls.Add(this.cb_EventFloor);
            this.mtpSchedule.Controls.Add(this.label32);
            this.mtpSchedule.Controls.Add(this.tb_EventLocation);
            this.mtpSchedule.Controls.Add(this.DTP_EventDateTime);
            this.mtpSchedule.Controls.Add(this.lblDateTime);
            this.mtpSchedule.Controls.Add(this.lblFloor);
            this.mtpSchedule.Controls.Add(this.pictureBox2);
            this.mtpSchedule.Controls.Add(this.btn_EventVoteSelectedNO);
            this.mtpSchedule.Controls.Add(this.label8);
            this.mtpSchedule.Controls.Add(this.btn_EventVoteSelectedYES);
            this.mtpSchedule.Controls.Add(this.lv_PendingEvents);
            this.mtpSchedule.Controls.Add(this.tb_EventDescription);
            this.mtpSchedule.Controls.Add(this.lblLocation);
            this.mtpSchedule.Controls.Add(this.btn_EventSendRequest);
            this.mtpSchedule.Controls.Add(this.lblCreateEvent);
            this.mtpSchedule.Controls.Add(this.lblFilter);
            this.mtpSchedule.Controls.Add(this.dgvSchedule);
            this.mtpSchedule.Controls.Add(this.btn_FilterSearch);
            this.mtpSchedule.CustomBackground = true;
            this.mtpSchedule.HorizontalScrollbarBarColor = true;
            this.mtpSchedule.ImeMode = System.Windows.Forms.ImeMode.On;
            this.mtpSchedule.Location = new System.Drawing.Point(4, 39);
            this.mtpSchedule.Name = "mtpSchedule";
            this.mtpSchedule.Size = new System.Drawing.Size(1046, 478);
            this.mtpSchedule.TabIndex = 0;
            this.mtpSchedule.Text = "Schedule";
            this.mtpSchedule.VerticalScrollbarBarColor = true;
            // 
            // cb_FilterAssignee
            // 
            this.cb_FilterAssignee.FormattingEnabled = true;
            this.cb_FilterAssignee.Location = new System.Drawing.Point(567, 33);
            this.cb_FilterAssignee.Margin = new System.Windows.Forms.Padding(4);
            this.cb_FilterAssignee.Name = "cb_FilterAssignee";
            this.cb_FilterAssignee.Size = new System.Drawing.Size(127, 24);
            this.cb_FilterAssignee.TabIndex = 56;
            // 
            // cbx_FilterTasks
            // 
            this.cbx_FilterTasks.AutoSize = true;
            this.cbx_FilterTasks.BackColor = System.Drawing.SystemColors.Control;
            this.cbx_FilterTasks.Location = new System.Drawing.Point(793, 37);
            this.cbx_FilterTasks.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_FilterTasks.Name = "cbx_FilterTasks";
            this.cbx_FilterTasks.Size = new System.Drawing.Size(68, 21);
            this.cbx_FilterTasks.TabIndex = 55;
            this.cbx_FilterTasks.Text = "Tasks";
            this.cbx_FilterTasks.UseVisualStyleBackColor = false;
            // 
            // cbx_FilterEvents
            // 
            this.cbx_FilterEvents.AutoSize = true;
            this.cbx_FilterEvents.BackColor = System.Drawing.SystemColors.Control;
            this.cbx_FilterEvents.Location = new System.Drawing.Point(707, 37);
            this.cbx_FilterEvents.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_FilterEvents.Name = "cbx_FilterEvents";
            this.cbx_FilterEvents.Size = new System.Drawing.Size(73, 21);
            this.cbx_FilterEvents.TabIndex = 54;
            this.cbx_FilterEvents.Text = "Events";
            this.cbx_FilterEvents.UseVisualStyleBackColor = false;
            // 
            // lblAsignee
            // 
            this.lblAsignee.AutoSize = true;
            this.lblAsignee.BackColor = System.Drawing.SystemColors.Control;
            this.lblAsignee.Location = new System.Drawing.Point(500, 36);
            this.lblAsignee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAsignee.Name = "lblAsignee";
            this.lblAsignee.Size = new System.Drawing.Size(59, 17);
            this.lblAsignee.TabIndex = 53;
            this.lblAsignee.Text = "Asignee";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(737, 118);
            this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(0, 17);
            this.label33.TabIndex = 51;
            // 
            // cb_EventFloor
            // 
            this.cb_EventFloor.FormattingEnabled = true;
            this.cb_EventFloor.Location = new System.Drawing.Point(741, 136);
            this.cb_EventFloor.Margin = new System.Windows.Forms.Padding(4);
            this.cb_EventFloor.Name = "cb_EventFloor";
            this.cb_EventFloor.Size = new System.Drawing.Size(73, 24);
            this.cb_EventFloor.TabIndex = 50;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(820, 118);
            this.label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(0, 17);
            this.label32.TabIndex = 49;
            // 
            // tb_EventLocation
            // 
            this.tb_EventLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_EventLocation.Location = new System.Drawing.Point(824, 136);
            this.tb_EventLocation.Margin = new System.Windows.Forms.Padding(4);
            this.tb_EventLocation.Name = "tb_EventLocation";
            this.tb_EventLocation.Size = new System.Drawing.Size(152, 24);
            this.tb_EventLocation.TabIndex = 48;
            // 
            // DTP_EventDateTime
            // 
            this.DTP_EventDateTime.Location = new System.Drawing.Point(505, 138);
            this.DTP_EventDateTime.Margin = new System.Windows.Forms.Padding(4);
            this.DTP_EventDateTime.Name = "DTP_EventDateTime";
            this.DTP_EventDateTime.Size = new System.Drawing.Size(228, 22);
            this.DTP_EventDateTime.TabIndex = 47;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.BackColor = System.Drawing.SystemColors.Control;
            this.lblDateTime.Location = new System.Drawing.Point(504, 117);
            this.lblDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(101, 17);
            this.lblDateTime.TabIndex = 46;
            this.lblDateTime.Text = "Date and Time";
            // 
            // lblFloor
            // 
            this.lblFloor.AutoSize = true;
            this.lblFloor.BackColor = System.Drawing.SystemColors.Control;
            this.lblFloor.Location = new System.Drawing.Point(740, 115);
            this.lblFloor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFloor.Name = "lblFloor";
            this.lblFloor.Size = new System.Drawing.Size(40, 17);
            this.lblFloor.TabIndex = 45;
            this.lblFloor.Text = "Floor";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(504, 75);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(531, 1);
            this.pictureBox2.TabIndex = 44;
            this.pictureBox2.TabStop = false;
            // 
            // btn_EventVoteSelectedNO
            // 
            this.btn_EventVoteSelectedNO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.btn_EventVoteSelectedNO.FlatAppearance.BorderSize = 0;
            this.btn_EventVoteSelectedNO.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_EventVoteSelectedNO.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_EventVoteSelectedNO.Location = new System.Drawing.Point(607, 399);
            this.btn_EventVoteSelectedNO.Margin = new System.Windows.Forms.Padding(4);
            this.btn_EventVoteSelectedNO.Name = "btn_EventVoteSelectedNO";
            this.btn_EventVoteSelectedNO.Size = new System.Drawing.Size(87, 28);
            this.btn_EventVoteSelectedNO.TabIndex = 43;
            this.btn_EventVoteSelectedNO.Text = "NO";
            this.btn_EventVoteSelectedNO.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(291, 405);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 17);
            this.label8.TabIndex = 42;
            // 
            // btn_EventVoteSelectedYES
            // 
            this.btn_EventVoteSelectedYES.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.btn_EventVoteSelectedYES.FlatAppearance.BorderSize = 0;
            this.btn_EventVoteSelectedYES.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_EventVoteSelectedYES.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_EventVoteSelectedYES.Location = new System.Drawing.Point(503, 399);
            this.btn_EventVoteSelectedYES.Margin = new System.Windows.Forms.Padding(4);
            this.btn_EventVoteSelectedYES.Name = "btn_EventVoteSelectedYES";
            this.btn_EventVoteSelectedYES.Size = new System.Drawing.Size(87, 28);
            this.btn_EventVoteSelectedYES.TabIndex = 41;
            this.btn_EventVoteSelectedYES.Text = "YES";
            this.btn_EventVoteSelectedYES.UseVisualStyleBackColor = false;
            // 
            // lv_PendingEvents
            // 
            this.lv_PendingEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_PendingEvents.HideSelection = false;
            this.lv_PendingEvents.Location = new System.Drawing.Point(505, 245);
            this.lv_PendingEvents.Margin = new System.Windows.Forms.Padding(4);
            this.lv_PendingEvents.Name = "lv_PendingEvents";
            this.lv_PendingEvents.Size = new System.Drawing.Size(471, 128);
            this.lv_PendingEvents.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lv_PendingEvents.TabIndex = 40;
            this.lv_PendingEvents.UseCompatibleStateImageBehavior = false;
            this.lv_PendingEvents.View = System.Windows.Forms.View.Details;
            // 
            // tb_EventDescription
            // 
            this.tb_EventDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_EventDescription.Location = new System.Drawing.Point(505, 192);
            this.tb_EventDescription.Margin = new System.Windows.Forms.Padding(4);
            this.tb_EventDescription.Multiline = true;
            this.tb_EventDescription.Name = "tb_EventDescription";
            this.tb_EventDescription.Size = new System.Drawing.Size(140, 33);
            this.tb_EventDescription.TabIndex = 37;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.BackColor = System.Drawing.SystemColors.Control;
            this.lblLocation.Location = new System.Drawing.Point(821, 115);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(62, 17);
            this.lblLocation.TabIndex = 39;
            this.lblLocation.Text = "Location";
            // 
            // btn_EventSendRequest
            // 
            this.btn_EventSendRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.btn_EventSendRequest.FlatAppearance.BorderSize = 0;
            this.btn_EventSendRequest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_EventSendRequest.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_EventSendRequest.Location = new System.Drawing.Point(655, 189);
            this.btn_EventSendRequest.Margin = new System.Windows.Forms.Padding(4);
            this.btn_EventSendRequest.Name = "btn_EventSendRequest";
            this.btn_EventSendRequest.Size = new System.Drawing.Size(123, 36);
            this.btn_EventSendRequest.TabIndex = 38;
            this.btn_EventSendRequest.Text = "Send request";
            this.btn_EventSendRequest.UseVisualStyleBackColor = false;
            // 
            // lblCreateEvent
            // 
            this.lblCreateEvent.AutoSize = true;
            this.lblCreateEvent.BackColor = System.Drawing.SystemColors.Control;
            this.lblCreateEvent.Location = new System.Drawing.Point(504, 89);
            this.lblCreateEvent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreateEvent.Name = "lblCreateEvent";
            this.lblCreateEvent.Size = new System.Drawing.Size(89, 17);
            this.lblCreateEvent.TabIndex = 36;
            this.lblCreateEvent.Text = "Create event";
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.BackColor = System.Drawing.SystemColors.Control;
            this.lblFilter.Location = new System.Drawing.Point(564, 6);
            this.lblFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(89, 17);
            this.lblFilter.TabIndex = 35;
            this.lblFilter.Text = "Filter options";
            // 
            // dgvSchedule
            // 
            this.dgvSchedule.AllowUserToDeleteRows = false;
            this.dgvSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSchedule.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSchedule.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSchedule.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chAsignee,
            this.chDate,
            this.chTask,
            this.chStatus});
            this.dgvSchedule.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSchedule.Location = new System.Drawing.Point(22, 11);
            this.dgvSchedule.Name = "dgvSchedule";
            this.dgvSchedule.ReadOnly = true;
            this.dgvSchedule.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSchedule.RowHeadersVisible = false;
            this.dgvSchedule.RowHeadersWidth = 51;
            this.dgvSchedule.RowTemplate.Height = 24;
            this.dgvSchedule.Size = new System.Drawing.Size(438, 423);
            this.dgvSchedule.TabIndex = 34;
            // 
            // chAsignee
            // 
            this.chAsignee.HeaderText = "Asignee";
            this.chAsignee.MinimumWidth = 6;
            this.chAsignee.Name = "chAsignee";
            this.chAsignee.ReadOnly = true;
            // 
            // chDate
            // 
            this.chDate.HeaderText = "Date";
            this.chDate.MinimumWidth = 6;
            this.chDate.Name = "chDate";
            this.chDate.ReadOnly = true;
            // 
            // chTask
            // 
            this.chTask.HeaderText = "Task";
            this.chTask.MinimumWidth = 6;
            this.chTask.Name = "chTask";
            this.chTask.ReadOnly = true;
            // 
            // chStatus
            // 
            this.chStatus.HeaderText = "Status";
            this.chStatus.MinimumWidth = 6;
            this.chStatus.Name = "chStatus";
            this.chStatus.ReadOnly = true;
            // 
            // btn_FilterSearch
            // 
            this.btn_FilterSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.btn_FilterSearch.FlatAppearance.BorderSize = 0;
            this.btn_FilterSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_FilterSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FilterSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_FilterSearch.Location = new System.Drawing.Point(872, 30);
            this.btn_FilterSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btn_FilterSearch.Name = "btn_FilterSearch";
            this.btn_FilterSearch.Size = new System.Drawing.Size(138, 37);
            this.btn_FilterSearch.TabIndex = 52;
            this.btn_FilterSearch.Text = "Search";
            this.btn_FilterSearch.UseVisualStyleBackColor = false;
            // 
            // mtpHouseRules
            // 
            this.mtpHouseRules.Controls.Add(this.dgvHouseRulesStudent);
            this.mtpHouseRules.HorizontalScrollbarBarColor = true;
            this.mtpHouseRules.Location = new System.Drawing.Point(4, 39);
            this.mtpHouseRules.Name = "mtpHouseRules";
            this.mtpHouseRules.Size = new System.Drawing.Size(1046, 478);
            this.mtpHouseRules.TabIndex = 1;
            this.mtpHouseRules.Text = "House Rules";
            this.mtpHouseRules.VerticalScrollbarBarColor = true;
            // 
            // dgvHouseRulesStudent
            // 
            this.dgvHouseRulesStudent.AllowUserToDeleteRows = false;
            this.dgvHouseRulesStudent.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvHouseRulesStudent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvHouseRulesStudent.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvHouseRulesStudent.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvHouseRulesStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHouseRulesStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chIdStudent,
            this.chDateStudent,
            this.chDescriptionStudent});
            this.dgvHouseRulesStudent.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvHouseRulesStudent.Location = new System.Drawing.Point(9, 11);
            this.dgvHouseRulesStudent.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHouseRulesStudent.Name = "dgvHouseRulesStudent";
            this.dgvHouseRulesStudent.RowHeadersVisible = false;
            this.dgvHouseRulesStudent.RowHeadersWidth = 51;
            this.dgvHouseRulesStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHouseRulesStudent.Size = new System.Drawing.Size(1026, 421);
            this.dgvHouseRulesStudent.TabIndex = 9;
            // 
            // chIdStudent
            // 
            this.chIdStudent.HeaderText = "Id";
            this.chIdStudent.MinimumWidth = 6;
            this.chIdStudent.Name = "chIdStudent";
            this.chIdStudent.Width = 122;
            // 
            // chDateStudent
            // 
            this.chDateStudent.HeaderText = "Date Added";
            this.chDateStudent.MinimumWidth = 6;
            this.chDateStudent.Name = "chDateStudent";
            this.chDateStudent.Width = 190;
            // 
            // chDescriptionStudent
            // 
            this.chDescriptionStudent.HeaderText = "Description";
            this.chDescriptionStudent.MinimumWidth = 6;
            this.chDescriptionStudent.Name = "chDescriptionStudent";
            this.chDescriptionStudent.Width = 477;
            // 
            // mtpAgreements
            // 
            this.mtpAgreements.Controls.Add(this.btn_NewAgreementSubmit);
            this.mtpAgreements.Controls.Add(this.tb_NewAgreementDescription);
            this.mtpAgreements.Controls.Add(this.label9);
            this.mtpAgreements.Controls.Add(this.lv_Agreements);
            this.mtpAgreements.HorizontalScrollbarBarColor = true;
            this.mtpAgreements.Location = new System.Drawing.Point(4, 39);
            this.mtpAgreements.Name = "mtpAgreements";
            this.mtpAgreements.Size = new System.Drawing.Size(1046, 478);
            this.mtpAgreements.TabIndex = 2;
            this.mtpAgreements.Text = "Agreements";
            this.mtpAgreements.VerticalScrollbarBarColor = true;
            // 
            // btn_NewAgreementSubmit
            // 
            this.btn_NewAgreementSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.btn_NewAgreementSubmit.FlatAppearance.BorderSize = 0;
            this.btn_NewAgreementSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_NewAgreementSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_NewAgreementSubmit.Location = new System.Drawing.Point(961, 372);
            this.btn_NewAgreementSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_NewAgreementSubmit.Name = "btn_NewAgreementSubmit";
            this.btn_NewAgreementSubmit.Size = new System.Drawing.Size(76, 27);
            this.btn_NewAgreementSubmit.TabIndex = 6;
            this.btn_NewAgreementSubmit.Text = "Submit";
            this.btn_NewAgreementSubmit.UseVisualStyleBackColor = false;
            // 
            // tb_NewAgreementDescription
            // 
            this.tb_NewAgreementDescription.Location = new System.Drawing.Point(7, 374);
            this.tb_NewAgreementDescription.Margin = new System.Windows.Forms.Padding(4);
            this.tb_NewAgreementDescription.Name = "tb_NewAgreementDescription";
            this.tb_NewAgreementDescription.Size = new System.Drawing.Size(946, 22);
            this.tb_NewAgreementDescription.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 344);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 18);
            this.label9.TabIndex = 3;
            this.label9.Text = "Add agreement";
            // 
            // lv_Agreements
            // 
            this.lv_Agreements.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader23});
            this.lv_Agreements.HideSelection = false;
            this.lv_Agreements.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem5,
            listViewItem6});
            this.lv_Agreements.Location = new System.Drawing.Point(4, 11);
            this.lv_Agreements.Margin = new System.Windows.Forms.Padding(4);
            this.lv_Agreements.Name = "lv_Agreements";
            this.lv_Agreements.Size = new System.Drawing.Size(1033, 320);
            this.lv_Agreements.TabIndex = 2;
            this.lv_Agreements.UseCompatibleStateImageBehavior = false;
            this.lv_Agreements.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Date Added";
            this.columnHeader12.Width = 70;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Description";
            this.columnHeader13.Width = 595;
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "Creator";
            this.columnHeader23.Width = 104;
            // 
            // mtpMessages
            // 
            this.mtpMessages.Controls.Add(this.tbxMessageDescription);
            this.mtpMessages.Controls.Add(this.cbxMessageType);
            this.mtpMessages.Controls.Add(this.label11);
            this.mtpMessages.Controls.Add(this.dgvMessageStudent);
            this.mtpMessages.Controls.Add(this.pbxAddMessage);
            this.mtpMessages.Controls.Add(this.pbxRemoveMessage);
            this.mtpMessages.Controls.Add(this.btnRemoveSelectedMessage);
            this.mtpMessages.Controls.Add(this.btnMessageAdd);
            this.mtpMessages.HorizontalScrollbarBarColor = true;
            this.mtpMessages.Location = new System.Drawing.Point(4, 39);
            this.mtpMessages.Name = "mtpMessages";
            this.mtpMessages.Size = new System.Drawing.Size(1046, 478);
            this.mtpMessages.TabIndex = 3;
            this.mtpMessages.Text = "Complaints and Questions";
            this.mtpMessages.VerticalScrollbarBarColor = true;
            // 
            // tbxMessageDescription
            // 
            this.tbxMessageDescription.Location = new System.Drawing.Point(187, 405);
            this.tbxMessageDescription.Margin = new System.Windows.Forms.Padding(4);
            this.tbxMessageDescription.Multiline = true;
            this.tbxMessageDescription.Name = "tbxMessageDescription";
            this.tbxMessageDescription.Size = new System.Drawing.Size(706, 24);
            this.tbxMessageDescription.TabIndex = 12;
            // 
            // cbxMessageType
            // 
            this.cbxMessageType.FormattingEnabled = true;
            this.cbxMessageType.Items.AddRange(new object[] {
            "Question",
            "Complaint"});
            this.cbxMessageType.Location = new System.Drawing.Point(4, 405);
            this.cbxMessageType.Margin = new System.Windows.Forms.Padding(4);
            this.cbxMessageType.Name = "cbxMessageType";
            this.cbxMessageType.Size = new System.Drawing.Size(175, 24);
            this.cbxMessageType.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(4, 371);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(141, 18);
            this.label11.TabIndex = 10;
            this.label11.Text = "Add a new message";
            // 
            // dgvMessageStudent
            // 
            this.dgvMessageStudent.AllowUserToDeleteRows = false;
            this.dgvMessageStudent.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvMessageStudent.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvMessageStudent.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMessageStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMessageStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chMessagesId,
            this.chMessagesDate,
            this.chMessageType,
            this.chMessageText,
            this.chMessageReply});
            this.dgvMessageStudent.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMessageStudent.Location = new System.Drawing.Point(0, 0);
            this.dgvMessageStudent.Name = "dgvMessageStudent";
            this.dgvMessageStudent.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMessageStudent.RowHeadersVisible = false;
            this.dgvMessageStudent.RowHeadersWidth = 51;
            this.dgvMessageStudent.RowTemplate.Height = 24;
            this.dgvMessageStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMessageStudent.Size = new System.Drawing.Size(1037, 289);
            this.dgvMessageStudent.TabIndex = 8;
            // 
            // chMessagesId
            // 
            this.chMessagesId.HeaderText = "Id";
            this.chMessagesId.MinimumWidth = 6;
            this.chMessagesId.Name = "chMessagesId";
            this.chMessagesId.Width = 50;
            // 
            // chMessagesDate
            // 
            this.chMessagesDate.HeaderText = "Date added";
            this.chMessagesDate.MinimumWidth = 6;
            this.chMessagesDate.Name = "chMessagesDate";
            this.chMessagesDate.Width = 175;
            // 
            // chMessageType
            // 
            this.chMessageType.HeaderText = "Type";
            this.chMessageType.MinimumWidth = 6;
            this.chMessageType.Name = "chMessageType";
            this.chMessageType.Width = 125;
            // 
            // chMessageText
            // 
            this.chMessageText.HeaderText = "Message";
            this.chMessageText.MinimumWidth = 6;
            this.chMessageText.Name = "chMessageText";
            this.chMessageText.Width = 300;
            // 
            // chMessageReply
            // 
            this.chMessageReply.HeaderText = "Reply";
            this.chMessageReply.MinimumWidth = 6;
            this.chMessageReply.Name = "chMessageReply";
            this.chMessageReply.Width = 300;
            // 
            // pbxAddMessage
            // 
            this.pbxAddMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.pbxAddMessage.BackgroundImage = global::Project.Properties.Resources.add_512;
            this.pbxAddMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxAddMessage.Location = new System.Drawing.Point(999, 389);
            this.pbxAddMessage.Name = "pbxAddMessage";
            this.pbxAddMessage.Size = new System.Drawing.Size(23, 25);
            this.pbxAddMessage.TabIndex = 17;
            this.pbxAddMessage.TabStop = false;
            // 
            // pbxRemoveMessage
            // 
            this.pbxRemoveMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.pbxRemoveMessage.BackgroundImage = global::Project.Properties.Resources.x_mark_4_512;
            this.pbxRemoveMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxRemoveMessage.Location = new System.Drawing.Point(200, 308);
            this.pbxRemoveMessage.Name = "pbxRemoveMessage";
            this.pbxRemoveMessage.Size = new System.Drawing.Size(20, 23);
            this.pbxRemoveMessage.TabIndex = 18;
            this.pbxRemoveMessage.TabStop = false;
            // 
            // btnRemoveSelectedMessage
            // 
            this.btnRemoveSelectedMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.btnRemoveSelectedMessage.FlatAppearance.BorderSize = 0;
            this.btnRemoveSelectedMessage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemoveSelectedMessage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemoveSelectedMessage.Location = new System.Drawing.Point(0, 296);
            this.btnRemoveSelectedMessage.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveSelectedMessage.Name = "btnRemoveSelectedMessage";
            this.btnRemoveSelectedMessage.Size = new System.Drawing.Size(236, 51);
            this.btnRemoveSelectedMessage.TabIndex = 9;
            this.btnRemoveSelectedMessage.Text = "Remove Selected";
            this.btnRemoveSelectedMessage.UseVisualStyleBackColor = false;
            this.btnRemoveSelectedMessage.Click += new System.EventHandler(this.BtnRemoveSelectedMessage_Click);
            // 
            // btnMessageAdd
            // 
            this.btnMessageAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.btnMessageAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMessageAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMessageAdd.Location = new System.Drawing.Point(901, 375);
            this.btnMessageAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnMessageAdd.Name = "btnMessageAdd";
            this.btnMessageAdd.Size = new System.Drawing.Size(136, 54);
            this.btnMessageAdd.TabIndex = 13;
            this.btnMessageAdd.Text = "Add";
            this.btnMessageAdd.UseVisualStyleBackColor = false;
            this.btnMessageAdd.Click += new System.EventHandler(this.BtnMessageAdd_Click);
            // 
            // mtpProfile
            // 
            this.mtpProfile.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mtpProfile.Controls.Add(this.dgvStudentTasks);
            this.mtpProfile.Controls.Add(this.btnEdit);
            this.mtpProfile.Controls.Add(this.btnCompleteTask);
            this.mtpProfile.Controls.Add(this.tbxFloor);
            this.mtpProfile.Controls.Add(this.tbxPassword);
            this.mtpProfile.Controls.Add(this.tbxAddBalance);
            this.mtpProfile.Controls.Add(this.tbxRoom);
            this.mtpProfile.Controls.Add(this.lblProfileFloor);
            this.mtpProfile.Controls.Add(this.lblPassword);
            this.mtpProfile.Controls.Add(this.lblAddBalance);
            this.mtpProfile.Controls.Add(this.lblRoom);
            this.mtpProfile.Controls.Add(this.tbxScore);
            this.mtpProfile.Controls.Add(this.tbxBalance);
            this.mtpProfile.Controls.Add(this.tbxPhone);
            this.mtpProfile.Controls.Add(this.tbxEmail);
            this.mtpProfile.Controls.Add(this.tbxAge);
            this.mtpProfile.Controls.Add(this.tbxName);
            this.mtpProfile.Controls.Add(this.lblScore);
            this.mtpProfile.Controls.Add(this.lblBalance);
            this.mtpProfile.Controls.Add(this.lblMyTasks);
            this.mtpProfile.Controls.Add(this.lblGeneralInfo);
            this.mtpProfile.Controls.Add(this.lblPhone);
            this.mtpProfile.Controls.Add(this.lblEmail);
            this.mtpProfile.Controls.Add(this.lblAge);
            this.mtpProfile.Controls.Add(this.lblName);
            this.mtpProfile.Controls.Add(this.pbxDeposit);
            this.mtpProfile.Controls.Add(this.pictureBox3);
            this.mtpProfile.Controls.Add(this.btnDeposit);
            this.mtpProfile.HorizontalScrollbarBarColor = true;
            this.mtpProfile.Location = new System.Drawing.Point(4, 39);
            this.mtpProfile.Name = "mtpProfile";
            this.mtpProfile.Size = new System.Drawing.Size(1046, 478);
            this.mtpProfile.TabIndex = 4;
            this.mtpProfile.Text = "Profile";
            this.mtpProfile.VerticalScrollbarBarColor = true;
            // 
            // dgvStudentTasks
            // 
            this.dgvStudentTasks.AllowUserToDeleteRows = false;
            this.dgvStudentTasks.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvStudentTasks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvStudentTasks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvStudentTasks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvStudentTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chDateTask,
            this.chTaskDesc,
            this.chStatusTask});
            this.dgvStudentTasks.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvStudentTasks.Location = new System.Drawing.Point(324, 43);
            this.dgvStudentTasks.Name = "dgvStudentTasks";
            this.dgvStudentTasks.RowHeadersVisible = false;
            this.dgvStudentTasks.RowHeadersWidth = 51;
            this.dgvStudentTasks.RowTemplate.Height = 24;
            this.dgvStudentTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudentTasks.Size = new System.Drawing.Size(652, 219);
            this.dgvStudentTasks.TabIndex = 70;
            // 
            // chDateTask
            // 
            this.chDateTask.HeaderText = "Date";
            this.chDateTask.MinimumWidth = 6;
            this.chDateTask.Name = "chDateTask";
            this.chDateTask.Width = 200;
            // 
            // chTaskDesc
            // 
            this.chTaskDesc.HeaderText = "Task";
            this.chTaskDesc.MinimumWidth = 6;
            this.chTaskDesc.Name = "chTaskDesc";
            this.chTaskDesc.Width = 150;
            // 
            // chStatusTask
            // 
            this.chStatusTask.HeaderText = "Status";
            this.chStatusTask.MinimumWidth = 6;
            this.chStatusTask.Name = "chStatusTask";
            this.chStatusTask.Width = 150;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit.Location = new System.Drawing.Point(24, 417);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(112, 38);
            this.btnEdit.TabIndex = 69;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCompleteTask
            // 
            this.btnCompleteTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.btnCompleteTask.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnCompleteTask.FlatAppearance.BorderSize = 0;
            this.btnCompleteTask.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCompleteTask.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCompleteTask.Location = new System.Drawing.Point(324, 282);
            this.btnCompleteTask.Margin = new System.Windows.Forms.Padding(4);
            this.btnCompleteTask.Name = "btnCompleteTask";
            this.btnCompleteTask.Size = new System.Drawing.Size(221, 45);
            this.btnCompleteTask.TabIndex = 68;
            this.btnCompleteTask.Text = "Complete Selected Task";
            this.btnCompleteTask.UseVisualStyleBackColor = false;
            this.btnCompleteTask.Click += new System.EventHandler(this.btnCompleteTask_Click);
            // 
            // tbxFloor
            // 
            this.tbxFloor.Location = new System.Drawing.Point(25, 265);
            this.tbxFloor.Margin = new System.Windows.Forms.Padding(4);
            this.tbxFloor.Name = "tbxFloor";
            this.tbxFloor.ReadOnly = true;
            this.tbxFloor.Size = new System.Drawing.Size(111, 22);
            this.tbxFloor.TabIndex = 67;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(25, 112);
            this.tbxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '*';
            this.tbxPassword.Size = new System.Drawing.Size(238, 22);
            this.tbxPassword.TabIndex = 65;
            // 
            // tbxAddBalance
            // 
            this.tbxAddBalance.Location = new System.Drawing.Point(324, 398);
            this.tbxAddBalance.Margin = new System.Windows.Forms.Padding(4);
            this.tbxAddBalance.Name = "tbxAddBalance";
            this.tbxAddBalance.Size = new System.Drawing.Size(238, 22);
            this.tbxAddBalance.TabIndex = 62;
            // 
            // tbxRoom
            // 
            this.tbxRoom.Location = new System.Drawing.Point(145, 265);
            this.tbxRoom.Margin = new System.Windows.Forms.Padding(4);
            this.tbxRoom.Name = "tbxRoom";
            this.tbxRoom.ReadOnly = true;
            this.tbxRoom.Size = new System.Drawing.Size(118, 22);
            this.tbxRoom.TabIndex = 60;
            // 
            // lblProfileFloor
            // 
            this.lblProfileFloor.AutoSize = true;
            this.lblProfileFloor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblProfileFloor.Location = new System.Drawing.Point(21, 245);
            this.lblProfileFloor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProfileFloor.Name = "lblProfileFloor";
            this.lblProfileFloor.Size = new System.Drawing.Size(40, 17);
            this.lblProfileFloor.TabIndex = 66;
            this.lblProfileFloor.Text = "Floor";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPassword.Location = new System.Drawing.Point(22, 94);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 17);
            this.lblPassword.TabIndex = 64;
            this.lblPassword.Text = "Password";
            // 
            // lblAddBalance
            // 
            this.lblAddBalance.AutoSize = true;
            this.lblAddBalance.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAddBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddBalance.Location = new System.Drawing.Point(327, 363);
            this.lblAddBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddBalance.Name = "lblAddBalance";
            this.lblAddBalance.Size = new System.Drawing.Size(88, 18);
            this.lblAddBalance.TabIndex = 61;
            this.lblAddBalance.Text = "Add balance";
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRoom.Location = new System.Drawing.Point(147, 245);
            this.lblRoom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(45, 17);
            this.lblRoom.TabIndex = 59;
            this.lblRoom.Text = "Room";
            // 
            // tbxScore
            // 
            this.tbxScore.Location = new System.Drawing.Point(25, 372);
            this.tbxScore.Margin = new System.Windows.Forms.Padding(4);
            this.tbxScore.Name = "tbxScore";
            this.tbxScore.ReadOnly = true;
            this.tbxScore.Size = new System.Drawing.Size(238, 22);
            this.tbxScore.TabIndex = 57;
            // 
            // tbxBalance
            // 
            this.tbxBalance.Location = new System.Drawing.Point(25, 314);
            this.tbxBalance.Margin = new System.Windows.Forms.Padding(4);
            this.tbxBalance.Name = "tbxBalance";
            this.tbxBalance.ReadOnly = true;
            this.tbxBalance.Size = new System.Drawing.Size(238, 22);
            this.tbxBalance.TabIndex = 55;
            // 
            // tbxPhone
            // 
            this.tbxPhone.Location = new System.Drawing.Point(23, 214);
            this.tbxPhone.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.Size = new System.Drawing.Size(240, 22);
            this.tbxPhone.TabIndex = 50;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(23, 163);
            this.tbxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(240, 22);
            this.tbxEmail.TabIndex = 48;
            // 
            // tbxAge
            // 
            this.tbxAge.Location = new System.Drawing.Point(190, 62);
            this.tbxAge.Margin = new System.Windows.Forms.Padding(4);
            this.tbxAge.Name = "tbxAge";
            this.tbxAge.Size = new System.Drawing.Size(73, 22);
            this.tbxAge.TabIndex = 46;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(23, 62);
            this.tbxName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(159, 22);
            this.tbxName.TabIndex = 44;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblScore.Location = new System.Drawing.Point(22, 346);
            this.lblScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(114, 17);
            this.lblScore.TabIndex = 56;
            this.lblScore.Text = "Score this month";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBalance.Location = new System.Drawing.Point(22, 296);
            this.lblBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(59, 17);
            this.lblBalance.TabIndex = 54;
            this.lblBalance.Text = "Balance";
            // 
            // lblMyTasks
            // 
            this.lblMyTasks.AutoSize = true;
            this.lblMyTasks.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMyTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyTasks.Location = new System.Drawing.Point(327, 11);
            this.lblMyTasks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMyTasks.Name = "lblMyTasks";
            this.lblMyTasks.Size = new System.Drawing.Size(76, 20);
            this.lblMyTasks.TabIndex = 52;
            this.lblMyTasks.Text = "My tasks";
            // 
            // lblGeneralInfo
            // 
            this.lblGeneralInfo.AutoSize = true;
            this.lblGeneralInfo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGeneralInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneralInfo.Location = new System.Drawing.Point(22, 11);
            this.lblGeneralInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGeneralInfo.Name = "lblGeneralInfo";
            this.lblGeneralInfo.Size = new System.Drawing.Size(156, 20);
            this.lblGeneralInfo.TabIndex = 51;
            this.lblGeneralInfo.Text = "General Information";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPhone.Location = new System.Drawing.Point(21, 196);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(49, 17);
            this.lblPhone.TabIndex = 49;
            this.lblPhone.Text = "Phone";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEmail.Location = new System.Drawing.Point(21, 144);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.TabIndex = 47;
            this.lblEmail.Text = "Email";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAge.Location = new System.Drawing.Point(190, 43);
            this.lblAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(33, 17);
            this.lblAge.TabIndex = 45;
            this.lblAge.Text = "Age";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblName.Location = new System.Drawing.Point(21, 42);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 43;
            this.lblName.Text = "Name";
            // 
            // pbxDeposit
            // 
            this.pbxDeposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.pbxDeposit.BackgroundImage = global::Project.Properties.Resources.banknotes_512;
            this.pbxDeposit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxDeposit.Location = new System.Drawing.Point(747, 384);
            this.pbxDeposit.Name = "pbxDeposit";
            this.pbxDeposit.Size = new System.Drawing.Size(22, 24);
            this.pbxDeposit.TabIndex = 2;
            this.pbxDeposit.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(297, 11);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1, 418);
            this.pictureBox3.TabIndex = 53;
            this.pictureBox3.TabStop = false;
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.btnDeposit.FlatAppearance.BorderSize = 0;
            this.btnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeposit.Location = new System.Drawing.Point(626, 374);
            this.btnDeposit.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(155, 46);
            this.btnDeposit.TabIndex = 63;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = false;
            // 
            // FrmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 612);
            this.Controls.Add(this.mtcStudent);
            this.Controls.Add(this.pHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmStudent";
            this.Text = "Student";
            this.pHeader.ResumeLayout(false);
            this.pHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_LoggedInAsPicture)).EndInit();
            this.mtcStudent.ResumeLayout(false);
            this.mtpSchedule.ResumeLayout(false);
            this.mtpSchedule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).EndInit();
            this.mtpHouseRules.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHouseRulesStudent)).EndInit();
            this.mtpAgreements.ResumeLayout(false);
            this.mtpAgreements.PerformLayout();
            this.mtpMessages.ResumeLayout(false);
            this.mtpMessages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessageStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAddMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRemoveMessage)).EndInit();
            this.mtpProfile.ResumeLayout(false);
            this.mtpProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentTasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDeposit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pHeader;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Label lbl_LoggedInAsName;
        private System.Windows.Forms.PictureBox lbl_LoggedInAsPicture;
        private System.Windows.Forms.Label lbl_LoggedInAs;
        private MetroFramework.Controls.MetroTabControl mtcStudent;
        private MetroFramework.Controls.MetroTabPage mtpSchedule;
        private System.Windows.Forms.ComboBox cb_FilterAssignee;
        private System.Windows.Forms.CheckBox cbx_FilterTasks;
        private System.Windows.Forms.CheckBox cbx_FilterEvents;
        private System.Windows.Forms.Label lblAsignee;
        private System.Windows.Forms.Button btn_FilterSearch;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.ComboBox cb_EventFloor;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox tb_EventLocation;
        private System.Windows.Forms.DateTimePicker DTP_EventDateTime;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblFloor;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_EventVoteSelectedNO;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_EventVoteSelectedYES;
        private System.Windows.Forms.ListView lv_PendingEvents;
        private System.Windows.Forms.TextBox tb_EventDescription;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Button btn_EventSendRequest;
        private System.Windows.Forms.Label lblCreateEvent;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.DataGridView dgvSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn chAsignee;
        private System.Windows.Forms.DataGridViewTextBoxColumn chDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn chTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn chStatus;
        private MetroFramework.Controls.MetroTabPage mtpHouseRules;
        private System.Windows.Forms.DataGridView dgvHouseRulesStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn chIdStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn chDateStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn chDescriptionStudent;
        private MetroFramework.Controls.MetroTabPage mtpAgreements;
        private System.Windows.Forms.Button btn_NewAgreementSubmit;
        private System.Windows.Forms.TextBox tb_NewAgreementDescription;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView lv_Agreements;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private MetroFramework.Controls.MetroTabPage mtpMessages;
        private System.Windows.Forms.Button btnMessageAdd;
        private System.Windows.Forms.TextBox tbxMessageDescription;
        private System.Windows.Forms.ComboBox cbxMessageType;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnRemoveSelectedMessage;
        private System.Windows.Forms.DataGridView dgvMessageStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn chMessagesId;
        private System.Windows.Forms.DataGridViewTextBoxColumn chMessagesDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn chMessageType;
        private System.Windows.Forms.DataGridViewTextBoxColumn chMessageText;
        private System.Windows.Forms.DataGridViewTextBoxColumn chMessageReply;
        private MetroFramework.Controls.MetroTabPage mtpProfile;
        private System.Windows.Forms.Button btnCompleteTask;
        private System.Windows.Forms.TextBox tbxFloor;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxAddBalance;
        private System.Windows.Forms.TextBox tbxRoom;
        private System.Windows.Forms.Label lblProfileFloor;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Label lblAddBalance;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.TextBox tbxScore;
        private System.Windows.Forms.TextBox tbxBalance;
        private System.Windows.Forms.TextBox tbxPhone;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxAge;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblMyTasks;
        private System.Windows.Forms.Label lblGeneralInfo;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button btnMinimizeWindow;
        private System.Windows.Forms.PictureBox pbxDeposit;
        private System.Windows.Forms.PictureBox pbxAddMessage;
        private System.Windows.Forms.PictureBox pbxRemoveMessage;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView dgvStudentTasks;
        private System.Windows.Forms.DataGridViewTextBoxColumn chDateTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn chTaskDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn chStatusTask;
    }
}