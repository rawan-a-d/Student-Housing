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
        Student student;
        StudentsHousing studentsHousing = new StudentsHousing();



        private int counterId = 0;

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

            //lvwTenantList.Items.Add("Rawan");
            //lvwTenantList.Items.Add("Rawan");
            //lvwTenantList.Items.Add("Rawan");
            //lvwTenantList.Text = "Rawan";
            //lvwTenantList.Items.SubItems.Add("Rona");
            //lvwTenantList.Items[1].SubItems.Add("Omar");



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

                                                                            /* Admin */

                                                                            // Tenants list page
        // Add student
        private void btn_TenantAdd_Click(object sender, EventArgs e)
        {
            // Get student info
            string name = tbxTenantName.Text;
            string email = tbxTenantEmail.Text;
            string password = tbxTenantPassword.Text;
            string floorNr = tbxTenantFloor.Text;
            string roomNr = tbxTenantRoom.Text;

            bool formValidated = ValidateChildren(ValidationConstraints.Enabled);
            if (formValidated)
            {
                counterId++;
                // Initialize student object
                student = new Student();

                student.AddStudent(counterId, name, email, password, Convert.ToInt32(floorNr), Convert.ToInt32(roomNr));
                //Add student to list
                studentsHousing.AddStudentToList(student);

                MessageBox.Show("Student was successfully added");
                UpdateListView();
            }
        }

        // Remove student
        private void btn_TenantRemoveSelected_Click(object sender, EventArgs e)
        {
            int selectedUserToBeRemoved = Convert.ToInt32(lvwTenantList.SelectedItems[0].Text);

            studentsHousing.RemoveStudentById(selectedUserToBeRemoved);

            UpdateListView();
        }

        // Update List view
        private void UpdateListView()
        {
            List<Student> studentsList = studentsHousing.GetStudentsList();
            // Update list view
            lvwTenantList.Items.Clear();
            foreach (var student in studentsList)
            {
                // Create new row
                var row = new string[] { student.Id.ToString(), student.Name, student.Email, "", student.FloorNr.ToString(), student.RoomNr.ToString() };
                // Create new list view item
                ListViewItem lvwTenants = new ListViewItem(row);
                // Add the item to list view
                lvwTenantList.Items.Add(lvwTenants);
            }
        }

        // Fields validation
        private void tbxTenantEmail_Validating(object sender, CancelEventArgs e)
        {
            string email = tbxTenantEmail.Text;
            if (string.IsNullOrWhiteSpace(email))
            {
                e.Cancel = true;
                tbxTenantEmail.Focus();
                errorProvider.SetError(tbxTenantEmail, "You need to fill in the student's email address!");
            }
            // Confirm that there is an "@" and a "." in the email address, and in the correct order.
            else if (email.IndexOf("@") ==  -1)
            {
                e.Cancel = true;
                tbxTenantEmail.Focus();
                errorProvider.SetError(tbxTenantEmail, "Email must contain @ charachter");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tbxTenantEmail, "");
            }
        }

        private void tbxTenantName_Validating(object sender, CancelEventArgs e)
        {
            string name = tbxTenantName.Text;
            if (string.IsNullOrWhiteSpace(name))
            {
                e.Cancel = true;
                tbxTenantName.Focus();
                errorProvider.SetError(tbxTenantName, "You need to fill in the student's name!");
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(name, "^[a-zA-Z ]*$"))
            {
                e.Cancel = true;
                tbxTenantName.Focus();
                errorProvider.SetError(tbxTenantName, "Name can only contain alphabetical characters");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tbxTenantName, "");
            }
        }

        private void tbxTenantPassword_Validating(object sender, CancelEventArgs e)
        {
            string password = tbxTenantPassword.Text;
            if (string.IsNullOrWhiteSpace(password))
            {
                e.Cancel = true;
                tbxTenantPassword.Focus();
                errorProvider.SetError(tbxTenantPassword, "You need to fill in the student's password!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tbxTenantPassword, "");
            }
        }

        private void tbxTenantRoom_Validating_1(object sender, CancelEventArgs e)
        {
            string roomNr = tbxTenantRoom.Text;
            if (string.IsNullOrWhiteSpace(roomNr))
            {
                e.Cancel = true;
                tbxTenantRoom.Focus();
                errorProvider.SetError(tbxTenantRoom, "You need to fill in the student's room number!");
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(roomNr, "^[0-9]*$"))
            {
                e.Cancel = true;
                tbxTenantRoom.Focus();
                errorProvider.SetError(tbxTenantRoom, "Room number can only contain numbers");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tbxTenantRoom, "");
            }
        }

        private void tbxTenantFloor_Validating_1(object sender, CancelEventArgs e)
        {
            string floorNr = tbxTenantFloor.Text;
            if (string.IsNullOrWhiteSpace(floorNr))
            {
                e.Cancel = true;
                tbxTenantFloor.Focus();
                errorProvider.SetError(tbxTenantFloor, "You need to fill in the student's floor number!");
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(floorNr, "^[0-9]*$"))
            {
                e.Cancel = true;
                tbxTenantFloor.Focus();
                errorProvider.SetError(tbxTenantFloor, "Floor number can only contain numbers");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tbxTenantFloor, "");
            }
        }


    }
}
