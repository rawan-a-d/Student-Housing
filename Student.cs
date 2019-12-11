using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Student
    {
        //ID/Name/Age/Email/Password/phone number/Floor nr/room nr /Balance/Score
        private int id;
        private string name;
        private string email;
        private string password;
        private string phoneNr;
        private int floorNr;
        private int roomNr;
        private double balance;
        private int score;

        // Getters and setters
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public int FloorNr
        {
            get { return floorNr; }
            set { floorNr = value; }
        }

        public int RoomNr
        {
            get { return roomNr; }
            set { roomNr = value; }
        }

        // Methods
        // Create student
        public void AddStudent(int id, string name, string email, string password, int floorNr, int roomNr)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.password = password;
            this.floorNr = floorNr;
            this.roomNr = roomNr;
        }
    }
}
