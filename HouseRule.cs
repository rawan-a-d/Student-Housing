using System;

namespace Project
{
    class HouseRule
    {
        private static int autoIncId = 1;

        // Constructor
        public HouseRule(DateTime dateCreated, string rule)
        {
            this.Id = autoIncId;
            this.DateCreated = dateCreated;
            this.Rule = rule;
            autoIncId++;
        }

        // Properties
        public int Id { get; }
        public DateTime DateCreated { get; }
        public string Rule { get; private set; }

        // Methods
        // Update house rule
        public void UpdateHouseRule(int id, string updatedRule)
        {
            this.Rule = updatedRule;
        }
    }
}