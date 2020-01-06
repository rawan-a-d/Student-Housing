using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Project
{
    public partial class FrmMain : Form
    {
        Student student;
        // Create instance of studentsHousing or use made instance
        StudentsHousing studentsHousing = StudentsHousing.Instance;
        HouseRule houseRule;

        public FrmMain()
        {
            InitializeComponent();

            // Call needed methods
            SetUp();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

            // Display today's date
            lblTodayDate.Text = (DateTime.Now.ToString("dd/MM/yyyy"));
        }

        private void Btn_SwitchInterface_Click(object sender, EventArgs e)
        {
            Form FormStudent = new FrmStudent();
            FormStudent.Show();
            this.Close();
        }

                                                                            /* Admin */

                                                                            // Tenants list page
        // Add student
        private void Btn_TenantAdd_Click(object sender, EventArgs e)
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
        private void Btn_TenantRemoveSelected_Click(object sender, EventArgs e)
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
        private void TbxTenantEmail_Validating(object sender, CancelEventArgs e)
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

        private void TbxTenantName_Validating(object sender, CancelEventArgs e)
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

        private void TbxTenantPassword_Validating(object sender, CancelEventArgs e)
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

        private void TbxTenantRoom_Validating(object sender, CancelEventArgs e)
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

        private void TbxTenantFloor_Validating(object sender, CancelEventArgs e)
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

                                                                              // House rules
        // Add house rule
        private void BtnAddRule_Click(object sender, EventArgs e)
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
        private void BtnRulesRemoveSelected_Click(object sender, EventArgs e)
        {
            // If no rule was selected
            if (dgvHouseRulesAdmin.SelectedCells.Count <= 0)
            {
                MessageBox.Show("Please select a rule to be removed");
            }
            else
            {
                int selectedRuleToBeRemoved = Convert.ToInt32(dgvHouseRulesAdmin.CurrentRow.Cells[0].Value);
                studentsHousing.RemoveHouseRuleById(selectedRuleToBeRemoved);

                MessageBox.Show("House Rule was successfully removed");

                // Update list view
                UpdateHouseRulesListView();
            }
        }

        // Modify house rule
        private void BtnRulesModifySelected_Click(object sender, EventArgs e)
        {
            string updatedRule = tbxNewRule.Text;

            // If no rule was selected
            if (dgvHouseRulesAdmin.SelectedCells.Count <= 0)
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
                int selectedRuleToBeModified = Convert.ToInt32(dgvHouseRulesAdmin.SelectedRows[0].Cells[0].Value);
                studentsHousing.ModifyHouseRuleById(selectedRuleToBeModified, updatedRule);

                MessageBox.Show("The selected rule was successfully modified");

                // Update list view
                UpdateHouseRulesListView();
            }
        }

        // Update List view (STUDENT and ADMIN)
        private void UpdateHouseRulesListView()
        {
            List<HouseRule> houseRules = studentsHousing.GetRulesList();

            // Clear list view
            dgvHouseRulesAdmin.Rows.Clear();
            // Display rules
            foreach (var rule in houseRules)
            {
                // Create new rows
                DataGridViewRow row = (DataGridViewRow)dgvHouseRulesAdmin.Rows[0].Clone();

                // Insert data into rows
                row.Cells[0].Value = rule.GetId().ToString();
                row.Cells[1].Value = (rule.GetDateCreated().ToString("dd/MM/yyyy")).ToString();
                row.Cells[2].Value = (rule.GetRule()).ToString();

                // Add the item to list view
                dgvHouseRulesAdmin.Rows.Add(row);

                // Text wrap
                dgvHouseRulesAdmin.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvHouseRulesAdmin.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
        }

                                                                        // Complaints and Questions
        // Reply to a message
        private void BtnSendReply_Click(object sender, EventArgs e)
        {
            string reply = tbxReply.Text;

            // If no reply was inserted
            if (tbxReply.Text == "")
            {
                MessageBox.Show("Please insert a reply");
            }
            // If no message was selected
            else if (dgvMessageAdmin.SelectedCells.Count <= 0)
            {
                MessageBox.Show("Please select a message");
            }
            else
            {
                int selectedMessageToReplyTo = Convert.ToInt32(dgvMessageAdmin.CurrentRow.Cells[0].Value);
                studentsHousing.SendReply(selectedMessageToReplyTo, reply);

                MessageBox.Show("Your reply was successfully sent");

                //Display messages in list view
                UpdateMessagesListView();
            }
        }

        // Export Messages as EXCEL
        private void BtnMessagesExport_Click(object sender, EventArgs e)
        {
            studentsHousing.ExportToExcel();
        }

        // Update List view (STUDENT and ADMIN)
        private void UpdateMessagesListView()
        {
            List<Message> messages = studentsHousing.GetMessagesList();

            // Clear list view
            dgvMessageAdmin.Rows.Clear();
            // Display rules
            foreach (var message in messages)
            {
                // Create new rows
                DataGridViewRow row = (DataGridViewRow)dgvMessageAdmin.Rows[0].Clone();

                // Insert data into rows
                row.Cells[0].Value = message.GetId().ToString();
                row.Cells[1].Value = (message.GetDateCreated().ToString("dd/MM/yyyy")).ToString();
                row.Cells[2].Value = (message.GetSubject()).ToString();
                row.Cells[3].Value = (message.GetMessage()).ToString();
                row.Cells[4].Value = (message.GetReply());

                // Add the item to list view
                dgvMessageAdmin.Rows.Add(row);

                // Text wrap
                dgvMessageAdmin.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvMessageAdmin.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
        }

        // Call needed methods
        public void SetUp()
        {
            // Display house rules
            UpdateHouseRulesListView();
            // Display student list
            UpdateStudentListView();
            // Display messages
            UpdateMessagesListView();
           
        }

        // Close window
        private void btnX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Minimize window
        private void btnMinimizeWindow_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
