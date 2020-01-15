using System;

namespace Project
{
    public class Student: User
    {
        private double balance;
        private int age;

        // Constructors/Create object
        public Student(string name, string email, string password, int floorNr, int roomNr)
            : base(name, email, password)
        {
            this.FloorNr = floorNr;
            this.RoomNr = roomNr;
            this.Balance = 0;
            this.Score = 0;
        }

        // Properties
        public int BirthYear { get; private set; }
        public string PhoneNumber { get; set; }
        public int FloorNr { get; set; }
        public int RoomNr { get; set; }
        public int Score { get; set; }
        public double Balance
        {
            get { return this.balance; }
            set
            {
                if(value > 0)
                {
                    this.balance = value;
                }
            }
        }
        public int Age
        {
            get 
            {
                if(BirthYear != 0)
                {
                    int currentYear = DateTime.Now.Year;
                    return currentYear - BirthYear;
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                int currentYear = DateTime.Now.Year;
                if(value > 0 && value <= 30)
                {
                    this.Age = value;
                    this.BirthYear = (currentYear - Age);
                }
            }
        }

        public void UpdateInfo(string name, int age, string email, string password, string phone)
        {
            int currentYear = DateTime.Now.Year;
            this.Name = name;
            this.BirthYear = currentYear - age;
            this.Email = email;
            this.Password = password;
            this.PhoneNumber = phone;
        }

        public void UpdateScore(int newScore)
        {
            this.Score += newScore;
        }
    }
}
