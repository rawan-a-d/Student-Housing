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

        // Constructor
        public StudentsHousing()
        {
            // Initialize list of students
            students = new List<Student>();
        }

        // Methods
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
    }
}
