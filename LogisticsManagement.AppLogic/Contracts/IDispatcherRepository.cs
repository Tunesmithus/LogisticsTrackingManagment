using LogisticsManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsManagement.AppLogic.Contracts
{
    public interface IDispatcherRepository:IGenericRepository<Dispatcher>
    {
        void Update(Dispatcher dispatcher);
    }
}
