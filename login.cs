using System;
using System.Windows.Forms;

namespace Project
{
    public partial class FrmLogin : Form
    {
        // Create instance of studentsHousing or use made instance
        StudentsHousing studentsHousing = StudentsHousing.Instance;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            mpsLogin.Visible = true;
            mpsLogin.Value = 0;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            mpsLogin.Value += 10;
            if (mpsLogin.Value == 100)
            {
                // Get login details
                string email = tbxLoginEmail.TextName;
                string password = tbxPassword.TextName;
                timer.Stop();
                if(studentsHousing.GetUserType(email) == "Student")
                {
                    if (studentsHousing.CheckCredentials("Student", email, password))
                    {
                        this.Hide();
                        Form FormStudent = new FrmStudent();

                        FormStudent.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Credentials are wrong");
                    }
                }
                else if(studentsHousing.GetUserType(email) == "Admin")
                {
                    if (studentsHousing.CheckCredentials("Admin",email, password))
                    {
                        this.Hide();
                        Form FormMain = new FrmMain();

                        FormMain.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Credentials are wrong");
                        mpsLogin.Value += 0;
                        mpsLogin.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("User does not exist"); mpsLogin.Value += 0;
                    mpsLogin.Visible = false;
                }
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            mpsLogin.Value += 0;
            mpsLogin.Visible = false;
        }

        private void BtnX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizeWindow_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
