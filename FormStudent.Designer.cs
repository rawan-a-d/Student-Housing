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
            this.pHeader = new System.Windows.Forms.Panel();
            this.btnMinimizeWindow = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.lbl_LoggedInAsName = new System.Windows.Forms.Label();
            this.lbl_LoggedInAsPicture = new System.Windows.Forms.PictureBox();
            this.lbl_LoggedInAs = new System.Windows.Forms.Label();
            this.mtcStudent = new MetroFramework.Controls.MetroTabControl();
            this.mtpSchedule = new MetroFramework.Controls.MetroTabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dvgPendingEvents = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_FilterAssignee = new System.Windows.Forms.ComboBox();
            this.cbx_FilterTasks = new System.Windows.Forms.CheckBox();
            this.cbx_FilterEvents = new System.Windows.Forms.CheckBox();
            this.lblAsignee = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.cb_CreateEventFloor = new System.Windows.Forms.ComboBox();
            this.label32 = new System.Windows.Forms.Label();
            this.tb_CreateEventLocation = new System.Windows.Forms.TextBox();
            this.dtpCreateEventDatePicker = new System.Windows.Forms.DateTimePicker();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblFloor = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_EventVoteSelectedNO = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_EventVoteSelectedYES = new System.Windows.Forms.Button();
            this.tb_CreateEventDescription = new System.Windows.Forms.TextBox();
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
            this.mtpAgreements = new MetroFramework.Controls.MetroTabPage();
            this.btn_AgreementRejectSelected = new System.Windows.Forms.Button();
            this.btn_AgreementDeleteSelected = new System.Windows.Forms.Button();
            this.btn_AgreementEditSelected = new System.Windows.Forms.Button();
            this.btn_AgreementAcceptSelected = new System.Windows.Forms.Button();
            this.cbx_AgreementPersonInvolved = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dgv_AgreementsStudent = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_NewAgreementSubmit = new System.Windows.Forms.Button();
            this.tb_NewAgreementDescription = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mtpHouseRules = new MetroFramework.Controls.MetroTabPage();
            this.dgvHouseRulesStudent = new System.Windows.Forms.DataGridView();
            this.chIdStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chDateStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chDescriptionStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.mtpGroceries = new MetroFramework.Controls.MetroTabPage();
            this.dgv_Groceries = new System.Windows.Forms.DataGridView();
            this.dgv_GroceriesHistory = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.nud_GroceryItemAmount = new System.Windows.Forms.NumericUpDown();
            this.tb_GroceryItem = new System.Windows.Forms.TextBox();
            this.btn_GroceryCompleteList = new System.Windows.Forms.Button();
            this.btn_GroceryRemoveItem = new System.Windows.Forms.Button();
            this.btn_GroceryAddItem = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_GroceryHistoryInfo = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_LoggedInAsPicture)).BeginInit();
            this.mtcStudent.SuspendLayout();
            this.mtpSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgPendingEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            this.mtpMessages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessageStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAddMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRemoveMessage)).BeginInit();
            this.mtpAgreements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AgreementsStudent)).BeginInit();
            this.mtpHouseRules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHouseRulesStudent)).BeginInit();
            this.mtpProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDeposit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.mtpGroceries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Groceries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GroceriesHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_GroceryItemAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
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
            this.pHeader.Margin = new System.Windows.Forms.Padding(2);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(789, 81);
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
            this.btnMinimizeWindow.Location = new System.Drawing.Point(664, 0);
            this.btnMinimizeWindow.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimizeWindow.Name = "btnMinimizeWindow";
            this.btnMinimizeWindow.Size = new System.Drawing.Size(64, 81);
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
            this.btnX.Location = new System.Drawing.Point(728, 0);
            this.btnX.Margin = new System.Windows.Forms.Padding(2);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(61, 81);
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
            this.btn_Logout.Location = new System.Drawing.Point(16, 20);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(75, 40);
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
            this.lbl_LoggedInAsName.Location = new System.Drawing.Point(142, 35);
            this.lbl_LoggedInAsName.Name = "lbl_LoggedInAsName";
            this.lbl_LoggedInAsName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_LoggedInAsName.Size = new System.Drawing.Size(124, 29);
            this.lbl_LoggedInAsName.TabIndex = 13;
            this.lbl_LoggedInAsName.Text = "Username";
            // 
            // lbl_LoggedInAsPicture
            // 
            this.lbl_LoggedInAsPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_LoggedInAsPicture.Image = ((System.Drawing.Image)(resources.GetObject("lbl_LoggedInAsPicture.Image")));
            this.lbl_LoggedInAsPicture.Location = new System.Drawing.Point(98, 20);
            this.lbl_LoggedInAsPicture.Name = "lbl_LoggedInAsPicture";
            this.lbl_LoggedInAsPicture.Size = new System.Drawing.Size(42, 40);
            this.lbl_LoggedInAsPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lbl_LoggedInAsPicture.TabIndex = 12;
            this.lbl_LoggedInAsPicture.TabStop = false;
            // 
            // lbl_LoggedInAs
            // 
            this.lbl_LoggedInAs.AutoSize = true;
            this.lbl_LoggedInAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LoggedInAs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_LoggedInAs.Location = new System.Drawing.Point(146, 19);
            this.lbl_LoggedInAs.Name = "lbl_LoggedInAs";
            this.lbl_LoggedInAs.Size = new System.Drawing.Size(121, 15);
            this.lbl_LoggedInAs.TabIndex = 11;
            this.lbl_LoggedInAs.Text = "Logged in as student";
            // 
            // mtcStudent
            // 
            this.mtcStudent.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.mtcStudent.Controls.Add(this.mtpSchedule);
            this.mtcStudent.Controls.Add(this.mtpMessages);
            this.mtcStudent.Controls.Add(this.mtpAgreements);
            this.mtcStudent.Controls.Add(this.mtpHouseRules);
            this.mtcStudent.Controls.Add(this.mtpProfile);
            this.mtcStudent.Controls.Add(this.mtpGroceries);
            this.mtcStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtcStudent.CustomBackground = true;
            this.mtcStudent.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.mtcStudent.ItemSize = new System.Drawing.Size(86, 35);
            this.mtcStudent.Location = new System.Drawing.Point(0, 80);
            this.mtcStudent.Margin = new System.Windows.Forms.Padding(2);
            this.mtcStudent.Name = "mtcStudent";
            this.mtcStudent.SelectedIndex = 5;
            this.mtcStudent.Size = new System.Drawing.Size(790, 423);
            this.mtcStudent.Style = MetroFramework.MetroColorStyle.Silver;
            this.mtcStudent.TabIndex = 44;
            this.mtcStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtcStudent.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtcStudent.UseStyleColors = true;
            // 
            // mtpSchedule
            // 
            this.mtpSchedule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mtpSchedule.Controls.Add(this.pictureBox1);
            this.mtpSchedule.Controls.Add(this.label13);
            this.mtpSchedule.Controls.Add(this.dvgPendingEvents);
            this.mtpSchedule.Controls.Add(this.label12);
            this.mtpSchedule.Controls.Add(this.label10);
            this.mtpSchedule.Controls.Add(this.cb_FilterAssignee);
            this.mtpSchedule.Controls.Add(this.cbx_FilterTasks);
            this.mtpSchedule.Controls.Add(this.cbx_FilterEvents);
            this.mtpSchedule.Controls.Add(this.lblAsignee);
            this.mtpSchedule.Controls.Add(this.label33);
            this.mtpSchedule.Controls.Add(this.cb_CreateEventFloor);
            this.mtpSchedule.Controls.Add(this.label32);
            this.mtpSchedule.Controls.Add(this.tb_CreateEventLocation);
            this.mtpSchedule.Controls.Add(this.dtpCreateEventDatePicker);
            this.mtpSchedule.Controls.Add(this.lblDateTime);
            this.mtpSchedule.Controls.Add(this.lblFloor);
            this.mtpSchedule.Controls.Add(this.pictureBox2);
            this.mtpSchedule.Controls.Add(this.btn_EventVoteSelectedNO);
            this.mtpSchedule.Controls.Add(this.label8);
            this.mtpSchedule.Controls.Add(this.btn_EventVoteSelectedYES);
            this.mtpSchedule.Controls.Add(this.tb_CreateEventDescription);
            this.mtpSchedule.Controls.Add(this.lblLocation);
            this.mtpSchedule.Controls.Add(this.btn_EventSendRequest);
            this.mtpSchedule.Controls.Add(this.lblCreateEvent);
            this.mtpSchedule.Controls.Add(this.lblFilter);
            this.mtpSchedule.Controls.Add(this.dgvSchedule);
            this.mtpSchedule.Controls.Add(this.btn_FilterSearch);
            this.mtpSchedule.CustomBackground = true;
            this.mtpSchedule.HorizontalScrollbarBarColor = true;
            this.mtpSchedule.HorizontalScrollbarSize = 8;
            this.mtpSchedule.ImeMode = System.Windows.Forms.ImeMode.On;
            this.mtpSchedule.Location = new System.Drawing.Point(4, 39);
            this.mtpSchedule.Margin = new System.Windows.Forms.Padding(2);
            this.mtpSchedule.Name = "mtpSchedule";
            this.mtpSchedule.Size = new System.Drawing.Size(782, 380);
            this.mtpSchedule.TabIndex = 0;
            this.mtpSchedule.Text = "Schedule";
            this.mtpSchedule.VerticalScrollbarBarColor = true;
            this.mtpSchedule.VerticalScrollbarSize = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(378, 187);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(399, 1);
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(378, 315);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 13);
            this.label13.TabIndex = 60;
            this.label13.Text = "Vote for selected event";
            // 
            // dvgPendingEvents
            // 
            this.dvgPendingEvents.AllowUserToDeleteRows = false;
            this.dvgPendingEvents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgPendingEvents.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dvgPendingEvents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dvgPendingEvents.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dvgPendingEvents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dvgPendingEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgPendingEvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dvgPendingEvents.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dvgPendingEvents.Location = new System.Drawing.Point(378, 211);
            this.dvgPendingEvents.Margin = new System.Windows.Forms.Padding(2);
            this.dvgPendingEvents.Name = "dvgPendingEvents";
            this.dvgPendingEvents.ReadOnly = true;
            this.dvgPendingEvents.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dvgPendingEvents.RowHeadersVisible = false;
            this.dvgPendingEvents.RowHeadersWidth = 51;
            this.dvgPendingEvents.RowTemplate.Height = 24;
            this.dvgPendingEvents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgPendingEvents.Size = new System.Drawing.Size(388, 98);
            this.dvgPendingEvents.TabIndex = 59;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 98.5759F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Organizer";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 91.37056F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Date";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 160.5232F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Description";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.FillWeight = 49.53037F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Votes";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(378, 196);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 13);
            this.label12.TabIndex = 58;
            this.label12.Text = "Pending Events";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(378, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 57;
            this.label10.Text = "Description";
            // 
            // cb_FilterAssignee
            // 
            this.cb_FilterAssignee.FormattingEnabled = true;
            this.cb_FilterAssignee.Location = new System.Drawing.Point(425, 27);
            this.cb_FilterAssignee.Name = "cb_FilterAssignee";
            this.cb_FilterAssignee.Size = new System.Drawing.Size(96, 21);
            this.cb_FilterAssignee.TabIndex = 56;
            // 
            // cbx_FilterTasks
            // 
            this.cbx_FilterTasks.AutoSize = true;
            this.cbx_FilterTasks.BackColor = System.Drawing.SystemColors.Control;
            this.cbx_FilterTasks.Location = new System.Drawing.Point(595, 30);
            this.cbx_FilterTasks.Name = "cbx_FilterTasks";
            this.cbx_FilterTasks.Size = new System.Drawing.Size(55, 17);
            this.cbx_FilterTasks.TabIndex = 55;
            this.cbx_FilterTasks.Text = "Tasks";
            this.cbx_FilterTasks.UseVisualStyleBackColor = false;
            // 
            // cbx_FilterEvents
            // 
            this.cbx_FilterEvents.AutoSize = true;
            this.cbx_FilterEvents.BackColor = System.Drawing.SystemColors.Control;
            this.cbx_FilterEvents.Location = new System.Drawing.Point(530, 30);
            this.cbx_FilterEvents.Name = "cbx_FilterEvents";
            this.cbx_FilterEvents.Size = new System.Drawing.Size(59, 17);
            this.cbx_FilterEvents.TabIndex = 54;
            this.cbx_FilterEvents.Text = "Events";
            this.cbx_FilterEvents.UseVisualStyleBackColor = false;
            // 
            // lblAsignee
            // 
            this.lblAsignee.AutoSize = true;
            this.lblAsignee.BackColor = System.Drawing.SystemColors.Control;
            this.lblAsignee.Location = new System.Drawing.Point(375, 29);
            this.lblAsignee.Name = "lblAsignee";
            this.lblAsignee.Size = new System.Drawing.Size(50, 13);
            this.lblAsignee.TabIndex = 53;
            this.lblAsignee.Text = "Assignee";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(553, 94);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(0, 13);
            this.label33.TabIndex = 51;
            // 
            // cb_CreateEventFloor
            // 
            this.cb_CreateEventFloor.FormattingEnabled = true;
            this.cb_CreateEventFloor.Location = new System.Drawing.Point(501, 109);
            this.cb_CreateEventFloor.Name = "cb_CreateEventFloor";
            this.cb_CreateEventFloor.Size = new System.Drawing.Size(56, 21);
            this.cb_CreateEventFloor.TabIndex = 50;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(615, 94);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(0, 13);
            this.label32.TabIndex = 49;
            // 
            // tb_CreateEventLocation
            // 
            this.tb_CreateEventLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CreateEventLocation.Location = new System.Drawing.Point(563, 109);
            this.tb_CreateEventLocation.Name = "tb_CreateEventLocation";
            this.tb_CreateEventLocation.Size = new System.Drawing.Size(115, 21);
            this.tb_CreateEventLocation.TabIndex = 48;
            // 
            // dtpCreateEventDatePicker
            // 
            this.dtpCreateEventDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCreateEventDatePicker.Location = new System.Drawing.Point(379, 109);
            this.dtpCreateEventDatePicker.Name = "dtpCreateEventDatePicker";
            this.dtpCreateEventDatePicker.Size = new System.Drawing.Size(116, 20);
            this.dtpCreateEventDatePicker.TabIndex = 47;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.BackColor = System.Drawing.SystemColors.Control;
            this.lblDateTime.Location = new System.Drawing.Point(378, 93);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(30, 13);
            this.lblDateTime.TabIndex = 46;
            this.lblDateTime.Text = "Date";
            // 
            // lblFloor
            // 
            this.lblFloor.AutoSize = true;
            this.lblFloor.BackColor = System.Drawing.SystemColors.Control;
            this.lblFloor.Location = new System.Drawing.Point(500, 92);
            this.lblFloor.Name = "lblFloor";
            this.lblFloor.Size = new System.Drawing.Size(30, 13);
            this.lblFloor.TabIndex = 45;
            this.lblFloor.Text = "Floor";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(378, 59);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(399, 1);
            this.pictureBox2.TabIndex = 44;
            this.pictureBox2.TabStop = false;
            // 
            // btn_EventVoteSelectedNO
            // 
            this.btn_EventVoteSelectedNO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.btn_EventVoteSelectedNO.FlatAppearance.BorderSize = 0;
            this.btn_EventVoteSelectedNO.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_EventVoteSelectedNO.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_EventVoteSelectedNO.Location = new System.Drawing.Point(456, 331);
            this.btn_EventVoteSelectedNO.Name = "btn_EventVoteSelectedNO";
            this.btn_EventVoteSelectedNO.Size = new System.Drawing.Size(65, 23);
            this.btn_EventVoteSelectedNO.TabIndex = 43;
            this.btn_EventVoteSelectedNO.Text = "NO";
            this.btn_EventVoteSelectedNO.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(218, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 42;
            // 
            // btn_EventVoteSelectedYES
            // 
            this.btn_EventVoteSelectedYES.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.btn_EventVoteSelectedYES.FlatAppearance.BorderSize = 0;
            this.btn_EventVoteSelectedYES.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_EventVoteSelectedYES.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_EventVoteSelectedYES.Location = new System.Drawing.Point(378, 331);
            this.btn_EventVoteSelectedYES.Name = "btn_EventVoteSelectedYES";
            this.btn_EventVoteSelectedYES.Size = new System.Drawing.Size(65, 23);
            this.btn_EventVoteSelectedYES.TabIndex = 41;
            this.btn_EventVoteSelectedYES.Text = "YES";
            this.btn_EventVoteSelectedYES.UseVisualStyleBackColor = false;
            // 
            // tb_CreateEventDescription
            // 
            this.tb_CreateEventDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CreateEventDescription.Location = new System.Drawing.Point(379, 154);
            this.tb_CreateEventDescription.Multiline = true;
            this.tb_CreateEventDescription.Name = "tb_CreateEventDescription";
            this.tb_CreateEventDescription.Size = new System.Drawing.Size(135, 21);
            this.tb_CreateEventDescription.TabIndex = 37;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.BackColor = System.Drawing.SystemColors.Control;
            this.lblLocation.Location = new System.Drawing.Point(561, 92);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(48, 13);
            this.lblLocation.TabIndex = 39;
            this.lblLocation.Text = "Location";
            // 
            // btn_EventSendRequest
            // 
            this.btn_EventSendRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.btn_EventSendRequest.FlatAppearance.BorderSize = 0;
            this.btn_EventSendRequest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_EventSendRequest.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_EventSendRequest.Location = new System.Drawing.Point(520, 154);
            this.btn_EventSendRequest.Name = "btn_EventSendRequest";
            this.btn_EventSendRequest.Size = new System.Drawing.Size(92, 21);
            this.btn_EventSendRequest.TabIndex = 38;
            this.btn_EventSendRequest.Text = "Send request";
            this.btn_EventSendRequest.UseVisualStyleBackColor = false;
            // 
            // lblCreateEvent
            // 
            this.lblCreateEvent.AutoSize = true;
            this.lblCreateEvent.BackColor = System.Drawing.SystemColors.Control;
            this.lblCreateEvent.Location = new System.Drawing.Point(378, 70);
            this.lblCreateEvent.Name = "lblCreateEvent";
            this.lblCreateEvent.Size = new System.Drawing.Size(68, 13);
            this.lblCreateEvent.TabIndex = 36;
            this.lblCreateEvent.Text = "Create event";
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.BackColor = System.Drawing.SystemColors.Control;
            this.lblFilter.Location = new System.Drawing.Point(375, 6);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(66, 13);
            this.lblFilter.TabIndex = 35;
            this.lblFilter.Text = "Filter options";
            // 
            // dgvSchedule
            // 
            this.dgvSchedule.AllowUserToDeleteRows = false;
            this.dgvSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSchedule.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSchedule.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSchedule.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSchedule.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chAsignee,
            this.chDate,
            this.chTask,
            this.chStatus});
            this.dgvSchedule.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSchedule.Location = new System.Drawing.Point(16, 9);
            this.dgvSchedule.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSchedule.Name = "dgvSchedule";
            this.dgvSchedule.ReadOnly = true;
            this.dgvSchedule.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSchedule.RowHeadersVisible = false;
            this.dgvSchedule.RowHeadersWidth = 51;
            this.dgvSchedule.RowTemplate.Height = 24;
            this.dgvSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSchedule.Size = new System.Drawing.Size(344, 344);
            this.dgvSchedule.TabIndex = 34;
            // 
            // chAsignee
            // 
            this.chAsignee.HeaderText = "Assignee";
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
            this.btn_FilterSearch.Location = new System.Drawing.Point(654, 22);
            this.btn_FilterSearch.Name = "btn_FilterSearch";
            this.btn_FilterSearch.Size = new System.Drawing.Size(104, 30);
            this.btn_FilterSearch.TabIndex = 52;
            this.btn_FilterSearch.Text = "Search";
            this.btn_FilterSearch.UseVisualStyleBackColor = false;
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
            this.mtpMessages.HorizontalScrollbarSize = 8;
            this.mtpMessages.Location = new System.Drawing.Point(4, 39);
            this.mtpMessages.Margin = new System.Windows.Forms.Padding(2);
            this.mtpMessages.Name = "mtpMessages";
            this.mtpMessages.Size = new System.Drawing.Size(782, 380);
            this.mtpMessages.TabIndex = 3;
            this.mtpMessages.Text = "Complaints and Questions";
            this.mtpMessages.VerticalScrollbarBarColor = true;
            this.mtpMessages.VerticalScrollbarSize = 8;
            // 
            // tbxMessageDescription
            // 
            this.tbxMessageDescription.Location = new System.Drawing.Point(140, 329);
            this.tbxMessageDescription.Multiline = true;
            this.tbxMessageDescription.Name = "tbxMessageDescription";
            this.tbxMessageDescription.Size = new System.Drawing.Size(530, 21);
            this.tbxMessageDescription.TabIndex = 12;
            // 
            // cbxMessageType
            // 
            this.cbxMessageType.FormattingEnabled = true;
            this.cbxMessageType.Items.AddRange(new object[] {
            "Question",
            "Complaint"});
            this.cbxMessageType.Location = new System.Drawing.Point(3, 329);
            this.cbxMessageType.Name = "cbxMessageType";
            this.cbxMessageType.Size = new System.Drawing.Size(132, 21);
            this.cbxMessageType.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 307);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 15);
            this.label11.TabIndex = 10;
            this.label11.Text = "Add a new message";
            // 
            // dgvMessageStudent
            // 
            this.dgvMessageStudent.AllowUserToDeleteRows = false;
            this.dgvMessageStudent.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvMessageStudent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            this.dgvMessageStudent.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMessageStudent.Name = "dgvMessageStudent";
            this.dgvMessageStudent.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMessageStudent.RowHeadersVisible = false;
            this.dgvMessageStudent.RowHeadersWidth = 51;
            this.dgvMessageStudent.RowTemplate.Height = 24;
            this.dgvMessageStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMessageStudent.Size = new System.Drawing.Size(778, 235);
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
            this.chMessagesDate.HeaderText = "Date";
            this.chMessagesDate.MinimumWidth = 6;
            this.chMessagesDate.Name = "chMessagesDate";
            this.chMessagesDate.Width = 90;
            // 
            // chMessageType
            // 
            this.chMessageType.HeaderText = "Type";
            this.chMessageType.MinimumWidth = 6;
            this.chMessageType.Name = "chMessageType";
            this.chMessageType.Width = 120;
            // 
            // chMessageText
            // 
            this.chMessageText.HeaderText = "Message";
            this.chMessageText.MinimumWidth = 6;
            this.chMessageText.Name = "chMessageText";
            this.chMessageText.Width = 280;
            // 
            // chMessageReply
            // 
            this.chMessageReply.HeaderText = "Reply";
            this.chMessageReply.MinimumWidth = 6;
            this.chMessageReply.Name = "chMessageReply";
            this.chMessageReply.Width = 234;
            // 
            // pbxAddMessage
            // 
            this.pbxAddMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.pbxAddMessage.BackgroundImage = global::Project.Properties.Resources.add_512;
            this.pbxAddMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxAddMessage.Location = new System.Drawing.Point(749, 319);
            this.pbxAddMessage.Margin = new System.Windows.Forms.Padding(2);
            this.pbxAddMessage.Name = "pbxAddMessage";
            this.pbxAddMessage.Size = new System.Drawing.Size(17, 20);
            this.pbxAddMessage.TabIndex = 17;
            this.pbxAddMessage.TabStop = false;
            // 
            // pbxRemoveMessage
            // 
            this.pbxRemoveMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.pbxRemoveMessage.BackgroundImage = global::Project.Properties.Resources.x_mark_4_512;
            this.pbxRemoveMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxRemoveMessage.Location = new System.Drawing.Point(150, 250);
            this.pbxRemoveMessage.Margin = new System.Windows.Forms.Padding(2);
            this.pbxRemoveMessage.Name = "pbxRemoveMessage";
            this.pbxRemoveMessage.Size = new System.Drawing.Size(15, 19);
            this.pbxRemoveMessage.TabIndex = 18;
            this.pbxRemoveMessage.TabStop = false;
            // 
            // btnRemoveSelectedMessage
            // 
            this.btnRemoveSelectedMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.btnRemoveSelectedMessage.FlatAppearance.BorderSize = 0;
            this.btnRemoveSelectedMessage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemoveSelectedMessage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemoveSelectedMessage.Location = new System.Drawing.Point(0, 240);
            this.btnRemoveSelectedMessage.Name = "btnRemoveSelectedMessage";
            this.btnRemoveSelectedMessage.Size = new System.Drawing.Size(177, 41);
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
            this.btnMessageAdd.Location = new System.Drawing.Point(676, 307);
            this.btnMessageAdd.Name = "btnMessageAdd";
            this.btnMessageAdd.Size = new System.Drawing.Size(102, 44);
            this.btnMessageAdd.TabIndex = 13;
            this.btnMessageAdd.Text = "Add";
            this.btnMessageAdd.UseVisualStyleBackColor = false;
            this.btnMessageAdd.Click += new System.EventHandler(this.BtnMessageAdd_Click);
            // 
            // mtpAgreements
            // 
            this.mtpAgreements.Controls.Add(this.btn_AgreementRejectSelected);
            this.mtpAgreements.Controls.Add(this.btn_AgreementDeleteSelected);
            this.mtpAgreements.Controls.Add(this.btn_AgreementEditSelected);
            this.mtpAgreements.Controls.Add(this.btn_AgreementAcceptSelected);
            this.mtpAgreements.Controls.Add(this.cbx_AgreementPersonInvolved);
            this.mtpAgreements.Controls.Add(this.label15);
            this.mtpAgreements.Controls.Add(this.label14);
            this.mtpAgreements.Controls.Add(this.dgv_AgreementsStudent);
            this.mtpAgreements.Controls.Add(this.btn_NewAgreementSubmit);
            this.mtpAgreements.Controls.Add(this.tb_NewAgreementDescription);
            this.mtpAgreements.Controls.Add(this.label9);
            this.mtpAgreements.HorizontalScrollbarBarColor = true;
            this.mtpAgreements.HorizontalScrollbarSize = 8;
            this.mtpAgreements.Location = new System.Drawing.Point(4, 39);
            this.mtpAgreements.Margin = new System.Windows.Forms.Padding(2);
            this.mtpAgreements.Name = "mtpAgreements";
            this.mtpAgreements.Size = new System.Drawing.Size(782, 380);
            this.mtpAgreements.TabIndex = 2;
            this.mtpAgreements.Text = "Agreements";
            this.mtpAgreements.VerticalScrollbarBarColor = true;
            this.mtpAgreements.VerticalScrollbarSize = 8;
            // 
            // btn_AgreementRejectSelected
            // 
            this.btn_AgreementRejectSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.btn_AgreementRejectSelected.FlatAppearance.BorderSize = 0;
            this.btn_AgreementRejectSelected.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AgreementRejectSelected.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_AgreementRejectSelected.Location = new System.Drawing.Point(483, 345);
            this.btn_AgreementRejectSelected.Name = "btn_AgreementRejectSelected";
            this.btn_AgreementRejectSelected.Size = new System.Drawing.Size(96, 21);
            this.btn_AgreementRejectSelected.TabIndex = 16;
            this.btn_AgreementRejectSelected.Text = "Reject Selected";
            this.btn_AgreementRejectSelected.UseVisualStyleBackColor = false;
            this.btn_AgreementRejectSelected.Click += new System.EventHandler(this.btn_AgreementRejectSelected_Click);
            // 
            // btn_AgreementDeleteSelected
            // 
            this.btn_AgreementDeleteSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.btn_AgreementDeleteSelected.FlatAppearance.BorderSize = 0;
            this.btn_AgreementDeleteSelected.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AgreementDeleteSelected.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_AgreementDeleteSelected.Location = new System.Drawing.Point(682, 345);
            this.btn_AgreementDeleteSelected.Name = "btn_AgreementDeleteSelected";
            this.btn_AgreementDeleteSelected.Size = new System.Drawing.Size(91, 21);
            this.btn_AgreementDeleteSelected.TabIndex = 15;
            this.btn_AgreementDeleteSelected.Text = "Delete Selected";
            this.btn_AgreementDeleteSelected.UseVisualStyleBackColor = false;
            this.btn_AgreementDeleteSelected.Click += new System.EventHandler(this.btn_AgreementDeleteSelected_Click);
            // 
            // btn_AgreementEditSelected
            // 
            this.btn_AgreementEditSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.btn_AgreementEditSelected.FlatAppearance.BorderSize = 0;
            this.btn_AgreementEditSelected.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AgreementEditSelected.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_AgreementEditSelected.Location = new System.Drawing.Point(585, 345);
            this.btn_AgreementEditSelected.Name = "btn_AgreementEditSelected";
            this.btn_AgreementEditSelected.Size = new System.Drawing.Size(91, 21);
            this.btn_AgreementEditSelected.TabIndex = 14;
            this.btn_AgreementEditSelected.Text = "Edit Selected";
            this.btn_AgreementEditSelected.UseVisualStyleBackColor = false;
            this.btn_AgreementEditSelected.Click += new System.EventHandler(this.btn_AgreementEditSelected_Click);
            // 
            // btn_AgreementAcceptSelected
            // 
            this.btn_AgreementAcceptSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.btn_AgreementAcceptSelected.FlatAppearance.BorderSize = 0;
            this.btn_AgreementAcceptSelected.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AgreementAcceptSelected.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_AgreementAcceptSelected.Location = new System.Drawing.Point(381, 345);
            this.btn_AgreementAcceptSelected.Name = "btn_AgreementAcceptSelected";
            this.btn_AgreementAcceptSelected.Size = new System.Drawing.Size(96, 21);
            this.btn_AgreementAcceptSelected.TabIndex = 13;
            this.btn_AgreementAcceptSelected.Text = "Accept Selected";
            this.btn_AgreementAcceptSelected.UseVisualStyleBackColor = false;
            this.btn_AgreementAcceptSelected.Click += new System.EventHandler(this.btn_AgreementAcceptSelected_Click);
            // 
            // cbx_AgreementPersonInvolved
            // 
            this.cbx_AgreementPersonInvolved.FormattingEnabled = true;
            this.cbx_AgreementPersonInvolved.Location = new System.Drawing.Point(171, 332);
            this.cbx_AgreementPersonInvolved.Name = "cbx_AgreementPersonInvolved";
            this.cbx_AgreementPersonInvolved.Size = new System.Drawing.Size(92, 21);
            this.cbx_AgreementPersonInvolved.TabIndex = 12;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(5, 334);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(166, 15);
            this.label15.TabIndex = 9;
            this.label15.Text = "Agreement between you and ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(5, 307);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 15);
            this.label14.TabIndex = 8;
            this.label14.Text = "Description:";
            // 
            // dgv_AgreementsStudent
            // 
            this.dgv_AgreementsStudent.AllowUserToDeleteRows = false;
            this.dgv_AgreementsStudent.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_AgreementsStudent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_AgreementsStudent.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_AgreementsStudent.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_AgreementsStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AgreementsStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgv_AgreementsStudent.Location = new System.Drawing.Point(8, 9);
            this.dgv_AgreementsStudent.Name = "dgv_AgreementsStudent";
            this.dgv_AgreementsStudent.ReadOnly = true;
            this.dgv_AgreementsStudent.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_AgreementsStudent.RowHeadersVisible = false;
            this.dgv_AgreementsStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_AgreementsStudent.Size = new System.Drawing.Size(765, 268);
            this.dgv_AgreementsStudent.TabIndex = 7;
            this.dgv_AgreementsStudent.CurrentCellChanged += new System.EventHandler(this.dgv_AgreementsStudent_CurrentCellChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 30;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Date";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Between";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 130;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Description";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 376;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Status";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 126;
            // 
            // btn_NewAgreementSubmit
            // 
            this.btn_NewAgreementSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.btn_NewAgreementSubmit.FlatAppearance.BorderSize = 0;
            this.btn_NewAgreementSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_NewAgreementSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_NewAgreementSubmit.Location = new System.Drawing.Point(269, 332);
            this.btn_NewAgreementSubmit.Name = "btn_NewAgreementSubmit";
            this.btn_NewAgreementSubmit.Size = new System.Drawing.Size(70, 21);
            this.btn_NewAgreementSubmit.TabIndex = 6;
            this.btn_NewAgreementSubmit.Text = "Submit";
            this.btn_NewAgreementSubmit.UseVisualStyleBackColor = false;
            this.btn_NewAgreementSubmit.Click += new System.EventHandler(this.btn_NewAgreementSubmit_Click);
            // 
            // tb_NewAgreementDescription
            // 
            this.tb_NewAgreementDescription.Location = new System.Drawing.Point(80, 306);
            this.tb_NewAgreementDescription.Name = "tb_NewAgreementDescription";
            this.tb_NewAgreementDescription.Size = new System.Drawing.Size(693, 20);
            this.tb_NewAgreementDescription.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 15);
            this.label9.TabIndex = 3;
            this.label9.Text = "Add new agreement";
            // 
            // mtpHouseRules
            // 
            this.mtpHouseRules.Controls.Add(this.dgvHouseRulesStudent);
            this.mtpHouseRules.HorizontalScrollbarBarColor = true;
            this.mtpHouseRules.HorizontalScrollbarSize = 8;
            this.mtpHouseRules.Location = new System.Drawing.Point(4, 39);
            this.mtpHouseRules.Margin = new System.Windows.Forms.Padding(2);
            this.mtpHouseRules.Name = "mtpHouseRules";
            this.mtpHouseRules.Size = new System.Drawing.Size(782, 380);
            this.mtpHouseRules.TabIndex = 1;
            this.mtpHouseRules.Text = "House Rules";
            this.mtpHouseRules.VerticalScrollbarBarColor = true;
            this.mtpHouseRules.VerticalScrollbarSize = 8;
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
            this.dgvHouseRulesStudent.Location = new System.Drawing.Point(7, 9);
            this.dgvHouseRulesStudent.Name = "dgvHouseRulesStudent";
            this.dgvHouseRulesStudent.RowHeadersVisible = false;
            this.dgvHouseRulesStudent.RowHeadersWidth = 51;
            this.dgvHouseRulesStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHouseRulesStudent.Size = new System.Drawing.Size(770, 357);
            this.dgvHouseRulesStudent.TabIndex = 9;
            // 
            // chIdStudent
            // 
            this.chIdStudent.HeaderText = "Id";
            this.chIdStudent.MinimumWidth = 6;
            this.chIdStudent.Name = "chIdStudent";
            this.chIdStudent.Width = 60;
            // 
            // chDateStudent
            // 
            this.chDateStudent.HeaderText = "Date Added";
            this.chDateStudent.MinimumWidth = 6;
            this.chDateStudent.Name = "chDateStudent";
            this.chDateStudent.Width = 110;
            // 
            // chDescriptionStudent
            // 
            this.chDescriptionStudent.HeaderText = "Description";
            this.chDescriptionStudent.MinimumWidth = 6;
            this.chDescriptionStudent.Name = "chDescriptionStudent";
            this.chDescriptionStudent.Width = 597;
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
            this.mtpProfile.HorizontalScrollbarSize = 8;
            this.mtpProfile.Location = new System.Drawing.Point(4, 39);
            this.mtpProfile.Margin = new System.Windows.Forms.Padding(2);
            this.mtpProfile.Name = "mtpProfile";
            this.mtpProfile.Size = new System.Drawing.Size(782, 380);
            this.mtpProfile.TabIndex = 4;
            this.mtpProfile.Text = "Profile";
            this.mtpProfile.VerticalScrollbarBarColor = true;
            this.mtpProfile.VerticalScrollbarSize = 8;
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
            this.dgvStudentTasks.Location = new System.Drawing.Point(216, 35);
            this.dgvStudentTasks.Margin = new System.Windows.Forms.Padding(2);
            this.dgvStudentTasks.Name = "dgvStudentTasks";
            this.dgvStudentTasks.RowHeadersVisible = false;
            this.dgvStudentTasks.RowHeadersWidth = 51;
            this.dgvStudentTasks.RowTemplate.Height = 24;
            this.dgvStudentTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudentTasks.Size = new System.Drawing.Size(516, 178);
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
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit.Location = new System.Drawing.Point(18, 339);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(84, 31);
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
            this.btnCompleteTask.Location = new System.Drawing.Point(217, 228);
            this.btnCompleteTask.Name = "btnCompleteTask";
            this.btnCompleteTask.Size = new System.Drawing.Size(166, 37);
            this.btnCompleteTask.TabIndex = 68;
            this.btnCompleteTask.Text = "Complete Selected Task";
            this.btnCompleteTask.UseVisualStyleBackColor = false;
            this.btnCompleteTask.Click += new System.EventHandler(this.btnCompleteTask_Click);
            // 
            // tbxFloor
            // 
            this.tbxFloor.Location = new System.Drawing.Point(19, 215);
            this.tbxFloor.Name = "tbxFloor";
            this.tbxFloor.ReadOnly = true;
            this.tbxFloor.Size = new System.Drawing.Size(32, 20);
            this.tbxFloor.TabIndex = 67;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(19, 91);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '*';
            this.tbxPassword.Size = new System.Drawing.Size(143, 20);
            this.tbxPassword.TabIndex = 65;
            // 
            // tbxAddBalance
            // 
            this.tbxAddBalance.Location = new System.Drawing.Point(217, 329);
            this.tbxAddBalance.Name = "tbxAddBalance";
            this.tbxAddBalance.Size = new System.Drawing.Size(72, 20);
            this.tbxAddBalance.TabIndex = 62;
            // 
            // tbxRoom
            // 
            this.tbxRoom.Location = new System.Drawing.Point(55, 215);
            this.tbxRoom.Name = "tbxRoom";
            this.tbxRoom.ReadOnly = true;
            this.tbxRoom.Size = new System.Drawing.Size(106, 20);
            this.tbxRoom.TabIndex = 60;
            // 
            // lblProfileFloor
            // 
            this.lblProfileFloor.AutoSize = true;
            this.lblProfileFloor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblProfileFloor.Location = new System.Drawing.Point(16, 199);
            this.lblProfileFloor.Name = "lblProfileFloor";
            this.lblProfileFloor.Size = new System.Drawing.Size(30, 13);
            this.lblProfileFloor.TabIndex = 66;
            this.lblProfileFloor.Text = "Floor";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPassword.Location = new System.Drawing.Point(16, 76);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 64;
            this.lblPassword.Text = "Password";
            // 
            // lblAddBalance
            // 
            this.lblAddBalance.AutoSize = true;
            this.lblAddBalance.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAddBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddBalance.Location = new System.Drawing.Point(214, 310);
            this.lblAddBalance.Name = "lblAddBalance";
            this.lblAddBalance.Size = new System.Drawing.Size(75, 15);
            this.lblAddBalance.TabIndex = 61;
            this.lblAddBalance.Text = "Add balance";
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRoom.Location = new System.Drawing.Point(52, 199);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(35, 13);
            this.lblRoom.TabIndex = 59;
            this.lblRoom.Text = "Room";
            // 
            // tbxScore
            // 
            this.tbxScore.Location = new System.Drawing.Point(19, 302);
            this.tbxScore.Name = "tbxScore";
            this.tbxScore.ReadOnly = true;
            this.tbxScore.Size = new System.Drawing.Size(143, 20);
            this.tbxScore.TabIndex = 57;
            // 
            // tbxBalance
            // 
            this.tbxBalance.Location = new System.Drawing.Point(19, 255);
            this.tbxBalance.Name = "tbxBalance";
            this.tbxBalance.ReadOnly = true;
            this.tbxBalance.Size = new System.Drawing.Size(143, 20);
            this.tbxBalance.TabIndex = 55;
            // 
            // tbxPhone
            // 
            this.tbxPhone.Location = new System.Drawing.Point(17, 174);
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.Size = new System.Drawing.Size(143, 20);
            this.tbxPhone.TabIndex = 50;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(17, 132);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(143, 20);
            this.tbxEmail.TabIndex = 48;
            // 
            // tbxAge
            // 
            this.tbxAge.Location = new System.Drawing.Point(130, 50);
            this.tbxAge.Name = "tbxAge";
            this.tbxAge.Size = new System.Drawing.Size(31, 20);
            this.tbxAge.TabIndex = 46;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(17, 50);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(108, 20);
            this.tbxName.TabIndex = 44;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblScore.Location = new System.Drawing.Point(16, 281);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(86, 13);
            this.lblScore.TabIndex = 56;
            this.lblScore.Text = "Score this month";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBalance.Location = new System.Drawing.Point(16, 240);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(46, 13);
            this.lblBalance.TabIndex = 54;
            this.lblBalance.Text = "Balance";
            // 
            // lblMyTasks
            // 
            this.lblMyTasks.AutoSize = true;
            this.lblMyTasks.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMyTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyTasks.Location = new System.Drawing.Point(214, 9);
            this.lblMyTasks.Name = "lblMyTasks";
            this.lblMyTasks.Size = new System.Drawing.Size(63, 17);
            this.lblMyTasks.TabIndex = 52;
            this.lblMyTasks.Text = "My tasks";
            // 
            // lblGeneralInfo
            // 
            this.lblGeneralInfo.AutoSize = true;
            this.lblGeneralInfo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGeneralInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneralInfo.Location = new System.Drawing.Point(16, 9);
            this.lblGeneralInfo.Name = "lblGeneralInfo";
            this.lblGeneralInfo.Size = new System.Drawing.Size(133, 17);
            this.lblGeneralInfo.TabIndex = 51;
            this.lblGeneralInfo.Text = "General Information";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPhone.Location = new System.Drawing.Point(16, 159);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(38, 13);
            this.lblPhone.TabIndex = 49;
            this.lblPhone.Text = "Phone";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEmail.Location = new System.Drawing.Point(16, 117);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 47;
            this.lblEmail.Text = "Email";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAge.Location = new System.Drawing.Point(128, 35);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(26, 13);
            this.lblAge.TabIndex = 45;
            this.lblAge.Text = "Age";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblName.Location = new System.Drawing.Point(16, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 43;
            this.lblName.Text = "Name";
            // 
            // pbxDeposit
            // 
            this.pbxDeposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.pbxDeposit.BackgroundImage = global::Project.Properties.Resources.banknotes_512;
            this.pbxDeposit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxDeposit.Location = new System.Drawing.Point(384, 320);
            this.pbxDeposit.Margin = new System.Windows.Forms.Padding(2);
            this.pbxDeposit.Name = "pbxDeposit";
            this.pbxDeposit.Size = new System.Drawing.Size(16, 20);
            this.pbxDeposit.TabIndex = 2;
            this.pbxDeposit.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(190, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1, 340);
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
            this.btnDeposit.Location = new System.Drawing.Point(296, 312);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(116, 37);
            this.btnDeposit.TabIndex = 63;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // mtpGroceries
            // 
            this.mtpGroceries.Controls.Add(this.btn_GroceryHistoryInfo);
            this.mtpGroceries.Controls.Add(this.pictureBox6);
            this.mtpGroceries.Controls.Add(this.pictureBox5);
            this.mtpGroceries.Controls.Add(this.pictureBox4);
            this.mtpGroceries.Controls.Add(this.btn_GroceryAddItem);
            this.mtpGroceries.Controls.Add(this.btn_GroceryRemoveItem);
            this.mtpGroceries.Controls.Add(this.btn_GroceryCompleteList);
            this.mtpGroceries.Controls.Add(this.tb_GroceryItem);
            this.mtpGroceries.Controls.Add(this.nud_GroceryItemAmount);
            this.mtpGroceries.Controls.Add(this.label19);
            this.mtpGroceries.Controls.Add(this.label18);
            this.mtpGroceries.Controls.Add(this.label17);
            this.mtpGroceries.Controls.Add(this.label16);
            this.mtpGroceries.Controls.Add(this.dgv_GroceriesHistory);
            this.mtpGroceries.Controls.Add(this.dgv_Groceries);
            this.mtpGroceries.HorizontalScrollbarBarColor = true;
            this.mtpGroceries.Location = new System.Drawing.Point(4, 39);
            this.mtpGroceries.Name = "mtpGroceries";
            this.mtpGroceries.Size = new System.Drawing.Size(782, 380);
            this.mtpGroceries.TabIndex = 6;
            this.mtpGroceries.Text = "Groceries";
            this.mtpGroceries.VerticalScrollbarBarColor = true;
            // 
            // dgv_Groceries
            // 
            this.dgv_Groceries.AllowUserToDeleteRows = false;
            this.dgv_Groceries.AllowUserToResizeRows = false;
            this.dgv_Groceries.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_Groceries.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Groceries.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_Groceries.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Groceries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Groceries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgv_Groceries.Location = new System.Drawing.Point(16, 17);
            this.dgv_Groceries.Name = "dgv_Groceries";
            this.dgv_Groceries.ReadOnly = true;
            this.dgv_Groceries.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Groceries.RowHeadersVisible = false;
            this.dgv_Groceries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Groceries.Size = new System.Drawing.Size(332, 302);
            this.dgv_Groceries.TabIndex = 2;
            // 
            // dgv_GroceriesHistory
            // 
            this.dgv_GroceriesHistory.AllowUserToDeleteRows = false;
            this.dgv_GroceriesHistory.AllowUserToResizeRows = false;
            this.dgv_GroceriesHistory.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_GroceriesHistory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_GroceriesHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_GroceriesHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_GroceriesHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_GroceriesHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dgv_GroceriesHistory.Location = new System.Drawing.Point(367, 172);
            this.dgv_GroceriesHistory.Name = "dgv_GroceriesHistory";
            this.dgv_GroceriesHistory.ReadOnly = true;
            this.dgv_GroceriesHistory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_GroceriesHistory.RowHeadersVisible = false;
            this.dgv_GroceriesHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_GroceriesHistory.Size = new System.Drawing.Size(253, 188);
            this.dgv_GroceriesHistory.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(365, 156);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(180, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "Previous students who did groceries:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label17.Location = new System.Drawing.Point(363, 17);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(125, 13);
            this.label17.TabIndex = 5;
            this.label17.Text = "Add a new item to the list";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label18.Location = new System.Drawing.Point(365, 43);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 13);
            this.label18.TabIndex = 6;
            this.label18.Text = "Amount";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label19.Location = new System.Drawing.Point(414, 43);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(27, 13);
            this.label19.TabIndex = 7;
            this.label19.Text = "Item";
            // 
            // nud_GroceryItemAmount
            // 
            this.nud_GroceryItemAmount.Location = new System.Drawing.Point(366, 60);
            this.nud_GroceryItemAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_GroceryItemAmount.Name = "nud_GroceryItemAmount";
            this.nud_GroceryItemAmount.Size = new System.Drawing.Size(40, 20);
            this.nud_GroceryItemAmount.TabIndex = 8;
            this.nud_GroceryItemAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_GroceryItemAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tb_GroceryItem
            // 
            this.tb_GroceryItem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_GroceryItem.Location = new System.Drawing.Point(417, 60);
            this.tb_GroceryItem.Name = "tb_GroceryItem";
            this.tb_GroceryItem.Size = new System.Drawing.Size(141, 20);
            this.tb_GroceryItem.TabIndex = 9;
            // 
            // btn_GroceryCompleteList
            // 
            this.btn_GroceryCompleteList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.btn_GroceryCompleteList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_GroceryCompleteList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_GroceryCompleteList.Location = new System.Drawing.Point(148, 325);
            this.btn_GroceryCompleteList.Name = "btn_GroceryCompleteList";
            this.btn_GroceryCompleteList.Size = new System.Drawing.Size(200, 35);
            this.btn_GroceryCompleteList.TabIndex = 10;
            this.btn_GroceryCompleteList.Text = "Mark grocery list as complete     ";
            this.btn_GroceryCompleteList.UseVisualStyleBackColor = false;
            this.btn_GroceryCompleteList.Click += new System.EventHandler(this.btn_GroceryCompleteList_Click);
            // 
            // btn_GroceryRemoveItem
            // 
            this.btn_GroceryRemoveItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.btn_GroceryRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_GroceryRemoveItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_GroceryRemoveItem.Location = new System.Drawing.Point(16, 325);
            this.btn_GroceryRemoveItem.Name = "btn_GroceryRemoveItem";
            this.btn_GroceryRemoveItem.Size = new System.Drawing.Size(120, 35);
            this.btn_GroceryRemoveItem.TabIndex = 12;
            this.btn_GroceryRemoveItem.Text = "Remove item     ";
            this.btn_GroceryRemoveItem.UseVisualStyleBackColor = false;
            this.btn_GroceryRemoveItem.Click += new System.EventHandler(this.btn_GroceryRemoveItem_Click);
            // 
            // btn_GroceryAddItem
            // 
            this.btn_GroceryAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.btn_GroceryAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_GroceryAddItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_GroceryAddItem.Location = new System.Drawing.Point(366, 87);
            this.btn_GroceryAddItem.Name = "btn_GroceryAddItem";
            this.btn_GroceryAddItem.Size = new System.Drawing.Size(99, 35);
            this.btn_GroceryAddItem.TabIndex = 13;
            this.btn_GroceryAddItem.Text = "Add item      ";
            this.btn_GroceryAddItem.UseVisualStyleBackColor = false;
            this.btn_GroceryAddItem.Click += new System.EventHandler(this.btn_GroceryAddItem_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.pictureBox4.BackgroundImage = global::Project.Properties.Resources.x_mark_4_512;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(105, 334);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(18, 18);
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.pictureBox5.BackgroundImage = global::Project.Properties.Resources.add_512;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(432, 96);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(18, 18);
            this.pictureBox5.TabIndex = 15;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.pictureBox6.BackgroundImage = global::Project.Properties.Resources.edit_8_512;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(314, 334);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(18, 18);
            this.pictureBox6.TabIndex = 16;
            this.pictureBox6.TabStop = false;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "ID";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 35;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Amount";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 51;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Item(s)";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 156;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Added by";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 87;
            // 
            // btn_GroceryHistoryInfo
            // 
            this.btn_GroceryHistoryInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.btn_GroceryHistoryInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_GroceryHistoryInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_GroceryHistoryInfo.Location = new System.Drawing.Point(627, 325);
            this.btn_GroceryHistoryInfo.Name = "btn_GroceryHistoryInfo";
            this.btn_GroceryHistoryInfo.Size = new System.Drawing.Size(94, 35);
            this.btn_GroceryHistoryInfo.TabIndex = 17;
            this.btn_GroceryHistoryInfo.Text = "Info Selected";
            this.btn_GroceryHistoryInfo.UseVisualStyleBackColor = false;
            this.btn_GroceryHistoryInfo.Click += new System.EventHandler(this.btn_GroceryHistoryInfo_Click);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 35;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Date";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 120;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Student";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 95;
            // 
            // FrmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 497);
            this.Controls.Add(this.mtcStudent);
            this.Controls.Add(this.pHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmStudent";
            this.Text = "Student";
            this.pHeader.ResumeLayout(false);
            this.pHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_LoggedInAsPicture)).EndInit();
            this.mtcStudent.ResumeLayout(false);
            this.mtpSchedule.ResumeLayout(false);
            this.mtpSchedule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgPendingEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).EndInit();
            this.mtpMessages.ResumeLayout(false);
            this.mtpMessages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessageStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAddMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRemoveMessage)).EndInit();
            this.mtpAgreements.ResumeLayout(false);
            this.mtpAgreements.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AgreementsStudent)).EndInit();
            this.mtpHouseRules.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHouseRulesStudent)).EndInit();
            this.mtpProfile.ResumeLayout(false);
            this.mtpProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentTasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDeposit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.mtpGroceries.ResumeLayout(false);
            this.mtpGroceries.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Groceries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GroceriesHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_GroceryItemAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
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
        private System.Windows.Forms.ComboBox cb_CreateEventFloor;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox tb_CreateEventLocation;
        private System.Windows.Forms.DateTimePicker dtpCreateEventDatePicker;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblFloor;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_EventVoteSelectedNO;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_EventVoteSelectedYES;
        private System.Windows.Forms.TextBox tb_CreateEventDescription;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Button btn_EventSendRequest;
        private System.Windows.Forms.Label lblCreateEvent;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.DataGridView dgvSchedule;
        private MetroFramework.Controls.MetroTabPage mtpHouseRules;
        private System.Windows.Forms.DataGridView dgvHouseRulesStudent;
        private MetroFramework.Controls.MetroTabPage mtpAgreements;
        private System.Windows.Forms.Button btn_NewAgreementSubmit;
        private System.Windows.Forms.TextBox tb_NewAgreementDescription;
        private System.Windows.Forms.Label label9;
        private MetroFramework.Controls.MetroTabPage mtpMessages;
        private System.Windows.Forms.Button btnMessageAdd;
        private System.Windows.Forms.TextBox tbxMessageDescription;
        private System.Windows.Forms.ComboBox cbxMessageType;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnRemoveSelectedMessage;
        private System.Windows.Forms.DataGridView dgvMessageStudent;
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
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dvgPendingEvents;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn chAsignee;
        private System.Windows.Forms.DataGridViewTextBoxColumn chDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn chTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn chStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn chIdStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn chDateStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn chDescriptionStudent;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgv_AgreementsStudent;
        private System.Windows.Forms.ComboBox cbx_AgreementPersonInvolved;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn chMessagesId;
        private System.Windows.Forms.DataGridViewTextBoxColumn chMessagesDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn chMessageType;
        private System.Windows.Forms.DataGridViewTextBoxColumn chMessageText;
        private System.Windows.Forms.DataGridViewTextBoxColumn chMessageReply;
        private System.Windows.Forms.Button btn_AgreementEditSelected;
        private System.Windows.Forms.Button btn_AgreementAcceptSelected;
        private System.Windows.Forms.Button btn_AgreementDeleteSelected;
        private System.Windows.Forms.Button btn_AgreementRejectSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private MetroFramework.Controls.MetroTabPage mtpGroceries;
        private System.Windows.Forms.DataGridView dgv_Groceries;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dgv_GroceriesHistory;
        private System.Windows.Forms.TextBox tb_GroceryItem;
        private System.Windows.Forms.NumericUpDown nud_GroceryItemAmount;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btn_GroceryCompleteList;
        private System.Windows.Forms.Button btn_GroceryRemoveItem;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btn_GroceryAddItem;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Button btn_GroceryHistoryInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}