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
    public class ExpenseTypeRepository:GenericRepository<ExpenseType>, IExpenseTypeRepository
    {
        private readonly ApplicationDbContext context;

        public ExpenseTypeRepository(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }

        public void Update(ExpenseType expenseType)
        {
           
            context.ExpenseTypes.Update(expenseType);
            
        }
    }


    
}
