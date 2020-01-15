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

            lbl_LoggedInAsName.Text = currentUser.Name;

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
            tbxBalance.Text = "€" + currentUser.Balance.ToString();
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
            MessageBox.Show("Your profile information has been updated.");

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
            // Display agreements
            UpdateAgreementsDgv();
            RefreshComboboxNames();

            // Display grocerylists
            UpdateGroceriesDgv();
            UpdateGroceryHistoryDgv();

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

        private void btn_NewAgreementSubmit_Click(object sender, EventArgs e)
        {
            string agreementDescription = tb_NewAgreementDescription.Text;
            DateTime date = DateTime.Now;
            string otherStudent = (string)cbx_AgreementPersonInvolved.SelectedItem;
            string involvedStudents = currentUser.Name + " & " + otherStudent;

            if ((otherStudent == "") && (agreementDescription == ""))
            {
                MessageBox.Show("Please fill in a description and select the person involved first.");
            }
            if ((otherStudent != "") && (agreementDescription == ""))
            {
                MessageBox.Show("Please fill in a description.");
            }
            if ((otherStudent == "") && (agreementDescription != ""))
            {
                MessageBox.Show("Select the person to have an agreement with first.");
            }
            if ((otherStudent != "") && (agreementDescription != ""))
            {
                if (otherStudent != currentUser.Name)
                {
                    studentsHousing.CreateAgreement(date, involvedStudents, agreementDescription);
                    UpdateAgreementsDgv();
                    MessageBox.Show("Successfully added new pending agreement.");
                }
                else
                {
                    MessageBox.Show("You can't make an agreement with yourself."); // might delete.
                }
            }
        }

        private void UpdateAgreementsDgv()
        {
            List<Agreement> agreements = studentsHousing.GetAgreementsList();
            dgv_AgreementsStudent.Rows.Clear();

            foreach (var agreement in agreements)
            {
                if (agreement.StudentsInvolved.Contains(currentUser.Name) || agreement.StudentsInvolved.Contains("Everyone"))
                {
                    DataGridViewRow row = (DataGridViewRow)dgv_AgreementsStudent.Rows[0].Clone();

                    row.Cells[0].Value = agreement.Id.ToString();
                    row.Cells[1].Value = (agreement.DateCreated.ToString("dd/MM/yyyy")).ToString();
                    row.Cells[2].Value = agreement.StudentsInvolved;
                    row.Cells[3].Value = agreement.AgreementDescription;
                    row.Cells[4].Value = agreement.Status;

                    dgv_AgreementsStudent.Rows.Add(row);
                }

                dgv_AgreementsStudent.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgv_AgreementsStudent.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
        }

        private void btn_AgreementAcceptSelected_Click(object sender, EventArgs e)
        {
            if (dgv_AgreementsStudent.SelectedCells.Count <= 0)
            {
                MessageBox.Show("Please select an agreement.");
            }
            else
            {
                string status = dgv_AgreementsStudent.CurrentRow.Cells[4].Value.ToString();
                if (status == "Pending" || status.Contains("voters"))
                {
                    string involvedStudents = dgv_AgreementsStudent.CurrentRow.Cells[2].Value.ToString();
                    int selectedAgreementId = Convert.ToInt32(dgv_AgreementsStudent.CurrentRow.Cells[0].Value);

                    if (involvedStudents.Contains("& " + currentUser.Name))
                    {
                        studentsHousing.SendAcceptToPrivateAgreement(selectedAgreementId);
                        UpdateAgreementsDgv();
                        MessageBox.Show("Successfully agreed to the agreement request.");
                    }
                    if (involvedStudents.Contains("& Everyone"))
                    {
                        int oldVoterAmount = studentsHousing.GetAgreementVoters(selectedAgreementId);
                        studentsHousing.SendAcceptToPublicAgreement(selectedAgreementId, currentUser.Name);
                        int newVoterAmount = studentsHousing.GetAgreementVoters(selectedAgreementId);

                        if (oldVoterAmount < newVoterAmount)
                        {
                            UpdateAgreementsDgv();
                            MessageBox.Show("Successfully agreed to the agreement request.");
                        }
                        if (oldVoterAmount == newVoterAmount)
                        {
                            MessageBox.Show("You already voted for this agreement.");
                        }
                    }
                    if (involvedStudents.Contains(currentUser.Name + " &") && !involvedStudents.Contains("Everyone"))
                    {
                        MessageBox.Show("You can't accept an agreement initiated by yourself.");
                    }
                }
                if (status == "Accepted")
                {
                    MessageBox.Show("This agreement has already been accepted.");
                }
                if (status == "Rejected")
                {
                    MessageBox.Show("This agreement has already been rejected.");
                }
            }
        }

        private void RefreshComboboxNames()
        {
            cbx_AgreementPersonInvolved.Items.Clear();
            List<Student> students = studentsHousing.GetStudentsList();

            foreach (Student student in students)
            {
                cbx_AgreementPersonInvolved.Items.Add(student.Name);
            }
            cbx_AgreementPersonInvolved.Items.Add("Everyone");
        }

        private void btn_AgreementRejectSelected_Click(object sender, EventArgs e)
        {
            if (dgv_AgreementsStudent.SelectedCells.Count <= 0)
            {
                MessageBox.Show("Please select an agreement.");
            }
            else
            {
                string status = dgv_AgreementsStudent.CurrentRow.Cells[4].Value.ToString();
                if (status == "Pending" || status.Contains("voters"))
                {
                    string involvedStudents = dgv_AgreementsStudent.CurrentRow.Cells[2].Value.ToString();
                    int selectedAgreementId = Convert.ToInt32(dgv_AgreementsStudent.CurrentRow.Cells[0].Value);

                    if (involvedStudents.Contains("& " + currentUser.Name))
                    {
                        studentsHousing.SendRejectToPrivateAgreement(selectedAgreementId);
                        UpdateAgreementsDgv();
                        MessageBox.Show("Successfully rejected the agreement request.");
                    }
                    if (involvedStudents.Contains("& Everyone"))
                    {
                        int oldVoterAmount = studentsHousing.GetAgreementVoters(selectedAgreementId);
                        studentsHousing.SendRejectToPublicAgreement(selectedAgreementId, currentUser.Name);
                        int newVoterAmount = studentsHousing.GetAgreementVoters(selectedAgreementId);

                        if (oldVoterAmount < newVoterAmount)
                        {
                            UpdateAgreementsDgv();
                            MessageBox.Show("Successfully rejected the agreement request.");
                        }
                        if (oldVoterAmount == newVoterAmount)
                        {
                            MessageBox.Show("You already voted for this agreement.");
                        }
                    }
                    if (involvedStudents.Contains(currentUser.Name + " &") && !involvedStudents.Contains("Everyone"))
                    {
                        MessageBox.Show("You can't reject an agreement initiated by yourself.");
                    }
                }
                if (status == "Accepted")
                {
                    MessageBox.Show("This agreement has already been accepted.");
                }
                if (status == "Rejected")
                {
                    MessageBox.Show("This agreement has already been rejected.");
                }
            }
        }

        private void btn_AgreementEditSelected_Click(object sender, EventArgs e)
        {
            if (dgv_AgreementsStudent.SelectedCells.Count <= 0)
            {
                MessageBox.Show("Please select an agreement to be edited");
            }
            else
            {
                string status = dgv_AgreementsStudent.CurrentRow.Cells[4].Value.ToString();
                string involvedStudents = dgv_AgreementsStudent.CurrentRow.Cells[2].Value.ToString();
                int selectedAgreementId = Convert.ToInt32(dgv_AgreementsStudent.CurrentRow.Cells[0].Value);
                int voterAmount = studentsHousing.GetAgreementVoters(selectedAgreementId);

                if (status == "Pending" || status == "Rejected" || status.Contains("voters"))
                {
                    if (involvedStudents.Contains(currentUser.Name + " &") && voterAmount == 0)
                    {
                        studentsHousing.EditAgreementDescription(selectedAgreementId, tb_NewAgreementDescription.Text);
                        MessageBox.Show("Your agreement was successfully edited.");
                        UpdateAgreementsDgv();
                    }
                    if (involvedStudents.Contains(currentUser.Name + " &") && voterAmount > 0)
                    {
                        MessageBox.Show("You can't edit an agreement that has one or more votes.");
                    }
                    if (!involvedStudents.Contains(currentUser.Name + " &"))
                    {
                        MessageBox.Show("You can't edit someone else's agreement.");
                    }
                }
                if (status == "Accepted")
                {
                    MessageBox.Show("You can't edit an agreement that has already been accepted.");
                }
            }
        }

        private void btn_AgreementDeleteSelected_Click(object sender, EventArgs e)
        {
            if (dgv_AgreementsStudent.SelectedCells.Count <= 0)
            {
                MessageBox.Show("Please select a agreement to be removed");
            }
            else
            {
                string status = dgv_AgreementsStudent.CurrentRow.Cells[4].Value.ToString();
                string involvedStudents = dgv_AgreementsStudent.CurrentRow.Cells[2].Value.ToString();
                int selectedAgreementId = Convert.ToInt32(dgv_AgreementsStudent.CurrentRow.Cells[0].Value);

                if (status == "Pending" || status == "Rejected")
                {
                    if (involvedStudents.Contains(currentUser.Name + " &")) 
                    {
                        studentsHousing.RemoveAgreementById(selectedAgreementId);
                        MessageBox.Show("Your agreement was successfully removed.");
                        UpdateAgreementsDgv();
                    }
                    else
                    {
                        MessageBox.Show("You can't remove someone else's agreement.");
                    }
                }
                if (status.Contains("voters"))
                {
                    int percentageAgreed = studentsHousing.GetAgreementVotesPercentage(selectedAgreementId);
                    if (involvedStudents.Contains(currentUser.Name + " &") && percentageAgreed >= 50)
                    {
                        MessageBox.Show("You can't remove an agreement that has over 50% of the votes.");
                    }
                    if (!involvedStudents.Contains(currentUser.Name + " &"))
                    {
                        MessageBox.Show("You can't remove someone else's agreement.");
                    }
                    if (involvedStudents.Contains(currentUser.Name + " &") && percentageAgreed <= 49)
                    {
                        studentsHousing.RemoveAgreementById(selectedAgreementId);
                        MessageBox.Show("Your agreement was successfully removed.");
                        UpdateAgreementsDgv();
                    }
                }
                if (status == "Accepted")
                {
                    MessageBox.Show("Can't remove an agreement that has already been accepted.");
                }
            }
        }

        private void dgv_AgreementsStudent_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                string description = dgv_AgreementsStudent.CurrentRow.Cells[3].Value.ToString();
                tb_NewAgreementDescription.Text = description;
            }
            catch (Exception ex){}
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            double amountToAdd = Convert.ToDouble(tbxAddBalance.Text);
            currentUser.AddBalance(amountToAdd);
            MessageBox.Show("The new balance has been added.");
            DisplayProfileInfo();
        }

        private void btn_GroceryAddItem_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(nud_GroceryItemAmount.Value);
            string item = tb_GroceryItem.Text;

            if (item == "")
            {
                MessageBox.Show("Fill in an item first.");
            }
            else
            {
                studentsHousing.CreateGroceryItem(amount, item, currentUser.Name);
                UpdateGroceriesDgv();
                nud_GroceryItemAmount.Value = 1;
                tb_GroceryItem.Text = "";
            }
        }

        private void UpdateGroceriesDgv()
        {
            List<GroceryItem> groceryList = studentsHousing.GetGroceryList();
            dgv_Groceries.Rows.Clear();

            foreach (var grocery in groceryList)
            {
                DataGridViewRow row = (DataGridViewRow)dgv_Groceries.Rows[0].Clone();

                row.Cells[0].Value = grocery.Id.ToString();
                row.Cells[1].Value = grocery.Amount.ToString();
                row.Cells[2].Value = grocery.ItemName;
                row.Cells[3].Value = grocery.Creator;

                dgv_Groceries.Rows.Add(row);
            }
            dgv_Groceries.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv_Groceries.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void btn_GroceryRemoveItem_Click(object sender, EventArgs e)
        {
            if (dgv_Groceries.SelectedCells.Count <= 0)
            {
                MessageBox.Show("Please select a grocery item to be removed.");
            }
            else
            {
                string creator = dgv_Groceries.CurrentRow.Cells[3].Value.ToString();
                if (creator == currentUser.Name)
                {
                    int selectedGroceryItemId = Convert.ToInt32(dgv_Groceries.CurrentRow.Cells[0].Value);
                    studentsHousing.RemoveGroceryItemById(selectedGroceryItemId);
                    MessageBox.Show("Your grocery item was successfully removed.");
                    UpdateGroceriesDgv();
                }
                else
                {
                    MessageBox.Show("You can't remove someone else's grocery item.");
                }
            }
        }

        private void btn_GroceryCompleteList_Click(object sender, EventArgs e)
        {
            if (dgv_Groceries.Rows.Count > 1)
            {
                studentsHousing.CreateGroceryHistory(DateTime.Now, currentUser.Name);
                MessageBox.Show("Grocery list successfully completed.");
                studentsHousing.ClearGroceryList();
                UpdateGroceriesDgv();
                UpdateGroceryHistoryDgv();
            }
            else 
            {
                MessageBox.Show("The grocery list is empty, there is nothing to complete.");
            }
        }

        private void UpdateGroceryHistoryDgv()
        {
            List<GroceryHistory> groceryHistory = studentsHousing.GetGroceryHistoryList();
            dgv_GroceriesHistory.Rows.Clear();

            foreach (var history in groceryHistory)
            {
                DataGridViewRow row = (DataGridViewRow)dgv_GroceriesHistory.Rows[0].Clone();

                row.Cells[0].Value = history.Id.ToString();
                row.Cells[1].Value = history.DateAndTime.ToString("dd/MM/yyyy  h:mmtt").ToString();
                row.Cells[2].Value = history.PersonResponsible.ToString();

                dgv_GroceriesHistory.Rows.Add(row);
            }
            dgv_GroceriesHistory.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv_GroceriesHistory.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void btn_GroceryHistoryInfo_Click(object sender, EventArgs e)
        {
            if (dgv_GroceriesHistory.SelectedCells.Count <= 0)
            {
                MessageBox.Show("Please select a row first.");
            }
            else
            {
                int selectedGroceryHistoryId = Convert.ToInt32(dgv_GroceriesHistory.CurrentRow.Cells[0].Value);
                MessageBox.Show(studentsHousing.GetGroceryHistoryInfoById(selectedGroceryHistoryId));
            }
        }
    }
}