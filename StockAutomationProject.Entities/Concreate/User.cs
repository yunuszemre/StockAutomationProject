﻿using StockAutomationProject.Entities.Abstract;
using StockAutomationProject.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAutomationProject.Entities.Concreate
{
    public class User : BaseEntity
    {
        public User()
        {
            this.Orders = new List<Order>();
        }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserEmail { get; set; }

        public string Password { get; set; }

        public DateTime? BirthDate { get; set; }

        public string? PhotoUrl { get; set; }
        public string UserName { get; set; }
        public string? Phone { get; set; }

        [MaxLength(500)]
        public string? Adress { get; set; }
        public Role Role { get; set; }

        public virtual List<Order> Orders { get; set; }


    }
}
