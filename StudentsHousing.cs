using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class StudentsHousing
    {
        // Fields
        List<Student> students;
        List<HouseRule> houseRules;

        // Constructor
        public StudentsHousing()
        {
            // Initialize lists
            students = new List<Student>();
            houseRules = new List<HouseRule>();
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
                if (students[i].Id == id)
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
    }
}
