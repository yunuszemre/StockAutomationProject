using StockAutomationProject.Entities.Concreate;
using StockAutomationProject.Repositories.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAutomationProject.Repositories.Concreate
{
    public class ProductRepository : GenericRepository<Product>
    {
        private readonly StockAutomationContext _context;

        public ProductRepository(StockAutomationContext context) : base(context)
        {
            this._context = context;
        }
    }
}
