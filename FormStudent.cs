using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Project
{
    public partial class FrmStudent : Form
    {
        Student student;
        // Create instance of studentsHousing or use made instance
        StudentsHousing studentsHousing = StudentsHousing.Instance;
        Message message;

        public FrmStudent()
        {
            InitializeComponent();
            // Call needed methods
            SetUp();
        }

        private void FrmStudent_Load(object sender, EventArgs e)
        {

        }

        private void btn_SwitchInterface_Click(object sender, EventArgs e)
        {
            Form FormMain = new FrmMain();
            FormMain.Show();
            this.Close();
        }

        /* Student */
        // Complaints and Questions
        // Send message
        private void BtnMessageAdd_Click(object sender, EventArgs e)
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

        // Update List view (STUDENT and ADMIN)
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
                rowStudent.Cells[0].Value = rule.GetId().ToString();
                rowStudent.Cells[1].Value = (rule.GetDateCreated().ToString("dd/MM/yyyy")).ToString();
                rowStudent.Cells[2].Value = (rule.GetRule()).ToString();

                // Add the item to list view
                dgvHouseRulesStudent.Rows.Add(rowStudent);

                // Text wrap
                dgvHouseRulesStudent.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvHouseRulesStudent.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
        }


        // Update List view (STUDENT and ADMIN)
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
                rowStudent.Cells[0].Value = message.GetId().ToString();
                rowStudent.Cells[1].Value = (message.GetDateCreated().ToString("dd/MM/yyyy")).ToString();
                rowStudent.Cells[2].Value = (message.GetSubject()).ToString();
                rowStudent.Cells[3].Value = (message.GetMessage()).ToString();
                rowStudent.Cells[4].Value = (message.GetReply());

                // Add the item to list view
                dgvMessageStudent.Rows.Add(rowStudent);

                // Text wrap
                dgvMessageStudent.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvMessageStudent.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
        }


        /* Student */

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
                row.Cells[0].Value = studentsHousing.FindStudentById(schedule.GetStudentId()).ToString();
                row.Cells[1].Value = studentsHousing.FindDateById(schedule.GetDateId()).ToString("dd/MM/yyyy");
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
            // Add dates and create schedule
            studentsHousing.AddDates();
            studentsHousing.CreateSchedule();
            UpdateScheduleList();

            // Display house rules
            UpdateHouseRulesListView();
            // Display messages
            UpdateMessagesListView();

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
