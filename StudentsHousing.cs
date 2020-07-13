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
        private List<Agreement> agreements;
        private List<GroceryItem> groceryList;
        private List<GroceryHistory> groceryHistories;
        private List<Event> events;
        private static StudentsHousing instance = null;
        // Current user
        private Student currentStudent;
        private Admin currentAdmin;
        private Student student;
        private HouseRule houseRule;
        private Message message;
        private Agreement agreement;
        private GroceryItem groceryItem;
        private GroceryHistory groceryHistory;
        private int studentWithHighestScore;


        // Constructor
        public StudentsHousing()
        {
            // Initialize lists
            students = new List<Student>();
            admins = new List<Admin>();
            houseRules = new List<HouseRule>();
            messages = new List<Message>();
            dates = new List<Date>();
            schedules = new List<Schedule>();
            agreements = new List<Agreement>();
            groceryList = new List<GroceryItem>();
            groceryHistories = new List<GroceryHistory>();
            events = new List<Event>();
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

        public Student FindStudentById(int studentId)
        {
            foreach (var student in students)
            {
                if (student.Id == studentId)
                {
                    return student;
                }
            }

            return null;
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
            foreach (var student in students)
            {
                if (student.Name == name)
                {
                    return student.Id;
                }
            }

            return 0;
        }

        private bool StudentExists(string email)
        {
            foreach (var student in students)
            {
                if(student.Email == email)
                {
                    return true;
                }
            }
            return false;
        }

        public void UpdateStudentInfo(int studentId, string name, int age, string email, string password, string phone)
        {
            foreach (var student in students)
            {
                if (student.Id == studentId)
                {
                    student.UpdateInfo(name, age, email, password, phone);
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
            foreach (var admin in admins)
            {
                if (admin.Email == email)
                {
                    return true;
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
                    message.UpdateReply(reply);
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

        private void AddAgreementToList(Agreement agreement)
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


        /* Grocery List */
        // Add grocery item
        public void CreateGroceryItem(int amount, string item, string creator)
        {
            groceryItem = new GroceryItem(amount, item, creator);
            AddGroceryItemToList(groceryItem);
        }
            
        private void AddGroceryItemToList(GroceryItem groceryItem)
        {
            groceryList.Add(groceryItem);
        }

        // Remove grocery item
        public void RemoveGroceryItemById(int id)
        {
            for (int i = 0; i < groceryList.Count; i++)
            {
                if (groceryList[i].Id == id)
                {
                    groceryList.Remove(groceryList[i]);
                }
            }
        }

        public void ClearGroceryList()
        {
            groceryList.Clear();
        }

        private string GetGroceryListItems()
        {
            string s = "";
            foreach (var item in groceryList)
            {
                s = s + $"{item.Amount}x {item.ItemName} ({item.Creator})." + "\n";
            }
            return s;
        }

        // Get list
        public List<GroceryItem> GetGroceryList()
        {
            return groceryList;
        }


        /* Grocery History */
        public void CreateGroceryHistory(DateTime dateTime, string personResponsible)
        {
            groceryHistory = new GroceryHistory(dateTime, personResponsible, GetGroceryListItems());
            AddGroceryHistoryToList(groceryHistory);
        }

        public void AddGroceryHistoryToList(GroceryHistory groceryHistory)
        {
            groceryHistories.Add(groceryHistory);
        }

        public List<GroceryHistory> GetGroceryHistoryList()
        {
            return groceryHistories;
        }

        public string GetGroceryHistoryInfoById(int id)
        {
            string info = "";
            for (int i = 0; i < groceryHistories.Count; i++)
            {
                if (groceryHistories[i].Id == id)
                {
                    info = groceryHistories[i].Info;
                }
            }
            return info;
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

        public Schedule[] GetScheduleCurrentUser(int studentId)
        {
            List<Schedule> scheduleCurrentUser = new List<Schedule>();
            foreach (var schedule in schedules)
            {
                if (schedule.StudentId == studentId)
                {
                    scheduleCurrentUser.Add(schedule);
                }
            }
            return scheduleCurrentUser.ToArray();
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
            //DateTime startDate = DateTime.Today;
            DateTime startDate = new DateTime(2020, 01, 10);
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
            foreach (var date in dates)
            {
                if (date.Id == dateId)
                {
                    return date.TaskDate;
                }
            }

            return DateTime.Now;
        }

        private int FindDateId(DateTime date)
        {
            foreach (var dateItem in dates)
            {
                if (dateItem.TaskDate == date)
                {
                    return dateItem.Id;
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
            foreach (var schedule in schedules)
            {
                if(schedule.StudentId == studentId && schedule.DateId == dateId)
                {
                    schedule.SetStatus(TaskStatus.Completed);
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
            foreach (var student in students)
            {
                if(student.Score > studentWithHighestScore)
                {
                    studentWithHighestScore = student.Score;
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
            foreach (var schedule in schedules)
            {
                if (schedule.StudentId == studentId && schedule.DateId == dateId)
                {
                    schedule.SetStatus(TaskStatus.NotCompleted);
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
                foreach (var student in students)
                {
                    if (email == student.Email && password == student.Password)
                    {
                        SetCredentials(student);
                        return true;
                    }
                }

                return false;
            }
            // if admin
            else if(userType == "Admin")
            {
                foreach (var admin in admins)
                {
                    if (email == admin.Email && password == admin.Password)
                    {
                        SetCredentials(admin);
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


        /* Events */

        public void CreateEvent(int creatorId, string description, string location, DateTime eventDate)
        {
            Event newEvent = new Event(creatorId, description, location, eventDate);
            AddToEventsList(newEvent);
        }

        public Event[] GetEventsList()
        {
            CountVotes();
            return this.events.ToArray();
        }

        public void AddToEventsList(Event newEvent)
        {
            this.events.Add(newEvent);

        }

        public Event FindEventById(int id)
        {
            for (int i = 0; i < events.Count; i++)
            {
                if (events[i].EventId == id)
                {
                    return events[i];
                }
            }

            return null;
        }

        public bool VoteEvent(int eventId, int voterId, PollType answer)
        {
            Event foundEvent = FindEventById(eventId);

            List<Poll> polls = foundEvent.Polls;

            foreach (var poll in polls)
            {
                // If user already voted
                if (poll.VoterId == voterId)
                {
                    return false;
                }
            }
            // Create poll object
            Poll newPoll = new Poll(voterId, answer);

            // Add it to list
            polls.Add(newPoll);

            foundEvent.VotersNr++;

            return true;
        }

        // Count votes
        public void CountVotes()
        {
            int yesVoters = 0;
            int noVoters = 0;

            foreach (var eventItem in events)
            {
                int votersNr = eventItem.VotersNr;
                foreach (var poll in eventItem.Polls)
                {
                    // If vote is yes
                    if (poll.Answer == PollType.Yes)
                    {
                        yesVoters++;

                    }
                    // If vote is no
                    else
                    {
                        noVoters++;
                    }
                }

                // If there are votes
                if (votersNr > 0)
                { 
                    // Check higher number
                    if (yesVoters >= noVoters)
                    {
                        // Update percentage
                        eventItem.Percentage = $"{100 * yesVoters / votersNr}% YES";
                    }
                    else
                    {
                        // Update percentage
                        eventItem.Percentage = $"{100 * noVoters / votersNr}% NO";
                    }
                }

                // Reset voters
                yesVoters = 0;
                noVoters = 0;
            }
        }

        // Test data
        private void GenerateTestDate()
        {
            // Admins
            Admin admin1, admin2, admin3;
            admin1 = new Admin("Rawan", "rawan@fontys.com", "12345");
            admin2 = new Admin("Baian", "baian@fontys.com", "12345");
            admin3 = new Admin("Femke", "femke@fontys.com", "12345");
            AddAdminToList(admin1);
            AddAdminToList(admin2);
            AddAdminToList(admin3);

            //Students
            Student student1, student2, student3, student4, student5, student6, student7;
            student1 = new Student("Omar", "omar@fontys.com", "12345", 1, 1);
            student2 = new Student("Mark", "mark@fontys.com", "12345", 1, 4); 
            student3 = new Student("Miley", "miley@fontys.com", "12345", 1, 3);
            student4 = new Student("Pieter", "pieter@fontys.com", "12345", 1, 2);
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
            student4.UpdateScore(63);
            student5.UpdateScore(5);
            student6.UpdateScore(12);
            student7.UpdateScore(24);


            // Random DateTime values
            DateTime four_jan = new DateTime(2020, 01, 04);
            DateTime six_jan = new DateTime(2020, 01, 06);
            DateTime seven_jan = new DateTime(2020, 01, 07);
            DateTime ten_jan = new DateTime(2020, 01, 10);
            DateTime thirteen_jan = new DateTime(2020, 01, 13);
            DateTime twinty_jan = new DateTime(2020, 01, 20);


            //Messages
            Message message1, message2, message3, message4, message5, message6, message7, message8, message9, message10;
            message1 = new Message(four_jan, MessageSubject.Question, "How can I make changes to my tenancy agreement?", 3);
            message2 = new Message(six_jan, MessageSubject.Complaint, "The elevator does not work, when will it be repaired?", 5);
            message3 = new Message(six_jan, MessageSubject.Complaint, "People are not cleaning the shared facilities", 3);
            message4 = new Message(seven_jan, MessageSubject.Question, "Why has my rent increased?", 5);
            message5 = new Message(ten_jan, MessageSubject.Complaint, "My neighbors are organizing parties during the week very late at night", 2);
            message6 = new Message(ten_jan, MessageSubject.Question, "How can I speak to my housing officer?", 7);
            message7 = new Message(thirteen_jan, MessageSubject.Question, "Am I due to have my kitchen and bathroom upgraded?", 7);
            message8 = new Message(thirteen_jan, MessageSubject.Question, "How can I report a repair?", 5);
            message9 = new Message(thirteen_jan, MessageSubject.Question, "Hello, I'm pieter and I'm moving to a new apartment, could you please remove my account?", 6);
            message10 = new Message(twinty_jan, MessageSubject.Complaint, "Mark didn't complete his task(Cleaning) on the 15th of january", 6);


            AddMessageToList(message1);
            AddMessageToList(message2);
            AddMessageToList(message3);
            AddMessageToList(message4);
            AddMessageToList(message5);
            AddMessageToList(message6);
            AddMessageToList(message7);
            AddMessageToList(message8);
            AddMessageToList(message9);
            AddMessageToList(message10);

            // agreements
            Agreement agreement1, agreement2, agreement3, agreement4, agreement5, agreement6;
            agreement1 = new Agreement(four_jan, "Mark & Pieter", "Can I use your hairgel?", "Accepted");
            agreement2 = new Agreement(six_jan, "Mark & Everyone", "Please don't wear shoes inside.", "Pending", 1, 4, "->OmarMileyRobinRanim");
            agreement3 = new Agreement(seven_jan, "Miley & Mark", "Please take away your towel and clothes after showering.", "Pending");
            agreement4 = new Agreement(seven_jan, "Mark & Everyone", "Saturday is pizza day!", "Pending", 5, 6, "->OmarMileyKelvinRobinRanimMark");
            agreement5 = new Agreement(ten_jan, "Omar & Everyone", "No loud noises after 11:00PM.", "Pending", 3, 5, "->OmarMileyPieterRobinRanim");
            agreement6 = new Agreement(thirteen_jan, "Pieter & Mark", "Help me with unpacking the groceries.", "Pending");
            AddAgreementToList(agreement1);
            AddAgreementToList(agreement2);
            AddAgreementToList(agreement3);
            AddAgreementToList(agreement4);
            AddAgreementToList(agreement5);
            AddAgreementToList(agreement6);

            // groceries
            GroceryItem item1, item2, item3, item4, item5, item6;
            item1 = new GroceryItem(1, "Olive oil", "Mark");
            item2 = new GroceryItem(8, "Toilet paper", "Robin");
            item3 = new GroceryItem(1, "Detergent", "Miley");
            item4 = new GroceryItem(1, "Chili sauce", "Ranim");
            item5 = new GroceryItem(3, "Wash powder", "Mark");
            item6 = new GroceryItem(4, "Handsoap", "Kelvin");
            AddGroceryItemToList(item1);
            AddGroceryItemToList(item2);
            AddGroceryItemToList(item3);
            AddGroceryItemToList(item4);
            AddGroceryItemToList(item5);
            AddGroceryItemToList(item6);

            // grocery history list
            GroceryHistory history1, history2, history3;
            history1 = new GroceryHistory(four_jan, "Mark", "1x Detergent (Robin).\n3x Air freshener (Miley).\n2xFabric softener (Robin).");
            history2 = new GroceryHistory(seven_jan, "Robin", "2x Soap (Mark).\n1x Rubbing alcohol (Ranim).");
            history3 = new GroceryHistory(ten_jan, "Omar", "4x Sponge (Kelvin).\n2x Toilet cleaner (Mark).\n1x Toilet brush (Mark).");
            AddGroceryHistoryToList(history1);
            AddGroceryHistoryToList(history2);
            AddGroceryHistoryToList(history3);

            // House rules
            HouseRule rule1, rule2, rule3, rule4, rule5, rule6, rule7, rule8, rule9;
            rule1 = new HouseRule(four_jan, "No Smoking");
            //rule2 = new HouseRule(four_jan, "No animals permitted in residence");
            rule3 = new HouseRule(four_jan, "Keep the rooms clean");
            //rule4 = new HouseRule(four_jan, "No fan heaters allowed whatsoever - these can very easily cause fires!");
            rule4 = new HouseRule(four_jan, "No fan heaters allowed whatsoever");

            rule5 = new HouseRule(four_jan, "Please use any off-street parking provided fairly between all housemates.");
            rule6 = new HouseRule(seven_jan, "The supplied furniture may not be removed from your room or the common areas.");
            rule7 = new HouseRule(seven_jan, "Please ensure that all air conditions/heating units are turned off in bedrooms before leaving the house.");
            rule8 = new HouseRule(seven_jan, "Guests must not interfere with the reasonable peace, comfort and privacy of other residents.");
            rule9 = new HouseRule(thirteen_jan, "Report your disturbances to your Resident Assistant and Building Manager");
            AddHouseRuleToList(rule1);
            //AddHouseRuleToList(rule2);
            AddHouseRuleToList(rule3);
            AddHouseRuleToList(rule4);
            AddHouseRuleToList(rule5);
            AddHouseRuleToList(rule6);
            AddHouseRuleToList(rule7);
            AddHouseRuleToList(rule8);
            AddHouseRuleToList(rule9);

            DateTime eighteen_jan = new DateTime(2020, 01, 18);
            DateTime twentysecond_jan = new DateTime(2020, 01, 22);
            DateTime twentyeight_jan = new DateTime(2020, 01, 28);
            DateTime second_feb = new DateTime(2020, 02, 02);

            // Events
            CreateEvent(6, "My birthday party", "Floor 3 common area", eighteen_jan);
            VoteEvent(1, 3, PollType.Yes);
            VoteEvent(1, 4, PollType.Yes);
            VoteEvent(1, 5, PollType.No);
            VoteEvent(1, 1, PollType.No);
            CreateEvent(4, "Hang out", "First floor room 20", twentysecond_jan);
            //CreateEvent(3, "My birthday party", "Floor 3 common area", eighteen_jan);
            //CreateEvent(3, "My birthday party", "Floor 3 common area", eighteen_jan);


        }
    }
}
