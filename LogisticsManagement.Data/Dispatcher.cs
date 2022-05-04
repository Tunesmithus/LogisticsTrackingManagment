using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsManagement.Data
{
    public class Dispatcher
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal DispatchFee { get; set; }

        public List<Load> Loads { get; set; }
    }
}
