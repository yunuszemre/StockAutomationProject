using StockAutomationProject.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAutomationProject.Entities.Concreate
{
    public class Supplier:BaseEntity
    {
        public Supplier()
        {
            this.Products= new List<Product>();
        }
        public string SupplierName { get; set; }
        public string SupplierDescription { get; set; }

        public string? Adress { get; set; }

        public string? Phone { get; set; }

        public string? Email { get; set; }

        public List<Product> Products { get; set; }


    }
}
