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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "10-11-19",
            "Clean after you use the kitchen.",
            "Peter Young"}, -1);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "17-11-19",
            "Please be quiet after 23:59.",
            "Sarah Harrings"}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStudent));
            this.pHeader = new System.Windows.Forms.Panel();
            this.btnMinimizeWindow = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.lbl_LoggedInAsName = new System.Windows.Forms.Label();
            this.btn_SwitchInterface = new System.Windows.Forms.Button();
            this.lbl_LoggedInAs = new System.Windows.Forms.Label();
            this.mtcStudent = new MetroFramework.Controls.MetroTabControl();
            this.mtpSchedule = new MetroFramework.Controls.MetroTabPage();
            this.cb_FilterAssignee = new System.Windows.Forms.ComboBox();
            this.cbx_FilterTasks = new System.Windows.Forms.CheckBox();
            this.cbx_FilterEvents = new System.Windows.Forms.CheckBox();
            this.lblAsignee = new System.Windows.Forms.Label();
            this.btn_FilterSearch = new System.Windows.Forms.Button();
            this.label33 = new System.Windows.Forms.Label();
            this.cb_EventFloor = new System.Windows.Forms.ComboBox();
            this.label32 = new System.Windows.Forms.Label();
            this.tb_EventLocation = new System.Windows.Forms.TextBox();
            this.DTP_EventDateTime = new System.Windows.Forms.DateTimePicker();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblFloor = new System.Windows.Forms.Label();
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
            this.mtpMessages = new MetroFramework.Controls.MetroTabPage();
            this.btnMessageAdd = new System.Windows.Forms.Button();
            this.tbxMessageDescription = new System.Windows.Forms.TextBox();
            this.cbxMessageType = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvMessageStudent = new System.Windows.Forms.DataGridView();
            this.chMessagesId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chMessagesDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chMessageType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chMessageText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chMessageReply = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemoveSelectedMessage = new System.Windows.Forms.Button();
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
            this.mtpProfile = new MetroFramework.Controls.MetroTabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lv_MyTasks = new System.Windows.Forms.ListView();
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Task = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label21 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lblDate = new System.Windows.Forms.Label();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.btnNextMonth = new System.Windows.Forms.Button();
            this.btnPrevMonth = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbxAddMessage = new System.Windows.Forms.PictureBox();
            this.pbxRemoveMessage = new System.Windows.Forms.PictureBox();
            this.pbxDeposit = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbl_LoggedInAsPicture = new System.Windows.Forms.PictureBox();
            this.pHeader.SuspendLayout();
            this.mtcStudent.SuspendLayout();
            this.mtpSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            this.mtpMessages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessageStudent)).BeginInit();
            this.mtpHouseRules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHouseRulesStudent)).BeginInit();
            this.mtpAgreements.SuspendLayout();
            this.mtpProfile.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAddMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRemoveMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDeposit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_LoggedInAsPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // pHeader
            // 
            this.pHeader.BackColor = System.Drawing.Color.Teal;
            this.pHeader.Controls.Add(this.btnMinimizeWindow);
            this.pHeader.Controls.Add(this.btnX);
            this.pHeader.Controls.Add(this.btn_Logout);
            this.pHeader.Controls.Add(this.lbl_LoggedInAsName);
            this.pHeader.Controls.Add(this.btn_SwitchInterface);
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
            // btn_SwitchInterface
            // 
            this.btn_SwitchInterface.BackColor = System.Drawing.Color.Teal;
            this.btn_SwitchInterface.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_SwitchInterface.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SwitchInterface.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_SwitchInterface.Location = new System.Drawing.Point(540, 21);
            this.btn_SwitchInterface.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SwitchInterface.Name = "btn_SwitchInterface";
            this.btn_SwitchInterface.Size = new System.Drawing.Size(97, 46);
            this.btn_SwitchInterface.TabIndex = 14;
            this.btn_SwitchInterface.Text = "SWITCH";
            this.btn_SwitchInterface.UseVisualStyleBackColor = false;
            this.btn_SwitchInterface.Click += new System.EventHandler(this.btn_SwitchInterface_Click);
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
            this.mtcStudent.Controls.Add(this.mtpMessages);
            this.mtcStudent.Controls.Add(this.mtpHouseRules);
            this.mtcStudent.Controls.Add(this.mtpAgreements);
            this.mtcStudent.Controls.Add(this.mtpProfile);
            this.mtcStudent.Controls.Add(this.metroTabPage1);
            this.mtcStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtcStudent.CustomBackground = true;
            this.mtcStudent.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.mtcStudent.ItemSize = new System.Drawing.Size(86, 35);
            this.mtcStudent.Location = new System.Drawing.Point(0, 106);
            this.mtcStudent.Name = "mtcStudent";
            this.mtcStudent.SelectedIndex = 2;
            this.mtcStudent.Size = new System.Drawing.Size(1054, 513);
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
            this.mtpSchedule.Controls.Add(this.btn_FilterSearch);
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
            this.mtpSchedule.CustomBackground = true;
            this.mtpSchedule.HorizontalScrollbarBarColor = true;
            this.mtpSchedule.ImeMode = System.Windows.Forms.ImeMode.On;
            this.mtpSchedule.Location = new System.Drawing.Point(4, 39);
            this.mtpSchedule.Name = "mtpSchedule";
            this.mtpSchedule.Size = new System.Drawing.Size(1046, 470);
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
            this.dgvSchedule.Size = new System.Drawing.Size(438, 362);
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
            // mtpMessages
            // 
            this.mtpMessages.Controls.Add(this.btnMessageAdd);
            this.mtpMessages.Controls.Add(this.tbxMessageDescription);
            this.mtpMessages.Controls.Add(this.cbxMessageType);
            this.mtpMessages.Controls.Add(this.label11);
            this.mtpMessages.Controls.Add(this.dgvMessageStudent);
            this.mtpMessages.Controls.Add(this.pbxAddMessage);
            this.mtpMessages.Controls.Add(this.pbxRemoveMessage);
            this.mtpMessages.Controls.Add(this.btnRemoveSelectedMessage);
            this.mtpMessages.HorizontalScrollbarBarColor = true;
            this.mtpMessages.Location = new System.Drawing.Point(4, 39);
            this.mtpMessages.Name = "mtpMessages";
            this.mtpMessages.Size = new System.Drawing.Size(1046, 470);
            this.mtpMessages.TabIndex = 3;
            this.mtpMessages.Text = "Complaints and Questions";
            this.mtpMessages.VerticalScrollbarBarColor = true;
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
            this.label11.Location = new System.Drawing.Point(4, 371);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 17);
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
            // mtpHouseRules
            // 
            this.mtpHouseRules.Controls.Add(this.dgvHouseRulesStudent);
            this.mtpHouseRules.HorizontalScrollbarBarColor = true;
            this.mtpHouseRules.Location = new System.Drawing.Point(4, 39);
            this.mtpHouseRules.Name = "mtpHouseRules";
            this.mtpHouseRules.Size = new System.Drawing.Size(1046, 470);
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
            this.mtpAgreements.Size = new System.Drawing.Size(1046, 470);
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
            this.label9.Location = new System.Drawing.Point(4, 344);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 17);
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
            listViewItem7,
            listViewItem8});
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
            // mtpProfile
            // 
            this.mtpProfile.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mtpProfile.Controls.Add(this.pbxDeposit);
            this.mtpProfile.Controls.Add(this.button3);
            this.mtpProfile.Controls.Add(this.textBox13);
            this.mtpProfile.Controls.Add(this.textBox1);
            this.mtpProfile.Controls.Add(this.textBox17);
            this.mtpProfile.Controls.Add(this.textBox15);
            this.mtpProfile.Controls.Add(this.label20);
            this.mtpProfile.Controls.Add(this.label10);
            this.mtpProfile.Controls.Add(this.button13);
            this.mtpProfile.Controls.Add(this.label26);
            this.mtpProfile.Controls.Add(this.label25);
            this.mtpProfile.Controls.Add(this.lv_MyTasks);
            this.mtpProfile.Controls.Add(this.textBox12);
            this.mtpProfile.Controls.Add(this.textBox11);
            this.mtpProfile.Controls.Add(this.textBox10);
            this.mtpProfile.Controls.Add(this.textBox9);
            this.mtpProfile.Controls.Add(this.textBox8);
            this.mtpProfile.Controls.Add(this.textBox7);
            this.mtpProfile.Controls.Add(this.label19);
            this.mtpProfile.Controls.Add(this.label18);
            this.mtpProfile.Controls.Add(this.label17);
            this.mtpProfile.Controls.Add(this.label16);
            this.mtpProfile.Controls.Add(this.label15);
            this.mtpProfile.Controls.Add(this.label14);
            this.mtpProfile.Controls.Add(this.label13);
            this.mtpProfile.Controls.Add(this.label12);
            this.mtpProfile.Controls.Add(this.pictureBox3);
            this.mtpProfile.HorizontalScrollbarBarColor = true;
            this.mtpProfile.Location = new System.Drawing.Point(4, 39);
            this.mtpProfile.Name = "mtpProfile";
            this.mtpProfile.Size = new System.Drawing.Size(1046, 470);
            this.mtpProfile.TabIndex = 4;
            this.mtpProfile.Text = "Profile";
            this.mtpProfile.VerticalScrollbarBarColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(289, 281);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(221, 45);
            this.button3.TabIndex = 68;
            this.button3.Text = "Complete Selected Task";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(25, 265);
            this.textBox13.Margin = new System.Windows.Forms.Padding(4);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(41, 22);
            this.textBox13.TabIndex = 67;
            this.textBox13.Text = "2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 112);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 22);
            this.textBox1.TabIndex = 65;
            this.textBox1.Text = "********";
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(289, 387);
            this.textBox17.Margin = new System.Windows.Forms.Padding(4);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(113, 22);
            this.textBox17.TabIndex = 62;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(73, 265);
            this.textBox15.Margin = new System.Windows.Forms.Padding(4);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(140, 22);
            this.textBox15.TabIndex = 60;
            this.textBox15.Text = "31";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label20.Location = new System.Drawing.Point(21, 245);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(40, 17);
            this.label20.TabIndex = 66;
            this.label20.Text = "Floor";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(22, 94);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 17);
            this.label10.TabIndex = 64;
            this.label10.Text = "Password";
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button13.Location = new System.Drawing.Point(410, 363);
            this.button13.Margin = new System.Windows.Forms.Padding(4);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(155, 46);
            this.button13.TabIndex = 63;
            this.button13.Text = "Deposit";
            this.button13.UseVisualStyleBackColor = false;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label26.Location = new System.Drawing.Point(286, 363);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(87, 17);
            this.label26.TabIndex = 61;
            this.label26.Text = "Add balance";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label25.Location = new System.Drawing.Point(69, 245);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(45, 17);
            this.label25.TabIndex = 59;
            this.label25.Text = "Room";
            // 
            // lv_MyTasks
            // 
            this.lv_MyTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Date,
            this.Task,
            this.columnHeader2});
            this.lv_MyTasks.HideSelection = false;
            this.lv_MyTasks.Location = new System.Drawing.Point(289, 35);
            this.lv_MyTasks.Margin = new System.Windows.Forms.Padding(4);
            this.lv_MyTasks.Name = "lv_MyTasks";
            this.lv_MyTasks.Size = new System.Drawing.Size(637, 232);
            this.lv_MyTasks.TabIndex = 58;
            this.lv_MyTasks.UseCompatibleStateImageBehavior = false;
            this.lv_MyTasks.View = System.Windows.Forms.View.Details;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 91;
            // 
            // Task
            // 
            this.Task.Text = "Task";
            this.Task.Width = 177;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Status";
            this.columnHeader2.Width = 93;
            // 
            // textBox12
            // 
            this.textBox12.Enabled = false;
            this.textBox12.Location = new System.Drawing.Point(25, 372);
            this.textBox12.Margin = new System.Windows.Forms.Padding(4);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(189, 22);
            this.textBox12.TabIndex = 57;
            this.textBox12.Text = "13";
            // 
            // textBox11
            // 
            this.textBox11.Enabled = false;
            this.textBox11.Location = new System.Drawing.Point(25, 314);
            this.textBox11.Margin = new System.Windows.Forms.Padding(4);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(189, 22);
            this.textBox11.TabIndex = 55;
            this.textBox11.Text = "€21.50";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(23, 214);
            this.textBox10.Margin = new System.Windows.Forms.Padding(4);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(189, 22);
            this.textBox10.TabIndex = 50;
            this.textBox10.Text = "+31 6 12345678";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(23, 163);
            this.textBox9.Margin = new System.Windows.Forms.Padding(4);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(189, 22);
            this.textBox9.TabIndex = 48;
            this.textBox9.Text = "p.young@fontys.nl";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(173, 62);
            this.textBox8.Margin = new System.Windows.Forms.Padding(4);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(40, 22);
            this.textBox8.TabIndex = 46;
            this.textBox8.Text = "21";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(23, 62);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(143, 22);
            this.textBox7.TabIndex = 44;
            this.textBox7.Text = "Peter Young";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label19.Location = new System.Drawing.Point(22, 346);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(114, 17);
            this.label19.TabIndex = 56;
            this.label19.Text = "Score this month";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label18.Location = new System.Drawing.Point(22, 296);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 17);
            this.label18.TabIndex = 54;
            this.label18.Text = "Balance";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label17.Location = new System.Drawing.Point(285, 11);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 17);
            this.label17.TabIndex = 52;
            this.label17.Text = "My tasks";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(21, 11);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(133, 17);
            this.label16.TabIndex = 51;
            this.label16.Text = "General Information";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(21, 196);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 17);
            this.label15.TabIndex = 49;
            this.label15.Text = "Phone";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(21, 144);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 17);
            this.label14.TabIndex = 47;
            this.label14.Text = "Email";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(170, 43);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 17);
            this.label13.TabIndex = 45;
            this.label13.Text = "Age";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(21, 42);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 17);
            this.label12.TabIndex = 43;
            this.label12.Text = "Name";
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroTabPage1.Controls.Add(this.flowLayoutPanel7);
            this.metroTabPage1.Controls.Add(this.flowLayoutPanel6);
            this.metroTabPage1.Controls.Add(this.flowLayoutPanel5);
            this.metroTabPage1.Controls.Add(this.flowLayoutPanel4);
            this.metroTabPage1.Controls.Add(this.flowLayoutPanel3);
            this.metroTabPage1.Controls.Add(this.flowLayoutPanel2);
            this.metroTabPage1.Controls.Add(this.flowLayoutPanel1);
            this.metroTabPage1.Controls.Add(this.panel1);
            this.metroTabPage1.Controls.Add(this.metroPanel1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1046, 470);
            this.metroTabPage1.TabIndex = 5;
            this.metroTabPage1.Text = "Whole schedule";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Location = new System.Drawing.Point(899, 98);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(148, 89);
            this.flowLayoutPanel7.TabIndex = 10;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Location = new System.Drawing.Point(749, 98);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(148, 89);
            this.flowLayoutPanel6.TabIndex = 9;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Location = new System.Drawing.Point(600, 98);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(148, 89);
            this.flowLayoutPanel5.TabIndex = 8;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Location = new System.Drawing.Point(450, 98);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(148, 89);
            this.flowLayoutPanel4.TabIndex = 7;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Location = new System.Drawing.Point(301, 98);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(148, 89);
            this.flowLayoutPanel3.TabIndex = 6;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(151, 98);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(148, 89);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label21);
            this.flowLayoutPanel1.Controls.Add(this.linkLabel1);
            this.flowLayoutPanel1.Controls.Add(this.linkLabel2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 98);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(148, 89);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // label21
            // 
            this.label21.Dock = System.Windows.Forms.DockStyle.Top;
            this.label21.Location = new System.Drawing.Point(3, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(145, 23);
            this.label21.TabIndex = 0;
            this.label21.Text = "1";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(3, 23);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(99, 17);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Appointment 1";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(3, 40);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(48, 17);
            this.linkLabel2.TabIndex = 2;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Friend";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1046, 31);
            this.panel1.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(895, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 31);
            this.label7.TabIndex = 10;
            this.label7.Text = "Saturday";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(749, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 31);
            this.label6.TabIndex = 9;
            this.label6.Text = "Firday";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(600, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "Thursday";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(151, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "Monday";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Aqua;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(302, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tuesday";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(451, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Wednesday";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sunday";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.metroPanel1.Controls.Add(this.lblDate);
            this.metroPanel1.Controls.Add(this.metroPanel2);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1046, 66);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(23, 14);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(224, 38);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "January, 2020";
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.btnNextMonth);
            this.metroPanel2.Controls.Add(this.btnPrevMonth);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(892, 0);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(154, 66);
            this.metroPanel2.TabIndex = 2;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // btnNextMonth
            // 
            this.btnNextMonth.Location = new System.Drawing.Point(87, 14);
            this.btnNextMonth.Name = "btnNextMonth";
            this.btnNextMonth.Size = new System.Drawing.Size(52, 39);
            this.btnNextMonth.TabIndex = 3;
            this.btnNextMonth.Text = ">";
            this.btnNextMonth.UseVisualStyleBackColor = true;
            // 
            // btnPrevMonth
            // 
            this.btnPrevMonth.Location = new System.Drawing.Point(17, 14);
            this.btnPrevMonth.Name = "btnPrevMonth";
            this.btnPrevMonth.Size = new System.Drawing.Size(52, 39);
            this.btnPrevMonth.TabIndex = 2;
            this.btnPrevMonth.Text = "<";
            this.btnPrevMonth.UseVisualStyleBackColor = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
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
            // pbxDeposit
            // 
            this.pbxDeposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.pbxDeposit.BackgroundImage = global::Project.Properties.Resources.banknotes_512;
            this.pbxDeposit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxDeposit.Location = new System.Drawing.Point(536, 372);
            this.pbxDeposit.Name = "pbxDeposit";
            this.pbxDeposit.Size = new System.Drawing.Size(22, 24);
            this.pbxDeposit.TabIndex = 2;
            this.pbxDeposit.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(253, 11);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1, 418);
            this.pictureBox3.TabIndex = 53;
            this.pictureBox3.TabStop = false;
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
            this.Load += new System.EventHandler(this.FrmStudent_Load);
            this.pHeader.ResumeLayout(false);
            this.pHeader.PerformLayout();
            this.mtcStudent.ResumeLayout(false);
            this.mtpSchedule.ResumeLayout(false);
            this.mtpSchedule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).EndInit();
            this.mtpMessages.ResumeLayout(false);
            this.mtpMessages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessageStudent)).EndInit();
            this.mtpHouseRules.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHouseRulesStudent)).EndInit();
            this.mtpAgreements.ResumeLayout(false);
            this.mtpAgreements.PerformLayout();
            this.mtpProfile.ResumeLayout(false);
            this.mtpProfile.PerformLayout();
            this.metroTabPage1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAddMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRemoveMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDeposit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_LoggedInAsPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pHeader;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Label lbl_LoggedInAsName;
        private System.Windows.Forms.Button btn_SwitchInterface;
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ListView lv_MyTasks;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Task;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnNextMonth;
        private System.Windows.Forms.Button btnPrevMonth;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btnMinimizeWindow;
        private System.Windows.Forms.PictureBox pbxDeposit;
        private System.Windows.Forms.PictureBox pbxAddMessage;
        private System.Windows.Forms.PictureBox pbxRemoveMessage;
    }
}