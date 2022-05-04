using LogisticsManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsManagement.AppLogic.Contracts
{
    public interface IDriversRepository:IGenericRepository<Driver>
    {
        void Update(Driver driver);
    }
}
