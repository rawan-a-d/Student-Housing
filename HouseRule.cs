using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class HouseRule
    {
        private int id;
        private DateTime dateCreated;
        private string rule;

        // Getters and setters
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public DateTime DateCreated
        {
            get { return dateCreated; }
            set { dateCreated = value; }
        }
        public string Rule
        {
            get { return rule; }
            set { rule = value; }
        }

        // Methods
        // Create house rule
        public void AddHouseRule(int id, DateTime date, string rule)
        {
            this.id = id;
            this.dateCreated = date;
            this.rule = rule;
        }

        // Update house rule
        public void UpdateHouseRule(int id, string updatedRule)
        {
            this.rule = updatedRule;
        }
    }
}
