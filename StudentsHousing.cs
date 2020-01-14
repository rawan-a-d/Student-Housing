using System;
using System.Collections.Generic;
using GemBox.Spreadsheet;
using GemBox.Spreadsheet.ConditionalFormatting;
using System.Data;

namespace Project
{
    enum MessageSubject { Question, Complaint}
    enum TaskType { Cleaning, Garbage, Shopping}
    enum TaskStatus { Pending, Completed, NotCompleted}

    class StudentsHousing
    {
        // Fields
        List<Student> students;
        List<Admin> admins;
        List<HouseRule> houseRules;
        List<Message> messages;
        List<Date> dates;
        List<Schedule> schedules;
        List<Agreement> agreements;
        private static StudentsHousing instance = null;
        // No need for this/ because it's not multi threading
        private static readonly object padlock = new object();
        // Current user
        private Student currentStudent;
        private Admin currentAdmin;
        private Student student;
        private HouseRule houseRule;
        private Message message;
        private Agreement agreement;
        private int studentWithHighestScore;


        // Constructor
        StudentsHousing()
        {
            // Initialize lists
            students = new List<Student>();
            admins = new List<Admin>();
            houseRules = new List<HouseRule>();
            messages = new List<Message>();
            dates = new List<Date>();
            schedules = new List<Schedule>();
            agreements = new List<Agreement>();
            GenerateTestDate();
        }

        public static StudentsHousing Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new StudentsHousing();
                    }
                    return instance;
                }
            }
        }

        // Methods
        /* Student */
        public void CreateStudent(string name, string email, string password, int floorNr, int roomNr)
        {
            student = new Student(name, email, password, floorNr, roomNr);

            //Add student to list
            AddStudentToList(student);
        }

        private void AddStudentToList(Student student)
        {
            students.Add(student);
        }

        public List<Student> GetStudentsList()
        {
            return students;
        }

        public void RemoveStudentById(int id)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Id == id)
                {
                    students.Remove(students[i]);
                }
            }
        }

        public string FindStudentById(int studentId)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Id == studentId)
                {
                    return students[i].Name;
                }
            }
            return "";
        }

        public int FindStudentIndex(int studentId)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Id == studentId)
                {
                    return i;
                }
            }
            return 0;
        }

        public int FindStudentId(string name)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Name == name)
                {
                    return students[i].Id;
                }
            }
            return 0;
        }

        public bool StudentExists(string email)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if(students[i].Email == email)
                {
                    return true;
                    break;
                }
            }
            return false;
        }

        public void UpdateStudentInfo(int studentId, string name, int age, string email, string password, string phone)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Id == studentId)
                {
                    students[i].UpdateInfo(name, age, email, password, phone);
                }
            }
        }

        /* Admin */
        private void AddAdminToList(Admin admin)
        {
            admins.Add(admin);
        }

        public bool AdminExists(string email)
        {
            for (int i = 0; i < admins.Count; i++)
            {
                if (admins[i].Email == email)
                {
                    return true;
                    break;
                }
            }
            return false;
        }


        /* House Rule */
        public void CreateHouseRule(DateTime currentDate, string newRule)
        {
            houseRule = new HouseRule(currentDate, newRule);

            // Add rule to list
            AddHouseRuleToList(houseRule);
        }

        private void AddHouseRuleToList(HouseRule rule)
        {
            houseRules.Add(rule);
        }

        public List<HouseRule> GetRulesList()
        {
            return houseRules;
        }

        public void RemoveHouseRuleById(int id)
        {
            for (int i = 0; i < houseRules.Count; i++)
            {
                if(houseRules[i].Id == id)
                {
                    houseRules.Remove(houseRules[i]);
                }
            }
        }

        public void ModifyHouseRuleById(int id, string updatedRule)
        {
            foreach (var rule in houseRules)
            {
                if (rule.Id == id)
                {
                    rule.UpdateHouseRule(id, updatedRule);
                }
            }
        }


        /* Messages */
        // Create Message
        public void CreateMessage(DateTime currentDate, MessageSubject messageType, string messageDesc, int currentStudentId)
        {
            message = new Message(currentDate, messageType, messageDesc, currentStudentId);

            // Add message to list
            AddMessageToList(message);
        }

        // Add message
        private void AddMessageToList(Message message)
        {
            messages.Add(message);
        }

        // Get messages
        public List<Message> GetMessagesList()
        {
            return messages;
        }

        // Remove message
        public void RemoveMessageById(int messageId)
        {
            for (int i = 0; i < messages.Count; i++)
            {
                if (messages[i].Id == messageId)
                {
                    messages.Remove(messages[i]);
                }
            }
        }

        // Send reply/ ADMIN
        public void SendReply(int messageId, string reply)
        {
            for (int i = 0; i < messages.Count; i++)
            {
                if (messages[i].Id == messageId)
                {
                    messages[i].UpdateReply(messageId, reply);
                }
            }
        }

        /* Agreements */
        // Add agreement
        public void CreateAgreement(DateTime currentDate, string involvedStudents, string agreementDesc)
        {
            agreement = new Agreement(currentDate, involvedStudents, agreementDesc);
            AddAgreementToList(agreement);
        }

        public void AddAgreementToList(Agreement agreement)
        {
            agreements.Add(agreement);
        }

        public List<Agreement> GetAgreementsList()
        {
            return agreements;
        }

        // Remove agreement
        public void RemoveAgreementById(int id)
        {
            for (int i = 0; i < agreements.Count; i++)
            {
                if (agreements[i].Id == id)
                {
                    agreements.Remove(agreements[i]);
                }
            }
        }

        // Accepting / Rejecting agreements
        public void SendAcceptToPrivateAgreement(int id) // where involved is currentuser only.
        {
            for (int i = 0; i < agreements.Count; i++)
            {
                if (agreements[i].Id == id)
                {
                    agreements[i].UpdateStatus("Accepted");
                }
            }
        }

        public void SendRejectToPrivateAgreement(int id) // where involved is currentuser only.
        {
            for (int i = 0; i < agreements.Count; i++)
            {
                if (agreements[i].Id == id)
                {
                    agreements[i].UpdateStatus("Rejected");
                }
            }
        }

        public void SendAcceptToPublicAgreement(int id, string studentWhoVoted) // where involved is "Everyone".
        {
            for (int i = 0; i < agreements.Count; i++)
            {
                if (agreements[i].Id == id)
                {
                    string voters = agreements[i].VoterList;
                    if (!voters.Contains(studentWhoVoted))
                    {
                        agreements[i].IncreaseVotes(studentWhoVoted);
                        agreements[i].UpdateStatusVotes();
                    }
                }
            }
        }

        public void SendRejectToPublicAgreement(int id, string studentWhoVoted) // where involved is "Everyone".
        {
            for (int i = 0; i < agreements.Count; i++)
            {
                if (agreements[i].Id == id)
                {
                    string voters = agreements[i].VoterList;
                    if (!voters.Contains(studentWhoVoted))
                    {
                        agreements[i].DecreaseVotes(studentWhoVoted);
                        agreements[i].UpdateStatusVotes();
                    }
                }
            }
        }

        // Get amount of voters for checking if voting passed or failed.
        public int GetAgreementVoters(int id)
        {
            int voters = 0;
            for (int i = 0; i < agreements.Count; i++)
            {
                if (agreements[i].Id == id)
                {
                    voters = agreements[i].GetVoters();
                }
            }
            return voters;
        }

        // Get percentage of voters
        public int GetAgreementVotesPercentage(int id)
        {
            int percentage = 0;
            for (int i = 0; i < agreements.Count; i++)
            {
                if (agreements[i].Id == id)
                {
                    percentage = agreements[i].CalculatePercentageVotes();
                }
            }
            return percentage;
        }

        public void EditAgreementDescription(int id, string newDescription)
        {
            for (int i = 0; i < agreements.Count; i++)
            {
                if (agreements[i].Id == id)
                {
                    agreements[i].UpdateDescription(newDescription);
                }
            }
        }


        /* Dates */
        // Add date
        private void AddDateToList(Date date)
        {
            dates.Add(date);
        }

        public List<Date> GetDatesList()
        {
            return dates;
        }


        /* Schedules */
        private void AddScheduleToList(Schedule schedule)
        {
            schedules.Add(schedule);
        }

        public List<Schedule> GetSchedulesList()
        {
            return schedules;
        }

        // Create schedule
        public void CreateSchedule()
        {
            EmptySchedule();
            // Dates list
            List<Date> dates = GetDatesList();
            // Students list
            List<Student> students = GetStudentsList();

            int taskCounter = 0;
            int dateCounter = 0;
            for (int i = 0; i < students.Count; i++)
            {
                for (int j = dateCounter; j < dates.Count; j += 3)
                {
                    // New schedule
                    Schedule schedule = new Schedule(dates[j].Id, (TaskType)taskCounter, students[i].Id, TaskStatus.Pending);
                    AddScheduleToList(schedule);
                    taskCounter++;

                    // If task counter has th same length as TaskType
                    if (taskCounter == Enum.GetNames(typeof(TaskType)).Length)
                    {
                        taskCounter = 0;
                    }
                }
                // Increase date by two so that the next student starts after two days
                dateCounter += 5;
                // Set taskCounter back to 0
                taskCounter = 0;
            }
        }


        // Create dates and add them to dates list
        public void AddDates()
        {
            DateTime temp_start;
            DateTime temp_end;
            DateTime startDate = DateTime.Today;
            DateTime endDate = startDate.AddDays(54);

            //--Normalize dates by getting rid of minues since they will get in the way when doing the loop
            temp_start = new DateTime(startDate.Year, startDate.Month, startDate.Day);
            temp_end = new DateTime(endDate.Year, endDate.Month, endDate.Day);

            // Create and add dates to list
            for (DateTime date = temp_start; date <= temp_end; date = date.AddDays(1))
            {
                Date newDate = new Date(date);

                AddDateToList(newDate);
            }
        }

        private void EmptySchedule()
        {
            schedules.Clear();
        }

        public DateTime FindDateById(int dateId)
        {
            for (int i = 0; i < dates.Count; i++)
            {
                if (dates[i].Id == dateId)
                {
                    return dates[i].TaskDate;
                }
            }

            return DateTime.Now;
        }

        public int FindDateId(DateTime date)
        {
            for (int i = 0; i < dates.Count; i++)
            {
                if (dates[i].TaskDate == date)
                {
                    return dates[i].Id;
                }
            }
            return 0;
        }


        // Complete task
        public void CompleteTask(int studentId, DateTime date)
        {
            // Update score
            int studentIndex = FindStudentIndex(studentId);
            UpdateScore(studentIndex);

            // Complete task
            int dateId = FindDateId(date);
            for (int i = 0; i < schedules.Count; i++)
            {
                if(schedules[i].StudentId == studentId && schedules[i].DateId == dateId)
                {
                    schedules[i].SetStatus(TaskStatus.Completed);
                    break;
                }
            }
        }

        private void UpdateScore(int studentIndex)
        {
            // Update score
            students[studentIndex].UpdateScore(3);
        }
        
        // Compare scores
        public bool CompareScores()
        {
            int currentStudentScore = currentStudent.Score;
            for (int i = 0; i < students.Count; i++)
            {
                if(students[i].Score > studentWithHighestScore)
                {
                    studentWithHighestScore = students[i].Score;
                }
            }
            if(studentWithHighestScore == currentStudentScore)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        // Uncomplete task
        public void UnCompleteTask(int studentId, DateTime date)
        {
            // Update Score
            int studentIndex = FindStudentIndex(studentId);
            students[studentIndex].Score = 0;
            students[studentIndex].Score = -5;

            // Uncomplete task
            int dateId = FindDateId(date);
            for (int i = 0; i < schedules.Count; i++)
            {
                if (schedules[i].StudentId == studentId && schedules[i].DateId == dateId)
                {
                    schedules[i].SetStatus(TaskStatus.NotCompleted);
                    break;
                }
            }
        }

        // Export Excel
        public void ExportToExcel()
        {
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
            var workbook = new ExcelFile();
            var worksheet = workbook.Worksheets.Add("Exported from messages");

            // Create headers
            var dataTable = new DataTable();
            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("Date Added", typeof(DateTime));
            dataTable.Columns.Add("Type", typeof(string));
            dataTable.Columns.Add("Message", typeof(string));
            dataTable.Columns.Add("Reply", typeof(string));

            // Create rows
            for (int i = 0; i < messages.Count; i++)
            {
                // If message is a question
                if(messages[i].Subject == MessageSubject.Question)
                {
                    dataTable.Rows.Add(messages[i].Id, messages[i].DateCreated, "Question", messages[i].MessageText, messages[i].Reply);

                }
                // If message is a complaint
                else
                {
                    dataTable.Rows.Add(messages[i].Id, messages[i].DateCreated, "Complaint", messages[i].MessageText, messages[i].Reply);
                }
            }

            // Insert DataTable to an Excel worksheet.
            worksheet.InsertDataTable(dataTable,
                new InsertDataTableOptions()
                {
                    ColumnHeaders = true,
                    StartRow = 0
                });

            /* Style */
            // Auto fit columns, add color and background color
            int columnCount = worksheet.CalculateMaxUsedColumns();
            for (int i = 0; i < columnCount; i++)
            {
                worksheet.Columns[i].AutoFit(1, worksheet.Rows[0], worksheet.Rows[worksheet.Rows.Count - 1]);
                worksheet.Rows[0].Cells[i].Style.FillPattern.SetGradient(GradientShadingStyle.HorizontalHigh, SpreadsheetColor.FromName(ColorName.Accent5Darker25Pct), SpreadsheetColor.FromName(ColorName.Accent5Darker50Pct));
                worksheet.Rows[0].Cells[i].Style.Font.Color = SpreadsheetColor.FromName(ColorName.White);
            }

            // Apply borders to specific cells
            worksheet.ConditionalFormatting.AddContainText("C2:C" + (messages.Count + 1), ContainTextOperator.Contains, "Complaint").
                Style.Borders.SetBorders(MultipleBorders.Outside, SpreadsheetColor.FromName(ColorName.Red), LineStyle.Double);
            worksheet.ConditionalFormatting.AddContainText("C2:C" + (messages.Count + 1), ContainTextOperator.Contains, "Question").
                Style.Borders.SetBorders(MultipleBorders.Outside, SpreadsheetColor.FromName(ColorName.Green), LineStyle.Thick);

            // Font weight
            worksheet.Rows[0].Style.Font.Weight = ExcelFont.BoldWeight;
            // Wrap text
            worksheet.Cells.Style.WrapText = true;
            // Header horizontal alignment
            worksheet.Rows[0].Style.HorizontalAlignment = HorizontalAlignmentStyle.Center;
            workbook.Save("messages.xlsx");
        }

        /* Login */
        public string GetUserType(string email)
        {
            if (StudentExists(email))
            {
                return "Student";
            }
            else if(AdminExists(email))
            {
                return "Admin";
            }
            else
            {
                return "No user found";
            }
        }


        public bool CheckCredentials(string userType, string email, string password)
        { 
            // If student
            if(userType == "Student")
            {
                for (int i = 0; i < students.Count; i++)
                {
                    if (email == students[i].Email && password == students[i].Password)
                    {
                        SetCredentials(students[i]);
                        return true;
                    }
                }
                return false;
            }
            // if admin
            else if(userType == "Admin")
            {
                for (int i = 0; i < admins.Count; i++)
                {
                    if (email == admins[i].Email && password == admins[i].Password)
                    {
                        SetCredentials(admins[i]);
                        return true;
                    }
                }
                return false;
            }
            return false;
        }


        private void SetCredentials(Student currentUser)
        {
            this.currentStudent = currentUser;
        }
        private void SetCredentials(Admin currentUser)
        {
            this.currentAdmin = currentUser;
        }

        public Student GetCurrentStudent()
        {
            return this.currentStudent;
        }
        public Admin GetCurrentAdmin()
        {
            return this.currentAdmin;
        }

        // End session user/ logout
        public void EndSession()
        {
            this.currentStudent = null;
            this.currentAdmin = null;
        }

        // Test data
        private void GenerateTestDate()
        {
            //Students
            Student student1, student2, student3, student4, student5, student6, student7;
            student1 = new Student("Omar", "omar@fontys.com", "12345", 1, 1);
            student2 = new Student("Pieter", "pieter@fontys.com", "12345", 1, 2);
            student3 = new Student("Miley", "miley@fontys.com", "12345", 1, 3);
            student4 = new Student("Mark", "mark@fontys.com", "12345", 1, 4);
            student5 = new Student("Kelvin", "kelvin@fontys.com", "12345", 1, 5);
            student6 = new Student("Ranim", "ranim@fontys.com", "12345", 1, 6);
            student7 = new Student("Robin", "robin@fontys.com", "12345", 1, 7);
            AddStudentToList(student1);
            AddStudentToList(student2);
            AddStudentToList(student3);
            AddStudentToList(student4);
            AddStudentToList(student5);
            AddStudentToList(student6);
            AddStudentToList(student7);
            student1.UpdateScore(15);
            student2.UpdateScore(38);
            student3.UpdateScore(2);
            student4.UpdateScore(64);
            student5.UpdateScore(5);
            student6.UpdateScore(12);
            student7.UpdateScore(24);

            // Admins
            Admin admin1, admin2, admin3;
            admin1 = new Admin("Rawan", "rawan@fontys.com", "12345");
            admin2 = new Admin("Baian", "baian@fontys.com", "12345");
            admin3 = new Admin("Femke", "femke@fontys.com", "12345");
            AddAdminToList(admin1);
            AddAdminToList(admin2);
            AddAdminToList(admin3);

            // Random DateTime values
            DateTime four_jan = new DateTime(2020, 01, 04);
            DateTime six_jan = new DateTime(2020, 01, 06);
            DateTime seven_jan = new DateTime(2020, 01, 07);
            DateTime ten_jan = new DateTime(2020, 01, 10);
            DateTime thirdteen_jan = new DateTime(2020, 01, 13);


            //Messages
            Message message1, message2, message3, message4, message5, message6, message7, message8;
            message1 = new Message(four_jan, MessageSubject.Question, "How can I make changes to my tenancy agreement?", 0);
            message2 = new Message(six_jan, MessageSubject.Complaint, "The elevator does not work, when will it be repaired?", 1);
            message3 = new Message(six_jan, MessageSubject.Complaint, "People are not cleaning the shared facilities", 3);
            message4 = new Message(seven_jan, MessageSubject.Question, "Why has my rent increased?", 2);
            message5 = new Message(ten_jan, MessageSubject.Complaint, "My neighbors are organizing parties during the week very late at night", 2);
            message6 = new Message(ten_jan, MessageSubject.Question, "How can I speak to my housing officer?", 1);
            message7 = new Message(thirdteen_jan, MessageSubject.Question, "Am I due to have my kitchen and bathroom upgraded?", 0);
            message8 = new Message(thirdteen_jan, MessageSubject.Question, "How can I report a repair?", 0);
            AddMessageToList(message1);
            AddMessageToList(message2);
            AddMessageToList(message3);
            AddMessageToList(message4);
            AddMessageToList(message5);
            AddMessageToList(message6);
            AddMessageToList(message7);
            AddMessageToList(message8);

            // agreements
            Agreement agreement1, agreement2, agreement3, agreement4, agreement5, agreement6;
            agreement1 = new Agreement(four_jan, "Mark & Pieter", "Can I use your hairgel?", "Accepted");
            agreement2 = new Agreement(six_jan, "Mark & Everyone", "Please don't wear shoes inside.", "Pending", 1, 4, "->OmarMileyRobinRanim");
            agreement3 = new Agreement(seven_jan, "Miley & Mark", "Please take away your towel and clothes after showering.", "Pending");
            agreement4 = new Agreement(seven_jan, "Mark & Everyone", "Saturday is pizza day!", "Pending", 5, 6, "->OmarMileyKelvinRobinRanimMark");
            agreement5 = new Agreement(ten_jan, "Omar & Everyone", "No loud noises after 11:00PM.", "Pending", 3, 5, "->OmarMileyPieterRobinRanim");
            agreement6 = new Agreement(thirdteen_jan, "Pieter & Mark", "Help me with unpacking the groceries.", "Pending");
            AddAgreementToList(agreement1);
            AddAgreementToList(agreement2);
            AddAgreementToList(agreement3);
            AddAgreementToList(agreement4);
            AddAgreementToList(agreement5);
            AddAgreementToList(agreement6);

            // House rules
            HouseRule rule1, rule2, rule3, rule4, rule5, rule6, rule7, rule8, rule9;
            rule1 = new HouseRule(four_jan, "No Smoking");
            rule2 = new HouseRule(four_jan, "No animals permitted in residence");
            rule3 = new HouseRule(four_jan, "Keep the rooms clean");
            rule4 = new HouseRule(four_jan, "No fan heaters allowed whatsoever - these can very easily cause fires!");
            rule5 = new HouseRule(four_jan, "Please use any off-street parking provided fairly between all housemates.");
            rule6 = new HouseRule(seven_jan, "The supplied furniture may not be removed from your room or the common areas.");
            rule7 = new HouseRule(seven_jan, "Please ensure that all air conditions/heating units are turned off in bedrooms before leaving the house.");
            rule8 = new HouseRule(seven_jan, "Guests must not interfere with the reasonable peace, comfort and privacy of other residents.");
            rule9 = new HouseRule(thirdteen_jan, "Report your disturbances to your Resident Assistant and Building Manager");
            AddHouseRuleToList(rule1);
            AddHouseRuleToList(rule2);
            AddHouseRuleToList(rule3);
            AddHouseRuleToList(rule4);
            AddHouseRuleToList(rule5);
            AddHouseRuleToList(rule6);
            AddHouseRuleToList(rule7);
            AddHouseRuleToList(rule8);
            AddHouseRuleToList(rule9);
        }
    }
}
