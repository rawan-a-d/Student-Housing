using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Project
{
    public class Event
    {
        private static int idSeeder = 1;

        // Constructor
        public Event(int creatorId, string description, string location, DateTime date)
        {
            this.EventId = idSeeder;
            this.CreatorId = creatorId;
            this.Description = description;
            this.EventDate = date;
            this.Polls = new List<Poll>();
            this.Location = location;
            idSeeder++;
        }

        // Properties
        public int EventId { get; }
        public int CreatorId { get;}
        public string Description { get;}
        public DateTime EventDate { get; }
        public string Location { get;}
        public List<Poll> Polls { get; set; }
        public string Percentage { get; set; }
        public int VotersNr { get; set; }
    }
}
