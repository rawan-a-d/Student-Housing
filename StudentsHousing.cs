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
    }
}
