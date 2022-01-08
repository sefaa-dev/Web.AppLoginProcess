using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LoginProcess.DataAccessLayer.Repository
{
    public interface IRepository<T>
    {
        List<T> List();
        List<T> List(Expression<Func<T, bool>> where);
        int Save();
        int Insert(T obje);
        int Update(T obje);
        int Delete(T obje);
        T Find(Expression<Func<T, bool>> where);
        IQueryable ListQueryable();


    }
}
