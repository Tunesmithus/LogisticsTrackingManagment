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
    public class SettlementRepository : GenericRepository<Settlement>, ISettlementRepository
    {
        private readonly ApplicationDbContext context;

        public SettlementRepository(ApplicationDbContext context): base(context)
        {
            this.context = context;
        }
        public void Update(Settlement settlement)
        {
            context.Settlements.Update(settlement);
        }
    }
}
