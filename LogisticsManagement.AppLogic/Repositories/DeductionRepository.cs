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
    public class DeductionRepository:GenericRepository<Deduction>, IDeductionRepository
    {
        private readonly ApplicationDbContext context;

        public DeductionRepository(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }

        public void Update(Deduction deduction)
        {
           
            context.Deductions.Update(deduction);
            
        }
    }


    
}
