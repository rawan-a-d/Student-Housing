using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        int nextTab = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabs_Student.Visible = false;
            tabs_Admin.Visible = false;
            lbl_TodayDate.Visible = false;
            lbl_LoggedInAsPicture.Visible = false;
            lbl_LoggedInAsName.Visible = false;
            lbl_LoggedInAs.Visible = false;
            btn_Logout.Visible = false;
        }

        private void Btn_SwitchInterface_Click(object sender, EventArgs e)
        {
            // default (0) is login screen.
            if (nextTab == 2) // switch to administrator
            {
                //nextTab = 0;
                tabs_Student.Visible = false;
                tabs_Admin.Visible = false;
                lbl_TodayDate.Visible = false;
                lbl_LoggedInAsPicture.Visible = false;
                lbl_LoggedInAsName.Visible = false;
                lbl_LoggedInAs.Visible = false;
                btn_Logout.Visible = false;

                lbl_LoginEmail.Visible = true;
                tb_LoginEmail.Visible = true;
                lbl_LoginPassword.Visible = true;
                tb_LoginPassword.Visible = true;
                btn_Login.Visible = true;
            }

            if (nextTab == 1) // switch to administrator
            {
                //nextTab = 2;
                tabs_Student.Visible = false;
                tabs_Admin.Visible = true;
                lbl_LoggedInAsName.Text = "Administrator";
                lbl_TodayDate.Visible = true;
                lbl_LoggedInAsPicture.Visible = true;
                lbl_LoggedInAsName.Visible = true;
                lbl_LoggedInAs.Visible = true;
                btn_Logout.Visible = true;

                lbl_LoginEmail.Visible = false;
                tb_LoginEmail.Visible = false;
                lbl_LoginPassword.Visible = false;
                tb_LoginPassword.Visible = false;
                btn_Login.Visible = false;
            }

            if (nextTab == 0) // switch to student
            {
                //nextTab = 1;
                lbl_LoggedInAsName.Text = "Peter Young";
                tabs_Student.Visible = true;
                tabs_Admin.Visible = false;
                lbl_TodayDate.Visible = true;
                lbl_LoggedInAsPicture.Visible = true;
                lbl_LoggedInAsName.Visible = true;
                lbl_LoggedInAs.Visible = true;
                btn_Logout.Visible = true;

                lbl_LoginEmail.Visible = false;
                tb_LoginEmail.Visible = false;
                lbl_LoginPassword.Visible = false;
                tb_LoginPassword.Visible = false;
                btn_Login.Visible = false;
            }
            nextTab++;
            if (nextTab == 3)
            {
                nextTab = 0;
            }
        }
    }
}
