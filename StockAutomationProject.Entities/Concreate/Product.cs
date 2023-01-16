using StockAutomationProject.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAutomationProject.Entities.Concreate
{
    public class Product : BaseEntity
    {
        public Product()
        {
            this.OrderDetails = new List<OrderDetail>();
        }
        public string ProductName { get; set; }

        public string ProductDescription { get; set; }
        public decimal UnitPrice { get; set; }
        public DateTime ExpireDate { get; set; }
        public int Stock { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        [ForeignKey("Supplier")]
        public int SupplierId { get; set; }
        public virtual Supplier Supplier { get;}
        
        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}
