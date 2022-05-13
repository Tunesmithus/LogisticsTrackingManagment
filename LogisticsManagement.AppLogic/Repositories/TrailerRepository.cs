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
    public class TrailerRepository:GenericRepository<Trailer>, ITrailerRepository
    {
        private readonly ApplicationDbContext context;

        public TrailerRepository(ApplicationDbContext context):base(context)
        {
            this.context = context;
        }

        public void Update(Trailer trailer)
        {
            context.Trailers.Update(trailer);
        }
    }
}
