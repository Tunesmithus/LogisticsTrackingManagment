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
    public class LoadRepository:GenericRepository<Load>, ILoadRepository
    {
        private readonly ApplicationDbContext context;

        public LoadRepository(ApplicationDbContext context): base(context)
        {
            this.context = context;
        }

        public void update(Load load)
        {
            context.Loads.Update(load);
            
        }
    }
}
