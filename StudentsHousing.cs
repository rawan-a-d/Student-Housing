using System;
using System.Collections.Generic;
using GemBox.Spreadsheet;
using GemBox.Spreadsheet.ConditionalFormatting;
using System.Data;

namespace Project
{
    public class StudentsHousing
    {
        // Fields
        private List<Student> students;
        private List<Admin> admins;
        private List<HouseRule> houseRules;
        private List<Message> messages;
        private List<Date> dates;
        private List<Schedule> schedules;
        private static StudentsHousing instance = null;
        // Current user
        private Student currentStudent;
        private Admin currentAdmin;
        private Student student;
        private HouseRule houseRule;
        private Message message;
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
            GenerateTestDate();
        }

        public static StudentsHousing Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new StudentsHousing();
                }
                return instance;
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

        public Student[] GetStudentsList()
        {
            return students.ToArray();
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

        private int FindStudentIndex(int studentId)
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

        private bool StudentExists(string email)
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

        private bool AdminExists(string email)
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

        public HouseRule[] GetRulesList()
        {
            return houseRules.ToArray();
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
        public Message[] GetMessagesList()
        {
            return messages.ToArray();
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

        // Get messages current user
        public Message[] GetMessagesCurrentUser(int studentId)
        {
            List<Message> userMessages = new List<Message>();
            foreach (var message in messages)
            {
                if (message.StudentId == studentId)
                {
                    userMessages.Add(message);
                }
            }

            return userMessages.ToArray();
        }

        // Send reply/ ADMIN
        public void SendReply(int messageId, string reply)
        {
            foreach (var message in messages)
            {
                if (message.Id == messageId)
                {
                    message.UpdateReply(messageId, reply);
                }
            }
        }


        /* Dates */
        // Add date
        private void AddDateToList(Date date)
        {
            dates.Add(date);
        }

        private List<Date> GetDatesList()
        {
            return dates;
        }


        /* Schedules */
        private void AddScheduleToList(Schedule schedule)
        {
            schedules.Add(schedule);
        }

        public Schedule[] GetSchedulesList()
        {
            return schedules.ToArray();
        }

        // Create schedule
        public void CreateSchedule()
        {
            EmptySchedule();
            // Dates list
            List<Date> dates = GetDatesList();
            // Students list
            Student[] students = GetStudentsList();

            int taskCounter = 0;
            int dateCounter = 0;
            for (int i = 0; i < students.Length; i++)
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

        private int FindDateId(DateTime date)
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

            //Messages
            Message message1, message2, message3, message4, message5, message6, message7, message8;
            message1 = new Message(DateTime.Now, MessageSubject.Question, "How can I make changes to my tenancy agreement?", 4);
            message2 = new Message(DateTime.Now, MessageSubject.Complaint, "The elevator does not work, when will it be repaired?", 1);
            message3 = new Message(DateTime.Now, MessageSubject.Complaint, "People are not cleaning the shared facilities", 3);
            message4 = new Message(DateTime.Now, MessageSubject.Question, "Why has my rent increased?", 2);
            message5 = new Message(DateTime.Now, MessageSubject.Complaint, "My neighbors are organizing parties during the week very late at night", 2);
            message6 = new Message(DateTime.Now, MessageSubject.Question, "How can I speak to my housing officer?", 1);
            message7 = new Message(DateTime.Now, MessageSubject.Question, "Am I due to have my kitchen and bathroom upgraded?", 4);
            message8 = new Message(DateTime.Now, MessageSubject.Question, "How can I report a repair?", 4);
            AddMessageToList(message1);
            AddMessageToList(message2);
            AddMessageToList(message3);
            AddMessageToList(message4);
            AddMessageToList(message5);
            AddMessageToList(message6);
            AddMessageToList(message7);
            AddMessageToList(message8);


            // House rules
            HouseRule rule1, rule2, rule3, rule4, rule5, rule6, rule7, rule8, rule9;
            rule1 = new HouseRule(DateTime.Now, "No Smoking");
            rule2 = new HouseRule(DateTime.Now, "No animals permitted in residence");
            rule3 = new HouseRule(DateTime.Now, "Keep the rooms clean");
            rule4 = new HouseRule(DateTime.Now, "No fan heaters allowed whatsoever - these can very easily cause fires!");
            rule5 = new HouseRule(DateTime.Now, "Please use any off-street parking provided fairly between all housemates.");
            rule6 = new HouseRule(DateTime.Now, "The supplied furniture may not be removed from your room or the common areas.");
            rule7 = new HouseRule(DateTime.Now, "Please ensure that all air conditions/heating units are turned off in bedrooms before leaving the house.");
            rule8 = new HouseRule(DateTime.Now, "Guests must not interfere with the reasonable peace, comfort and privacy of other residents.");
            rule9 = new HouseRule(DateTime.Now, "Report your disturbances to your Resident Assistant and Building Manager");
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
