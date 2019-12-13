using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class HouseRule
    {
        private static int autoIncId = 1;
        private int id;
        private DateTime dateCreated;
        private string rule;

        // Constructor
        public HouseRule(DateTime dateCreated, string rule )
        {
            this.id = autoIncId;
            this.dateCreated = dateCreated;
            this.rule = rule;
            autoIncId++;
        }


        // Methods
        // Update house rule
        public void UpdateHouseRule(int id, string updatedRule)
        {
            this.rule = updatedRule;
        }

        // Get methods
        public int GetId()
        {
            return id;
        }

        public string GetRule()
        {
            return rule;
        }

        public DateTime GetDateCreated()
        {
            return dateCreated;
        }
    }
}
