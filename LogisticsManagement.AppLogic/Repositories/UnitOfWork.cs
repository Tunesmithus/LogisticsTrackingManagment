using LogisticsManagement.AppLogic.Contracts;
using LogisticsManagement.Data;
using LogisticsTrackingSoftware.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsManagement.AppLogic.Repositories
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly ApplicationDbContext context;

        public UnitOfWork(ApplicationDbContext context)
        {
            this.context = context;
            Driver = new DriversRepository(context);
            Truck = new TrucksRepository(context);
            Trailer = new TrailerRepository(context);
            Broker = new BrokerRepository(context);
            Dispatcher = new DispatcherRepository(context);
            Load = new LoadRepository(context);
            Settlement = new SettlementRepository(context);
            ExpenseType = new ExpenseTypeRepository(context);
            Deduction = new DeductionRepository(context);
            Expense = new ExpenseRepository(context);

        }

        public IDriversRepository Driver { get; private set; }

        public ITrucksRepository Truck { get; private set; }

        public ITrailerRepository Trailer { get; private set; }
        public IBrokerRepository Broker { get; private set; }
        public IDispatcherRepository Dispatcher { get; private set; }
        public ILoadRepository Load { get; private set; }

        public ISettlementRepository Settlement { get; private set; }

        public IExpenseTypeRepository ExpenseType { get; private set; }

        public IDeductionRepository Deduction { get; private set; }
        public IExpenseRepository  Expense { get; private set; }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
