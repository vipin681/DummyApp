﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public  class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public bool IsActive { get; set; }


    }
}
