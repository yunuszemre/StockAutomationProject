using StockAutomationProject.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAutomationProject.Entities.Concreate
{
    public class OrderDetail:BaseEntity
    {
        public OrderDetail()
        {
            this.Products = new List<Product>();
            this.Orders = new List<Order>();
        }

        
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public virtual List<Order> Orders { get; set; }
        public decimal UnitPrice { get; set; }

        public short Quantity { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}
