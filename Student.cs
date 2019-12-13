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
        private static int autoIncId = 1;
        private int id;
        private string name;
        private string email;
        private string password;
        private string phoneNr;
        private int floorNr;
        private int roomNr;
        private double balance;
        private int score;


        // Constructors/Create object
        public Student(string name, string email, string password, int floorNr, int roomNr)
        {
            this.id = autoIncId;
            this.name = name;
            this.email = email;
            this.password = password;
            //this.phoneNr = phoneNr;
            this.floorNr = floorNr;
            this.roomNr = roomNr;
            this.balance = 0;
            this.score = 0;
            autoIncId++;
        }


        // Methods
        // Get methods
        public int GetId()
        {
            return id;
        }
        public string GetName()
        {
            return name;
        }

        public string GetEmail()
        {
            return email;
        }

        public string GetPassword()
        {
            return password;
        }

        public int GetFloorNr()
        {
            return floorNr;
        }

        public int GetRoomNr()
        {
            return roomNr;
        }
    }
}
