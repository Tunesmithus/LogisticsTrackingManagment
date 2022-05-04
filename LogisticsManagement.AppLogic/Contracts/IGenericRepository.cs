using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsManagement.AppLogic.Contracts
{
    public interface IGenericRepository<T>
    {
        IEnumerable<T> GetAll();
        T GetFirstOrDefault(Expression<Func<T, bool>> filter);

        void AddAsync(T entity);

        void Remove(T entity);

        void RemoveRange(IEnumerable<T> entity);

    }
}
