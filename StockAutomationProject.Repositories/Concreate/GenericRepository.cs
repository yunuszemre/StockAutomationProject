using Microsoft.EntityFrameworkCore;
using StockAutomationProject.Entities.Abstract;
using StockAutomationProject.Repositories.Abstract;
using StockAutomationProject.Repositories.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAutomationProject.Repositories.Concreate
{
    
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly StockAutomationContext _context;
        private DbSet<T> _dbSet;

        public GenericRepository(StockAutomationContext context)
        {
            this._context = context;
            _dbSet = _context.Set<T>();
        }

        public bool Activate(int id)
        {
            var activatedEntity = GetById(id);
            if (activatedEntity != null)
            {
                activatedEntity.IsActive = true;
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public bool Deactivate(int id)
        {
            var deactivatedEntity = GetById(id);
            if (deactivatedEntity != null)
            {
                deactivatedEntity.IsActive = false;
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Delete(int id)
        {
            var deletedEntity = GetById(id);
            if (deletedEntity != null)
            {
                deletedEntity.IsActive= false;
                _context.SaveChanges();
            }
        }

        public List<T> GetActives()
        {
            
        }

        public T GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
           return _dbSet.Find(id);
        }

        public IEnumerable<T> Select(System.Linq.Expressions.Expression<Func<T, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
            _context.SaveChanges();
        }
    }
}
