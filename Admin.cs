﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Admin: User
    {
        public Admin(string name, string email, string password)
            : base(name, email, password)
        {
      
        }
    }
}
