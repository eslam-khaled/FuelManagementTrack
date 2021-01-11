using FuelManagementTrack.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FuelManagementTrack.DAL.BaseRepositories
{
    public class BaseRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public BaseRepository()
        {
        }

        public T AddNew(T obj)
        {
            _context.Set<T>().Add(obj);
            _context.SaveChanges();
            return obj;
        }

        public void FindById(int id)
        {
            _context.Set<T>().Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Update(T obj)
        {
            _context.Set<T>().Attach(obj);
            _context.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }
        public void Delete(T obj)
        {
            _context.Set<T>().Remove(obj);
            _context.SaveChanges();
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().Where(predicate);
        }
    }
}
