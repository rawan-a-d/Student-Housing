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

            // Call needed methods
            SetUp();
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

            // Display today's date
            lblTodayDate.Text = (DateTime.Now.ToString("dd/MM/yyyy"));

            //DTP_EventDateTime.CustomFormat = "MMMM dd, yyyy -- HH:mm";
        }

        private void Btn_SwitchInterface_Click(object sender, EventArgs e)
        {
            // default (0) is login screen.
            if (nextTab == 2) // switch to default
            {
                //nextTab = 0;
                tabs_Student.Visible = false;
                tabs_Admin.Visible = false;
                lblTodayDate.Visible = false;
                lbl_LoggedInAsPicture.Visible = false;
                lbl_LoggedInAsName.Visible = false;
                lbl_LoggedInAs.Visible = false;
                btn_Logout.Visible = false;

                pLogin.Visible = true;
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

                pLogin.Visible = false;
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

        private void tbxTenantRoom_Validating(object sender, CancelEventArgs e)
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

        private void tbxTenantFloor_Validating(object sender, CancelEventArgs e)
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
        private void btnRulesModifySelected_Click(object sender, EventArgs e)
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
            dgvHouseRulesStudent.Rows.Clear();
            // Display rules
            foreach (var rule in houseRules)
            {
                // Create new rows
                DataGridViewRow row = (DataGridViewRow)dgvHouseRulesAdmin.Rows[0].Clone();
                DataGridViewRow rowStudent = (DataGridViewRow)dgvHouseRulesStudent.Rows[0].Clone();

                // Insert data into rows
                row.Cells[0].Value = rule.GetId().ToString();
                row.Cells[1].Value = (rule.GetDateCreated().ToString("dd/MM/yyyy")).ToString();
                row.Cells[2].Value = (rule.GetRule()).ToString();
                rowStudent.Cells[0].Value = rule.GetId().ToString();
                rowStudent.Cells[1].Value = (rule.GetDateCreated().ToString("dd/MM/yyyy")).ToString();
                rowStudent.Cells[2].Value = (rule.GetRule()).ToString();

                // Add the item to list view
                dgvHouseRulesAdmin.Rows.Add(row);
                dgvHouseRulesStudent.Rows.Add(rowStudent);

                // Text wrap
                dgvHouseRulesAdmin.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvHouseRulesAdmin.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgvHouseRulesStudent.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvHouseRulesStudent.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
        }

                                                                        // Complaints and Questions
        // Reply to a message
        private void btnSendReply_Click(object sender, EventArgs e)
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
        private void btnMessagesExport_Click(object sender, EventArgs e)
        {
            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exported from gridview";
            // storing header part in Excel  
            for (int i = 1; i < dgvMessageAdmin.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dgvMessageAdmin.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dgvMessageAdmin.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dgvMessageAdmin.Columns.Count; j++)
                {
                    if (dgvMessageAdmin.Rows[i].Cells[j].Value != null)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgvMessageAdmin.Rows[i].Cells[j].Value.ToString();
                    }
                    else
                    {
                        worksheet.Cells[i + 2, j + 1] = "";
                    }
                }
            }

            // AutoSet Cell Widths to Content Size
            worksheet.Cells.Select();
            worksheet.Cells.EntireColumn.AutoFit();
            // Style cells
            worksheet.Cells.Borders.Color = Color.LightBlue;
            worksheet.Cells.Range["A:E"].Interior.Color = Color.GhostWhite;
            worksheet.Cells.Range["A1:E1"].Interior.Color = Color.SteelBlue;
            worksheet.Cells.Range["A1:E1"].Font.Bold = true;
            worksheet.Cells.Range["A1:E1"].Font.Color = Color.White;
        }

        // Update List view (STUDENT and ADMIN)
        private void UpdateMessagesListView()
        {
            List<Message> messages = studentsHousing.GetMessagesList();

            // Clear list view
            dgvMessageAdmin.Rows.Clear();
            dgvMessageStudent.Rows.Clear();
            // Display rules
            foreach (var message in messages)
            {
                // Create new rows
                DataGridViewRow row = (DataGridViewRow)dgvMessageAdmin.Rows[0].Clone();
                DataGridViewRow rowStudent = (DataGridViewRow)dgvMessageStudent.Rows[0].Clone();

                // Insert data into rows
                row.Cells[0].Value = message.GetId().ToString();
                row.Cells[1].Value = (message.GetDateCreated().ToString("dd/MM/yyyy")).ToString();
                row.Cells[2].Value = (message.GetSubject()).ToString();
                row.Cells[3].Value = (message.GetMessage()).ToString();
                row.Cells[4].Value = (message.GetReply());
                rowStudent.Cells[0].Value = message.GetId().ToString();
                rowStudent.Cells[1].Value = (message.GetDateCreated().ToString("dd/MM/yyyy")).ToString();
                rowStudent.Cells[2].Value = (message.GetSubject()).ToString();
                rowStudent.Cells[3].Value = (message.GetMessage()).ToString();
                rowStudent.Cells[4].Value = (message.GetReply());

                // Add the item to list view
                dgvMessageAdmin.Rows.Add(row);
                dgvMessageStudent.Rows.Add(rowStudent);

                // Text wrap
                dgvMessageAdmin.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvMessageAdmin.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgvMessageStudent.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvMessageStudent.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
        }


                                                                            /* Student */
                                                                            // Complaints and Questions
        // Send message
        private void btnMessageAdd_Click(object sender, EventArgs e)
        {
            // Get message data
            MessageSubject messageType = (MessageSubject)cbxMessageType.SelectedIndex;
            string messageDesc = tbxMessageDescription.Text;
            DateTime currentDate = DateTime.Now;
            /////////// For now let's say it's user with Id 1/ until we implement login functionality //////////////
            int currentStudentId = 1;
            if (cbxMessageType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a subject");
            }
            else if (messageDesc == "")
            {
                MessageBox.Show("Please insert your message");
            }
            else
            {
                message = new Message(currentDate, messageType, messageDesc, currentStudentId);

                // Add message to list
                studentsHousing.AddMessageToList(message);

                MessageBox.Show("Your message was successfully sent");

                //Display messages in list view
                UpdateMessagesListView();
            }
        }

        // Remove selected message
        private void btnRemoveSelectedMessage_Click(object sender, EventArgs e)
        {
            // if no message was selected
            if (dgvMessageStudent.SelectedCells.Count <= 0)
            {
                MessageBox.Show("Please select a message to be removed");
            }
            else
            {
                int selectedMessageToRemove = Convert.ToInt32(dgvMessageStudent.CurrentRow.Cells[0].Value);

                studentsHousing.RemoveMessageById(selectedMessageToRemove);

                MessageBox.Show("Your message was successfully removed");

                //Display messages in list view
                UpdateMessagesListView();
            }
        }

                                                                                // Schedule
        public void UpdateScheduleList()
        {
            // Schedule list
            List<Schedule> schedules = studentsHousing.GetSchedulesList().OrderBy(o => o.GetDateId()).ToList();

            // Clear list view
            dgvSchedule.Rows.Clear();
            // Display rules
            foreach (var schedule in schedules)
            {
                // Create new rows
                DataGridViewRow row = (DataGridViewRow)dgvSchedule.Rows[0].Clone();

                // Insert data into rows
                row.Cells[0].Value = (studentsHousing.FindStudentById(schedule.GetStudentId())).ToString();
                row.Cells[1].Value = (studentsHousing.FindDateById(schedule.GetDateId())).ToString("dd/MM/yyyy");
                row.Cells[2].Value = (schedule.GetTask()).ToString();
                row.Cells[3].Value = (schedule.GetStatus()).ToString();

                // Add the item to list view
                dgvSchedule.Rows.Add(row);

                // Text wrap
                dgvSchedule.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvSchedule.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
        }

        // Call needed methods
        public void SetUp()
        {
            // Add test data here
            studentsHousing.GenerateTestDate();

            // Add dates and create schedule
            studentsHousing.AddDates();
            studentsHousing.CreateSchedule();
            UpdateScheduleList();

            // Display house rules
            UpdateHouseRulesListView();
            // Display student list
            UpdateStudentListView();
            // Display messages
            UpdateMessagesListView();
        }
    }
}
