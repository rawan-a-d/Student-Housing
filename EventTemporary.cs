using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Event
    {
        private static int IdSeeder = 20000;
        //inctances 
     /*   private int yesCounter;
        private DateTime eventDate;
        private int pollerId;
        private string nameEvent;
        private int numOfPeople;
        private string nameCreator;
        private List<int> pollersId;
        private double votingPercentage;*/



        public Event(int pollerId, string nameCreator, string nameEvent, int numOfPeople, DateTime eventDate)

        {

            PollersId = new List<int>();
            this.NameCreator = nameCreator;
            this.NameEvent = nameEvent;
            this.NumOfPeople = numOfPeople;
            this.PollerId = pollerId;
            this.EventDate = eventDate;
            this.YesCounter = 1;
            this.EventId = IdSeeder++;
            PollersId.Add(pollerId);

        }
        //proprties

        public int EventId { get ; set; }
        public int PollerId { get; set; }
        public List<int> PollersId { get; set; }
        public int YesCounter { get; set; }
        public double VotingPercentage { get; set; }
        public string NameCreator { get; set; }
        public string NameEvent { get; set; }
        public int NumOfPeople { get; set; }
        public DateTime EventDate { get; set; }


          //methodes ps: "you can just copy paste methodes in studenthousin class after adding list of events there"

         public void CreateEvent(int pollerId, string nameCreator, string nameEvent, int numOfPeople, DateTime eventDate) 
        {
            anEvent = new Event( pollerId, nameCreator,  nameEvent,  numOfPeople, eventDate);
            AddToEventsList( anEvent);
            Voting(true, pollerId, anEvent.EventId);


        }
        public int GetByDescription(string description) 
        {
            int selectedId;
            foreach (Event e in events)
            {
                if (e.NameEvent == description)
                {
                    selectedId = e.EventId;
                    return selectedId;
                }
            } 

            return -1;
        }
      
        public List<Event> GetEventsList() 
        {
            return this.events;
        }
        public void AddToEventsList(Event anEvent) 
        {
            this.events.Add(anEvent);

        }
        public void AddPollerIdToList( int currentPollerId)
        {
           anEvent.PollersId.Add(currentPollerId);


        }
        public void Voting(bool vote, int currentPollerId, int selectedeventId)
        {   foreach ( Event e in events)
            {
                List<int> pollersList = new List<int>();
                

                if (e.EventId == selectedeventId)
                {
                    pollersList = e.PollersId;

                    foreach (int p in pollersList)
                    {
                        if (p != currentPollerId)
                        {
                            AddPollerIdToList(currentPollerId);
                            pollersList = e.PollersId;
                            if (vote == true)
                            {

                                e.YesCounter++;
                                double voting = (e.YesCounter / pollersList.Count) * 100.0;
                                e.VotingPercentage = voting;

                            }
                            else if (vote == false)
                            {
                               
                                double voting = (e.YesCounter / pollersList.Count) * 100.0;
                                e.VotingPercentage = voting;

                            }
                        }
                        else
                        {
                            double voting = (e.YesCounter / pollersList.Count) * 100.0;
                            e.VotingPercentage = voting;
                        }
                    }
                   
                }
            
            }
        }

        /*// form code
         InitializeComponent();
            // update
            if (studentsHousing.GetEventsList() != null) { UpdateEventList(); }
    //methode form

    public void UpdateEventList()
        {
            // Event list
            List<Event> events = studentsHousing.GetEventsList();

            // Clear list view
            dgvEvents.Rows.Clear();
            // Display events
            foreach (var e in events)
            {
                // Create new rows
                DataGridViewRow row = (DataGridViewRow)dgvEvents.Rows[0].Clone();

                // Insert data into rows
                row.Cells[0].Value = e.NameEvent.ToString();
                row.Cells[1].Value = (e.EventDate.ToString("dd/MM/yyyy")).ToString();
                row.Cells[2].Value = e.NumOfPeople.ToString();
                row.Cells[3].Value = e.VotingPercentage.ToString();

                // Add the item to grid
                dgvEvents.Rows.Add(row);

                // Text wrap
                dgvEvents.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvEvents.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
        }


        // create button
        private void btn_EventSendRequest_Click(object sender, EventArgs e)
        {
            int pollerId = currentUser.Id ;
            string nameCreator= currentUser.Name;
            string nameEvent = tb_EventDescription.Text;
            int numOfPeople = Convert.ToInt32(tb_EventNumOfPeople.Text);            
            DateTime eventDate = Convert.ToDateTime(DTP_EventDateTime.Value);

            studentsHousing.CreateEvent( pollerId,  nameCreator,  nameEvent, numOfPeople,  eventDate);           
            UpdateEventList();
         
        }

        // yes no bottun
                private void btn_EventVoteSelectedYES_Click(object sender, EventArgs e)
        {
            
            
            if (dgvEvents.SelectedCells.Count <= 0)
            {
                MessageBox.Show("Please select event tp vote on");
            }
            else
            {
                int cuurentId = currentUser.Id;
                bool vote = true;
                string description = dgvEvents.CurrentRow.Cells[0].Value.ToString();
                int eventId = studentsHousing.GetByDescription(description);
                if (eventId == -1) { MessageBox.Show("we doped"); }
                else
                {
                    studentsHousing.Voting(vote, cuurentId, eventId);
                    UpdateEventList();
                }
            }
           
        }

        private void btn_EventVoteSelectedNO_Click(object sender, EventArgs e)
        {
           
            if (dgvEvents.SelectedCells.Count <= 0)
            {
                MessageBox.Show("Please select event tp vote on");
            }
            else
            {
                bool vote = false;
                int cuurentId = currentUser.Id;
                string des = dgvEvents.CurrentRow.Cells[0].Value.ToString();
                int eventId = studentsHousing.GetByDescription(des);
                if (eventId == -1) { MessageBox.Show("we doped"); }
                else
                { studentsHousing.Voting(vote, cuurentId, eventId);
                    UpdateEventList(); }
            }

        }

    */

     }
}
