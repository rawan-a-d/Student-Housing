using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Date
    {
        private static int autoIncId = 1;

        // Constructor
        public Date(DateTime date)
        {
            this.Id = autoIncId;
            this.TaskDate = date;
            autoIncId++;
        }

        // Properties
        public int Id { get; }
        public DateTime TaskDate { get; }
    }
}
