using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    enum MessageSubject { Question, Complaint}
    enum TaskType { Cleaning, Garbage, Shopping}
    enum TaskStatus { Pending, Completed}
    class StudentsHousing
    {
        // Fields
        List<Student> students;
        List<HouseRule> houseRules;
        List<Message> messages;
        List<Date> dates;
        List<Schedule> schedules;

        // Constructor
        public StudentsHousing()
        {
            // Initialize lists
            students = new List<Student>();
            houseRules = new List<HouseRule>();
            messages = new List<Message>();
            dates = new List<Date>();
            schedules = new List<Schedule>();
        }

        // Methods

        // Student
        public void AddStudentToList(Student student)
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
                if (students[i].GetId() == id)
                {
                    students.Remove(students[i]);
                }
            }
        }

        public string FindStudentById(int studentId)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].GetId() == studentId)
                {
                    return students[i].GetName();
                }
            }

            return "";
        }


        // Housing Rule
        public void AddHouseRuleToList(HouseRule rule)
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
                if(houseRules[i].GetId() == id)
                {
                    houseRules.Remove(houseRules[i]);
                }
            }
        }

        public void ModifyHouseRuleById(int id, string updatedRule)
        {
            foreach (var rule in houseRules)
            {
                if (rule.GetId() == id)
                {
                    rule.UpdateHouseRule(id, updatedRule);
                }
            }
        }


        // Messages
        // Add message
        public void AddMessageToList(Message message)
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
                if (messages[i].GetId() == messageId)
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
                if (messages[i].GetId() == messageId)
                {
                    messages[i].UpdateReply(messageId, reply);
                }
            }
        }


        // Dates
        // Add date
        public void AddDateToList(Date date)
        {
            dates.Add(date);
        }

        public List<Date> GetDatesList()
        {
            return dates;
        }


        // Schedules
        public void AddScheduleToList(Schedule schedule)
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
                    Schedule schedule = new Schedule(dates[j].GetId(), (TaskType)taskCounter, students[i].GetId(), TaskStatus.Pending);
                    AddScheduleToList(schedule);

                    taskCounter++;

                    // If task counter has th same length as TaskType
                    if (taskCounter == Enum.GetNames(typeof(TaskType)).Length)
                    {
                        taskCounter = 0;
                    }
                }
                // Increase date by two so that the next student starts after two days
                dateCounter += 2;
                // Set taskCounter back to 0
                taskCounter = 0;
            }
        }
        

        // Create dates and ad them to dates list
        public void AddDates()
        {
            DateTime temp_start;
            DateTime temp_end;
            DateTime startDate = DateTime.Today;
            DateTime endDate = startDate.AddDays(60);

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

        public DateTime FindDateById(int dateId)
        {
            for (int i = 0; i < dates.Count; i++)
            {
                if (dates[i].GetId() == dateId)
                {
                    return dates[i].GetDate();
                }
            }

            return DateTime.Now;
        }


        // Test data
        public void GenerateTestDate()
        {
            //Students
            Student student1, student2, student3, student4, student5, student6, student7;
            student1 = new Student("Rawan", "rawan@fontys.com", "12345", 1, 1);
            student2 = new Student("Baian", "baian@fontys.com", "12345", 1, 2);
            student3 = new Student("Femke", "femke@fontys.com", "12345", 1, 3);
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


            //Messages
            Message message1, message2, message3, message4, message5, message6, message7, message8;
            message1 = new Message(DateTime.Now, MessageSubject.Question, "How can I make changes to my tenancy agreement?", 0);
            message2 = new Message(DateTime.Now, MessageSubject.Complaint, "The elevator does not work, when will it be repaired?", 1);
            message3 = new Message(DateTime.Now, MessageSubject.Complaint, "People are not cleaning the shared facilities", 3);
            message4 = new Message(DateTime.Now, MessageSubject.Question, "Why has my rent increased?", 2);
            message5 = new Message(DateTime.Now, MessageSubject.Complaint, "My neighbors are organizing parties during the week very late at night", 2);
            message6 = new Message(DateTime.Now, MessageSubject.Question, "How can I speak to my housing officer?", 1);
            message7 = new Message(DateTime.Now, MessageSubject.Question, "Am I due to have my kitchen and bathroom upgraded?", 0);
            message8 = new Message(DateTime.Now, MessageSubject.Question, "How can I report a repair?", 0);
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
