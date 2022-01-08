using LoginProcess.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LoginProcess.DataAccessLayer.Repository
{
    public class Repository<T> : RepositoryBase, IRepository<T> where T : class
    {
        
        private DbSet<T> dbset;
        public Repository()
        {
            dbset = db.Set<T>();
        }
        public List<T> List()
        {
            return dbset.ToList();
        }
        public List<T> List(Expression<Func<T, bool>> where)
        {
            return dbset.Where(where).ToList();
        }
        public int Save()
        {
            return db.SaveChanges();
        }

        public int Insert(T obje)
        {
            dbset.Add(obje);
            return Save();
        }

        public int Update(T obje)
        {
            return Save();
        }

        public int Delete(T obje)
        {
            dbset.Remove(obje);
            return Save();
        }
        public T Find(Expression<Func<T, bool>> where)
        {
            return dbset.FirstOrDefault(where);
        }

        public IQueryable ListQueryable()
        {
            return dbset.AsQueryable<T>();
        }
    }
}
