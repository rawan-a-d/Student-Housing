namespace Project
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.pHeader = new System.Windows.Forms.Panel();
            this.btnMinimizeWindow = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.mpsLogin = new MetroFramework.Controls.MetroProgressSpinner();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tbxLoginName = new JMaterialTextbox.JMaterialTextbox();
            this.jMaterialTextbox1 = new JMaterialTextbox.JMaterialTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbxPassword = new System.Windows.Forms.PictureBox();
            this.pbxName = new System.Windows.Forms.PictureBox();
            this.btnLogin = new FlatButton.JFlatButton();
            this.pHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxName)).BeginInit();
            this.SuspendLayout();
            // 
            // pHeader
            // 
            this.pHeader.BackColor = System.Drawing.Color.Teal;
            this.pHeader.Controls.Add(this.btnMinimizeWindow);
            this.pHeader.Controls.Add(this.btnX);
            this.pHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHeader.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pHeader.Location = new System.Drawing.Point(0, 0);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(635, 51);
            this.pHeader.TabIndex = 44;
            // 
            // btnMinimizeWindow
            // 
            this.btnMinimizeWindow.BackColor = System.Drawing.Color.Teal;
            this.btnMinimizeWindow.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizeWindow.FlatAppearance.BorderSize = 0;
            this.btnMinimizeWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizeWindow.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizeWindow.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnMinimizeWindow.Location = new System.Drawing.Point(499, 0);
            this.btnMinimizeWindow.Name = "btnMinimizeWindow";
            this.btnMinimizeWindow.Size = new System.Drawing.Size(66, 51);
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
            this.btnX.Location = new System.Drawing.Point(565, 0);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(70, 51);
            this.btnX.TabIndex = 16;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.BtnX_Click);
            // 
            // timer
            // 
            this.timer.Interval = 300;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // mpsLogin
            // 
            this.mpsLogin.CustomBackground = true;
            this.mpsLogin.Location = new System.Drawing.Point(445, 383);
            this.mpsLogin.Maximum = 100;
            this.mpsLogin.Name = "mpsLogin";
            this.mpsLogin.Size = new System.Drawing.Size(52, 55);
            this.mpsLogin.Speed = 0.5F;
            this.mpsLogin.Style = MetroFramework.MetroColorStyle.Orange;
            this.mpsLogin.TabIndex = 45;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 51);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(265, 402);
            this.splitter1.TabIndex = 48;
            this.splitter1.TabStop = false;
            // 
            // tbxLoginName
            // 
            this.tbxLoginName.BackColor = System.Drawing.Color.Transparent;
            this.tbxLoginName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbxLoginName.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbxLoginName.ForeColors = System.Drawing.Color.Black;
            this.tbxLoginName.HintText = "Name";
            this.tbxLoginName.IsPassword = false;
            this.tbxLoginName.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbxLoginName.LineThickness = 2;
            this.tbxLoginName.Location = new System.Drawing.Point(335, 124);
            this.tbxLoginName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxLoginName.MaxLength = 32767;
            this.tbxLoginName.Name = "tbxLoginName";
            this.tbxLoginName.OnFocusedColor = System.Drawing.Color.DarkGray;
            this.tbxLoginName.OnFocusedTextColor = System.Drawing.Color.DarkGray;
            this.tbxLoginName.ReadOnly = false;
            this.tbxLoginName.Size = new System.Drawing.Size(274, 31);
            this.tbxLoginName.TabIndex = 50;
            this.tbxLoginName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxLoginName.TextName = "Name";
            // 
            // jMaterialTextbox1
            // 
            this.jMaterialTextbox1.BackColor = System.Drawing.Color.Transparent;
            this.jMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.jMaterialTextbox1.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.jMaterialTextbox1.ForeColors = System.Drawing.Color.Black;
            this.jMaterialTextbox1.HintText = "Password";
            this.jMaterialTextbox1.IsPassword = true;
            this.jMaterialTextbox1.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.jMaterialTextbox1.LineThickness = 2;
            this.jMaterialTextbox1.Location = new System.Drawing.Point(335, 228);
            this.jMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.jMaterialTextbox1.MaxLength = 32767;
            this.jMaterialTextbox1.Name = "jMaterialTextbox1";
            this.jMaterialTextbox1.OnFocusedColor = System.Drawing.Color.DarkGray;
            this.jMaterialTextbox1.OnFocusedTextColor = System.Drawing.Color.DarkGray;
            this.jMaterialTextbox1.ReadOnly = false;
            this.jMaterialTextbox1.Size = new System.Drawing.Size(274, 33);
            this.jMaterialTextbox1.TabIndex = 51;
            this.jMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.jMaterialTextbox1.TextName = "Password";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Project.Properties.Resources.bv_student_housing;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(12, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 369);
            this.panel1.TabIndex = 58;
            // 
            // pbxPassword
            // 
            this.pbxPassword.BackgroundImage = global::Project.Properties.Resources.iconfinder_icons_password_1564520;
            this.pbxPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxPassword.Location = new System.Drawing.Point(581, 217);
            this.pbxPassword.Name = "pbxPassword";
            this.pbxPassword.Size = new System.Drawing.Size(27, 31);
            this.pbxPassword.TabIndex = 56;
            this.pbxPassword.TabStop = false;
            // 
            // pbxName
            // 
            this.pbxName.BackgroundImage = global::Project.Properties.Resources.iconfinder_user_216498;
            this.pbxName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxName.Location = new System.Drawing.Point(581, 116);
            this.pbxName.Name = "pbxName";
            this.pbxName.Size = new System.Drawing.Size(27, 27);
            this.pbxName.TabIndex = 57;
            this.pbxName.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.btnLogin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.btnLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnLogin.ButtonText = "LOG IN";
            this.btnLogin.CausesValidation = false;
            this.btnLogin.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("btnLogin.ErrorImageLeft")));
            this.btnLogin.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("btnLogin.ErrorImageRight")));
            this.btnLogin.FocusBackground = System.Drawing.Color.Empty;
            this.btnLogin.FocusFontColor = System.Drawing.Color.Empty;
            this.btnLogin.ForeColors = System.Drawing.Color.White;
            this.btnLogin.HoverBackground = System.Drawing.Color.DarkGray;
            this.btnLogin.HoverFontColor = System.Drawing.Color.DimGray;
            this.btnLogin.ImageLeft = null;
            this.btnLogin.ImageRight = null;
            this.btnLogin.LeftPictureColor = System.Drawing.Color.Transparent;
            this.btnLogin.Location = new System.Drawing.Point(335, 310);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.btnLogin.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.btnLogin.RightPictureColor = System.Drawing.Color.Transparent;
            this.btnLogin.Size = new System.Drawing.Size(277, 53);
            this.btnLogin.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnLogin.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.btnLogin.TabIndex = 52;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(635, 453);
            this.Controls.Add(this.pbxPassword);
            this.Controls.Add(this.pbxName);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.jMaterialTextbox1);
            this.Controls.Add(this.tbxLoginName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.mpsLogin);
            this.Controls.Add(this.pHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.Text = "login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.pHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pHeader;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Timer timer;
        private MetroFramework.Controls.MetroProgressSpinner mpsLogin;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMinimizeWindow;
        private JMaterialTextbox.JMaterialTextbox tbxLoginName;
        private JMaterialTextbox.JMaterialTextbox jMaterialTextbox1;
        private FlatButton.JFlatButton btnLogin;
        private System.Windows.Forms.PictureBox pbxName;
        private System.Windows.Forms.PictureBox pbxPassword;
    }
}