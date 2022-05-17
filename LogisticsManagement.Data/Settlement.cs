using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsManagement.Data
{
    public class Settlement
    {
        public int Id { get; set; }
        public string SettlementNumber { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime MyProperty { get; set; }
        public Decimal SettlementTotal { get; set; }


        //Navigation Properties

        public int DriverId { get; set; }

        [ForeignKey("DriverId")]
        public Driver Driver { get; set; }

        public int TruckId { get; set; }

        [ForeignKey("TruckId")]
        public Truck Truck { get; set; }

        public int TrailerId { get; set; }

        [ForeignKey("TrailerId")]
        public Trailer Trailer { get; set; }

        public int LoadId { get; set; }

        [ForeignKey("LoadId")]
        public Load Load { get; set; }

        public int BrokerId { get; set; }

        [ForeignKey("BrokerId")]
        public Broker Broker { get; set; }

    }
}
