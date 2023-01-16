using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StockAutomationProject.Repositories.Abstract
{
    public interface IGenericRepository<T> where T : class
    {
        T GetAll();
        T GetById(int id);
        List<T> GetActives();

        bool Activate(int id);
        bool Deactivate(int id);

        IEnumerable<T> Select(Expression<Func<T, bool>> predicate = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
