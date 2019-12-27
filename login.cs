using System;
using System.Windows.Forms;

namespace Project
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            mpsLogin.Visible = true;
            mpsLogin.Value = 0;
            timer.Start();
            //Form FormMain = new FrmMain();
            //FormMain.Show();
            //this.Close();
        }

        private void BtnX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
                mpsLogin.Value += 10;
                if (mpsLogin.Value == 100)
                {
                    timer.Stop();
                    using (Form FormMain = new FrmMain())
                    {
                        FormMain.ShowDialog();
                        this.Hide();
                    }

                }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            mpsLogin.Value += 0;
            mpsLogin.Visible = false;
        }

        private void btnMinimizeWindow_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
