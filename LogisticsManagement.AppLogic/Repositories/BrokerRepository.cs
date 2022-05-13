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
    public class BrokerRepository:GenericRepository<Broker>, IBrokerRepository
    {
        private readonly ApplicationDbContext context;

        public BrokerRepository(ApplicationDbContext context): base(context)
        {
            this.context = context;
        }

        public void Update(Broker broker)
        {
           context.Update(broker);
        }
    }
}
