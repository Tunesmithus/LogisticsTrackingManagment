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
    public class TrucksRepository : GenericRepository<Truck>, ITrucksRepository
    {
        private readonly ApplicationDbContext context;

        public TrucksRepository(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }
        public void Update(Truck truck)
        {
            context.Trucks.Update(truck);
        }
    }
}
