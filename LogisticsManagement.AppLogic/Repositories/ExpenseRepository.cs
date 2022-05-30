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
    public class ExpenseRepository:GenericRepository<Expense>, IExpenseRepository
    {
        private readonly ApplicationDbContext context;

        public ExpenseRepository(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }

        public void Update(Expense expense)
        {
           
            context.Expenses.Update(expense);
            
        }
    }


    
}
