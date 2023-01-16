using StockAutomationProject.Entities.Concreate;
using StockAutomationProject.Repositories.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAutomationProject.Repositories.Concreate
{
    public class CategoryRepository : GenericRepository<Category>
    {
        private readonly StockAutomationContext _context;

        public CategoryRepository(StockAutomationContext context) : base(context)
        {
            this._context = context;
        }

        public List<Category> GetAllCategories()
        {
            return 
        }
    }
}
