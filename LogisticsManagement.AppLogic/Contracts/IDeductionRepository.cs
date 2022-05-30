using LogisticsManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsManagement.AppLogic.Contracts
{
    public interface IDeductionRepository:IGenericRepository<Deduction>
    {
        void Update(Deduction deduction);
    }
}
