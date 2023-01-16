﻿using StockAutomationProject.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAutomationProject.Entities.Concreate
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string? UserEmail { get; set; }

        public string Password { get; set; }

        public DateTime? BirthDate { get; set; }

        public string UserName { get; set; }

    }
}
