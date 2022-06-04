using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsManagement.AppLogic.Contracts
{
    public interface IUnitOfWork
    {
        IDriversRepository Driver { get; }
        ITrucksRepository Truck { get; }

        ITrailerRepository Trailer { get; }

        IBrokerRepository Broker { get; }
        IDispatcherRepository Dispatcher { get; }

        ILoadRepository Load { get; }

        ISettlementRepository Settlement { get; }

        IExpenseTypeRepository ExpenseType { get; }

        IDeductionRepository Deduction { get; }

        IExpenseRepository Expense { get; }

        void Save();
    }
}
