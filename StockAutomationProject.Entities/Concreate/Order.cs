using StockAutomationProject.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAutomationProject.Entities.Concreate
{
    public class Order : BaseEntity
    {
        public Order()
        {
            this.OrderDetails = new List<OrderDetail>();
        }
        [ForeignKey("User")]
        public int UserId { get; set; }

        public User User { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }

    }
}
