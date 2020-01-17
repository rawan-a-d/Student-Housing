using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Poll
    {
        private int voterId;
        private PollType answer;

        // Constructor
        public Poll(int voterId, PollType answer)
        {
            this.voterId = voterId;
            this.answer = answer;
        }

        // Properties
        public int VoterId
        {
            get { return voterId; }
        }

        public PollType Answer
        {
            get { return answer; }
        }
    }
}
