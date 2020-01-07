using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Project
{
    public partial class FrmStudent : Form
    {
        // Create instance of studentsHousing or use made instance
        StudentsHousing studentsHousing = StudentsHousing.Instance;
        Student currentUser;
        public FrmStudent()
        {
            InitializeComponent();

            currentUser = studentsHousing.GetCurrentStudent();

            // Create schedule if it wasn't created
            if (studentsHousing.GetSchedulesList().Count == 0)
            {
                studentsHousing.AddDates();
                studentsHousing.CreateSchedule();
                UpdateScheduleList();
            }
            else
            {
                UpdateScheduleList();
            }

            // Call needed methods
            SetUp();
        }


                                                            /* Complaints and Questions */
        // Send message
        private void BtnMessageAdd_Click(object sender, EventArgs e)
        {
            // Get message data
            MessageSubject messageType = (MessageSubject)cbxMessageType.SelectedIndex;
            string messageDesc = tbxMessageDescription.Text;
            DateTime currentDate = DateTime.Now;
 
            int currentStudentId = currentUser.Id;
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
                // Create Message
                studentsHousing.CreateMessage(currentDate, messageType, messageDesc, currentStudentId);

                MessageBox.Show("Your message was successfully sent");

                //Display messages in list view
                UpdateMessagesListView();
            }
        }

        // Remove selected message
        private void BtnRemoveSelectedMessage_Click(object sender, EventArgs e)
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

        // Update Messages List view (STUDENT)
        private void UpdateMessagesListView()
        {
            List<Message> messages = studentsHousing.GetMessagesList();

            // Clear list view
            dgvMessageStudent.Rows.Clear();
            // Display rules
            foreach (var message in messages)
            {
                // Create new rows
                DataGridViewRow rowStudent = (DataGridViewRow)dgvMessageStudent.Rows[0].Clone();

                // Insert data into rows
                rowStudent.Cells[0].Value = message.Id.ToString();
                rowStudent.Cells[1].Value = (message.DateCreated.ToString("dd/MM/yyyy")).ToString();
                rowStudent.Cells[2].Value = (message.Subject).ToString();
                rowStudent.Cells[3].Value = (message.MessageText).ToString();
                rowStudent.Cells[4].Value = (message.Reply);

                // Add the item to list view
                dgvMessageStudent.Rows.Add(rowStudent);

                // Text wrap
                dgvMessageStudent.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvMessageStudent.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
        }


                                                                            /* House Rules */
        // Update House Rules List view (STUDENT and ADMIN)
        private void UpdateHouseRulesListView()
        {
            List<HouseRule> houseRules = studentsHousing.GetRulesList();

            // Clear list view
            dgvHouseRulesStudent.Rows.Clear();
            // Display rules
            foreach (var rule in houseRules)
            {
                // Create new rows
                DataGridViewRow rowStudent = (DataGridViewRow)dgvHouseRulesStudent.Rows[0].Clone();

                // Insert data into rows
                rowStudent.Cells[0].Value = rule.Id.ToString();
                rowStudent.Cells[1].Value = (rule.DateCreated.ToString("dd/MM/yyyy")).ToString();
                rowStudent.Cells[2].Value = (rule.Rule).ToString();

                // Add the item to list view
                dgvHouseRulesStudent.Rows.Add(rowStudent);

                // Text wrap
                dgvHouseRulesStudent.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvHouseRulesStudent.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
        }


                                                                                /* Schedule */
        public void UpdateScheduleList()
        {
            // Schedule list
            List<Schedule> schedules = studentsHousing.GetSchedulesList().OrderBy(o => o.DateId).ToList();

            // Clear list view
            dgvSchedule.Rows.Clear();
            // Display rules
            foreach (var schedule in schedules)
            {
                // Create new rows
                DataGridViewRow row = (DataGridViewRow)dgvSchedule.Rows[0].Clone();

                // Insert data into rows
                row.Cells[0].Value = studentsHousing.FindStudentById(schedule.StudentId).ToString();
                row.Cells[1].Value = studentsHousing.FindDateById(schedule.DateId).ToString("dd/MM/yyyy");
                row.Cells[2].Value = (schedule.TaskType).ToString();
                row.Cells[3].Value = (schedule.Status).ToString();

                // Add the item to list view
                dgvSchedule.Rows.Add(row);

                // Text wrap
                dgvSchedule.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvSchedule.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
        }


                                                                            /* Profile */
        public void DisplayProfileInfo()
        {
            int currentUserId = currentUser.Id;
            tbxName.Text = currentUser.Name;
            if (currentUser.Age != 0)
            {
                tbxAge.Text = currentUser.Age.ToString();
            }
            tbxPassword.Text = currentUser.Password;
            tbxEmail.Text = currentUser.Email;
            tbxFloor.Text = currentUser.FloorNr.ToString();
            tbxRoom.Text = currentUser.RoomNr.ToString();
            tbxBalance.Text = currentUser.Balance.ToString();
            tbxScore.Text = currentUser.Score.ToString();
            tbxPhone.Text = currentUser.PhoneNumber;

            if (studentsHousing.CompareScores())
            {
                tbxScore.Text += " WOW, the highest score";
                //tbxScore.Enabled = true;
                tbxScore.BackColor = Color.White;
                tbxScore.ForeColor = Color.Orange;
            }

            // Student schedule
            GetScheduleCurrentUser();
        }

        // Update student's tasks in profile
        public void GetScheduleCurrentUser()
        {
            int currentUserId = currentUser.Id;
            // Schedule list
            List<Schedule> schedules = studentsHousing.GetSchedulesList().OrderBy(o => o.DateId).ToList();

            // Clear list view
            dgvStudentTasks.Rows.Clear();
            // Display rules
            foreach (var schedule in schedules)
            {
                if(schedule.StudentId == currentUserId)
                {
                    // Create new rows
                    DataGridViewRow row = (DataGridViewRow)dgvStudentTasks.Rows[0].Clone();

                    // Insert data into rows
                    row.Cells[0].Value = studentsHousing.FindDateById(schedule.DateId);
                    row.Cells[1].Value = (schedule.TaskType).ToString();
                    row.Cells[2].Value = (schedule.Status).ToString();

                    // Add the item to list view
                    dgvStudentTasks.Rows.Add(row);

                    // Text wrap
                    dgvStudentTasks.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    dgvStudentTasks.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                }
            }
        }

        // Complete task
        private void btnCompleteTask_Click(object sender, EventArgs e)
        {
            DialogResult confirmDialog = MessageBox.Show("Are you sure you want to complete this task?", "Complete task", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // if no task was selected
            if (dgvStudentTasks.SelectedCells.Count <= 0)
            {
                MessageBox.Show("Please select the task that you completed");
            }
            // If task status is Pending
            else if(dgvStudentTasks.CurrentRow.Cells[2].Value.ToString() == "Pending")
            {
                // If the student confirmed the completion of task
                if (confirmDialog == DialogResult.Yes)
                {
                    DateTime selectedTaskDate = Convert.ToDateTime(dgvStudentTasks.CurrentRow.Cells[0].Value);

                    int currentUserId = currentUser.Id;
                    studentsHousing.CompleteTask(currentUserId, selectedTaskDate);

                    // Update profile info
                    DisplayProfileInfo();

                    // Update all schedules in schedule page
                    UpdateScheduleList();
                }
                else
                {
                    MessageBox.Show("Task was not completed", "Complete task", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("The task you selected is already completed");
            }
        }

        // Edit profile info
        private void btnEdit_Click(object sender, EventArgs e)
        {
            int currentUserId = currentUser.Id;
            string name = tbxName.Text;
            string age = tbxAge.Text;
            string password = tbxPassword.Text;
            string email = tbxEmail.Text;
            string phone = tbxPhone.Text;
            studentsHousing.UpdateStudentInfo(currentUserId, name, Convert.ToInt32(age), email, password, phone);

            // Update Profile Info
            DisplayProfileInfo();
        }

                                                                        /* Logout */
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            studentsHousing.EndSession();
            MessageBox.Show("Logged out successfully");
            this.Hide();
            Form FormLogIn = new FrmLogin();
            FormLogIn.ShowDialog();
            this.Close();
        }


        // Call needed methods
        public void SetUp()
        {
            // Display house rules
            UpdateHouseRulesListView();
            // Display messages
            UpdateMessagesListView();

            // Display profile info
            DisplayProfileInfo();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizeWindow_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}