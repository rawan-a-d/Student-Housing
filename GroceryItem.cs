using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class GroceryItem
    {
        private static int autoIncId = 1;

        public GroceryItem(int amount, string item, string creator)
        {
            this.Id = autoIncId;
            this.Amount = amount;
            this.ItemName = item;
            this.Creator = creator;
            autoIncId++;
        }

        public int Id { get; private set; }
        public int Amount { get; private set; }
        public string ItemName { get; private set; }
        public string Creator { get; private set; }
    }

    public class GroceryHistory
    {
        private static int autoIncId = 1;

        public GroceryHistory(DateTime dateTime, string personResponsible, string info)
        {
            this.Id = autoIncId;
            this.DateAndTime = dateTime;
            this.PersonResponsible = personResponsible;
            this.Info = info;
            autoIncId++;
        }

        public int Id { get; private set; }
        public DateTime DateAndTime { get; private set; }
        public string PersonResponsible { get; private set; }
        public string Info { get; private set; }
    }
}
