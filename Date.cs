using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Date
    {
        private static int autoIncId = 1;
        private int id;
        private DateTime date;

        // Constructor
        public Date(DateTime date)
        {
            this.id = autoIncId;
            this.date = date;
            autoIncId++;
        }

        // Methods
        public int GetId()
        {
            return id;
        }

        public DateTime GetDate()
        {
            return date;
        }
    }
}
