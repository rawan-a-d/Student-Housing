using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    enum MessageSubject { Question, Complaint}
    class StudentsHousing
    {
        // Fields
        List<Student> students;
        List<HouseRule> houseRules;
        List<Message> messages;

        // Constructor
        public StudentsHousing()
        {
            // Initialize lists
            students = new List<Student>();
            houseRules = new List<HouseRule>();
            messages = new List<Message>();
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

        // Test data
        public void GenerateTestDate()
        {
            //Students
            Student student1, student2, student3, student4;
            student1 = new Student("Rawan", "rawan@fontys.com", "12345", 1, 1);
            student2 = new Student("Baian", "baian@fontys.com", "12345", 1, 2);
            student3 = new Student("Femke", "femke@fontys.com", "12345", 1, 3);
            student4 = new Student("Mark", "mark@fontys.com", "12345", 1, 4);
            AddStudentToList(student1);
            AddStudentToList(student2);
            AddStudentToList(student3);
            AddStudentToList(student4);

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
