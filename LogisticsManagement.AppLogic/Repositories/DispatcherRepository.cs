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
    public class DispatcherRepository:GenericRepository<Dispatcher>, IDispatcherRepository
    {
        private readonly ApplicationDbContext context;

        public DispatcherRepository(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }

        public void Update(Dispatcher dispatcher)
        {
            var dispatcherFromDb = context.Dispatchers.FirstOrDefault(x => x.Id == dispatcher.Id);

            if (dispatcherFromDb != null)
            {
                dispatcherFromDb.Name = dispatcher.Name;
                dispatcherFromDb.DispatchFee = dispatcher.DispatchFee;

            }
           
            //context.Dispatchers.Update(dispatcher);
            
            
        }
    }


    
}
