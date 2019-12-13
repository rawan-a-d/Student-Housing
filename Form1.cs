using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace Project
{
    public partial class Form1 : Form
    {
        Student student;
        StudentsHousing studentsHousing = new StudentsHousing();
        HouseRule houseRule;
        Message message;

        int nextTab = 0;
        public Form1()
        {
            InitializeComponent();
            // Add test data here
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabs_Student.Visible = false;
            tabs_Admin.Visible = false;
            lblTodayDate.Visible = false;
            lbl_LoggedInAsPicture.Visible = false;
            lbl_LoggedInAsName.Visible = false;
            lbl_LoggedInAs.Visible = false;
            btn_Logout.Visible = false;

            // Display house rules
            UpdateHouseRulesListView();
            // Display student list
            UpdateStudentListView();
            // Display messages
            UpdateMessagesListView();

            // Display today's date
            lblTodayDate.Text = (DateTime.Now.ToString("dd/MM/yyyy"));
        }

        private void Btn_SwitchInterface_Click(object sender, EventArgs e)
        {
            // default (0) is login screen.
            if (nextTab == 2) // switch to administrator
            {
                //nextTab = 0;
                tabs_Student.Visible = false;
                tabs_Admin.Visible = false;
                lblTodayDate.Visible = false;
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
                lblTodayDate.Visible = true;
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
                lblTodayDate.Visible = true;
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
                // Initialize student object
                student = new Student(name, email, password, Convert.ToInt32(floorNr), Convert.ToInt32(roomNr));

                //Add student to list
                studentsHousing.AddStudentToList(student);

                MessageBox.Show("Student was successfully added");
                UpdateStudentListView();
            }
        }

        // Remove student
        private void btn_TenantRemoveSelected_Click(object sender, EventArgs e)
        {
            int selectedUserToBeRemoved = Convert.ToInt32(lvwTenantList.SelectedItems[0].Text);

            studentsHousing.RemoveStudentById(selectedUserToBeRemoved);

            UpdateStudentListView();
        }

        // Update List view
        private void UpdateStudentListView()
        {
            List<Student> studentsList = studentsHousing.GetStudentsList();
            // Update list view
            lvwTenantList.Items.Clear();
            foreach (var student in studentsList)
            {
                // Create new row
                var row = new string[] { student.GetId().ToString(), student.GetName(), student.GetEmail(), "", student.GetFloorNr().ToString(), student.GetRoomNr().ToString() };
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

        // Add house rule
        private void btnAddRule_Click(object sender, EventArgs e)
        {
            string newRule = tbxNewRule.Text;
            DateTime currentDate = DateTime.Now;

            if (newRule != "")
            {
                houseRule = new HouseRule(currentDate, newRule);

                // Add rule to list
                studentsHousing.AddHouseRuleToList(houseRule);

                MessageBox.Show("House Rule was successfully added");

                // Update list view
                UpdateHouseRulesListView();
            }

            else
            {
                MessageBox.Show("Please insert a new rule");
            }

        }

        // Remove house rule
        private void btnRulesRemoveSelected_Click(object sender, EventArgs e)
        {
            // If no rule was selected
            if (lvwHouseRulesAdmin.SelectedIndices.Count <= 0)
            {
                MessageBox.Show("Please select a rule to be removed");
            }
            else
            {
                int selectedRuleToBeRemoved = Convert.ToInt32(lvwHouseRulesAdmin.SelectedItems[0].Text);
                studentsHousing.RemoveHouseRuleById(selectedRuleToBeRemoved);

                // Update list view
                UpdateHouseRulesListView();
            }
        }

        // Modify house rule
        private void btnRulesModifySelected_Click(object sender, EventArgs e)
        {
            string updatedRule = tbxNewRule.Text;

            // If no rule was selected
            if (lvwHouseRulesAdmin.SelectedIndices.Count <= 0)
            {
                MessageBox.Show("Please select a rule to be modified");
            }
            // If nothing was inserted
            else if (updatedRule == "")
            {
                MessageBox.Show("Please insert the modified rule");
            }
            else
            {
                int selectedRuleToBeModified = Convert.ToInt32(lvwHouseRulesAdmin.SelectedItems[0].Text);
                studentsHousing.ModifyHouseRuleById(selectedRuleToBeModified, updatedRule);

                // Update list view
                UpdateHouseRulesListView();
            }
        }

        // Update List view (STUDENT and ADMIN)
        private void UpdateHouseRulesListView()
        {
            List<HouseRule> houseRules = studentsHousing.GetRulesList();

            // Clear list view
            lvwHouseRulesAdmin.Items.Clear();
            lvwHouseRulesStudent.Items.Clear();
            // Display rules
            foreach (var rule in houseRules)
            {
                // Create new row
                var row = new string[] { rule.GetId().ToString(), (rule.GetDateCreated()).ToString(), rule.GetRule() };
                var rowStudent = new string[] {(rule.GetDateCreated()).ToString(), rule.GetRule() };
                // Create new list view item
                ListViewItem lvwRuleAdmin = new ListViewItem(row);
                ListViewItem lvwRuleStudent = new ListViewItem(rowStudent);
                // Add the item to list view
                lvwHouseRulesAdmin.Items.Add(lvwRuleAdmin);
                lvwHouseRulesStudent.Items.Add(lvwRuleStudent);
            }
        }

                                                                                /* Student */
                                                                                // Complaints and Questions
        // Send message
        private void btnMessageAdd_Click(object sender, EventArgs e)
        {
            MessageSubject messageType = (MessageSubject)cbxMessageType.SelectedIndex;
            string messageDesc = tbxMessageDescription.Text;
            DateTime currentDate = DateTime.Now;
            /////////// For now let's say it's user with Id 1/ until we implement login functionality //////////////
            int currentStudentId = 1;

            message = new Message(currentDate, messageType, messageDesc, currentStudentId);

            // Add message to list
            studentsHousing.AddMessageToList(message);

            MessageBox.Show("Your message was successfully sent");

            //Display messages in list view
            UpdateMessagesListView();
        }

        // Remove selected message
        private void btnRemoveSelectedMessage_Click(object sender, EventArgs e)
        {
            // if no message was selected
            if (lvwMessagesStudent.SelectedIndices.Count <= 0)
            {
                MessageBox.Show("Please select a message to be removed");
            }
            else
            {
                int selectedMessageToRemove = Convert.ToInt32(lvwMessagesStudent.SelectedItems[0].Text);

                studentsHousing.RemoveMessageById(selectedMessageToRemove);

                MessageBox.Show("Your message was successfully removed");

                //Display messages in list view
                UpdateMessagesListView();
            }
        }


                                                                                    /* Admin */
        private void btnSendReply_Click(object sender, EventArgs e)
        {
            string reply = tbxReply.Text;

            // If no reply was inserted
            if (tbxReply.Text == "")
            {
                MessageBox.Show("Please insert a reply");
            }
            // If no message was selected
            else if (lvwMessagesAdmin.SelectedIndices.Count <= 0)
            {
                MessageBox.Show("Please select a message");
            }
            else
            {
                int selectedMessageToReplyTo = Convert.ToInt32(lvwMessagesAdmin.SelectedItems[0].Text);
                message.UpdateReply(selectedMessageToReplyTo, reply);

                MessageBox.Show("Your reply was successfully sent");

                //Display messages in list view
                UpdateMessagesListView();
            }
        }

        // Export Messages as EXCEL
        private void btnMessagesExport_Click(object sender, EventArgs e)
        {

        }


        // Update List view (STUDENT and ADMIN)
        private void UpdateMessagesListView()
        {
            List<Message> messages = studentsHousing.GetMessagesList();

            /////////// Show messages based on the current Student Id ///////////////

            // Clear list view
            lvwMessagesAdmin.Items.Clear();
            lvwMessagesStudent.Items.Clear();
            // Display rules
            foreach (var message in messages)
            {
                // Create new row
                var row = new string[]
                {
                    message.GetId().ToString(), (message.GetDateCreated()).ToString(), message.GetSubject().ToString(),
                    message.GetMessage(), message.GetReply()
                };
                var rowStudent = new string[]
                {
                    message.GetId().ToString(), (message.GetDateCreated()).ToString(), message.GetSubject().ToString(),
                    message.GetMessage(), message.GetReply()
                };
                // Create new list view item
                ListViewItem lvwMessageAdmin = new ListViewItem(row);
                ListViewItem lvwMessageStudent = new ListViewItem(rowStudent);
                // Add the item to list view
                lvwMessagesAdmin.Items.Add(lvwMessageAdmin);
                lvwMessagesStudent.Items.Add(lvwMessageStudent);
            }
        }
    }
}
