using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsManagement.Data
{
    public class Load
    {
        public int Id { get; set; }

        public string LoadNumber { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int LoadedMiles { get; set; }

        public int UnloadedMiles { get; set; }

        public int BobTailMiles { get; set; }

        public int OtherMiles { get; set; }

        [Column(TypeName ="decimal(18,2)")]
        public decimal LoadPay { get; set; }

        public double CargoWeight { get; set; }

        public string? CargoDescription { get; set; }


        //Relationships

        public int BrokerId { get; set; }

        [ForeignKey("BrokerId")]
        public Broker Broker { get; set; }

        public int DriverId { get; set; }

        [ForeignKey("DriverId")]
        public Driver Driver { get; set; }

        public int TruckId { get; set; }

        [ForeignKey("TruckId")]
        public Truck Truck { get; set; }


        public int TrailerId { get; set; }

        [ForeignKey("TrailerId")]
        public Trailer Trailer { get; set; }

        public int DispatcherId { get; set; }

        [ForeignKey("DispatcherId")]
        public Dispatcher Dispatcher { get; set; }






    }
}
