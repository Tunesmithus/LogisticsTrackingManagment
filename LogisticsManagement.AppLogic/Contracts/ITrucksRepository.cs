using LogisticsManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsManagement.AppLogic.Contracts
{
    public interface ITrucksRepository: IGenericRepository<Truck>
    {
        void Update(Truck truck);
    }
}
