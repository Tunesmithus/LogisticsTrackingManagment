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
    public class DriversRepository:GenericRepository<Driver>, IDriversRepository
    {
        private readonly ApplicationDbContext context;

        public DriversRepository(ApplicationDbContext context): base(context)
        {
            this.context = context;
        }

        public void Update(Driver driver)
        {
            context.Update(driver);
        }
    }
}
