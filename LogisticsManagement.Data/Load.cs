using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsManagement.Data
{
    public class Load
    {
        public int Id { get; set; }

        [DisplayName("Load Number")]
        public string LoadNumber { get; set; }

        [DisplayName("Start Date")]
        [DisplayFormat(DataFormatString = "dd/MM/yyyy")]
        public DateTime StartDate { get; set; }

        [DisplayName("End Date")]
        public DateTime EndDate { get; set; }

        [DisplayName("Paid Miles")]
        public int LoadedMiles { get; set; }

        [DisplayName("Unpaid Miles")]
        public int UnloadedMiles { get; set; }

        [DisplayName("Bobtail Miles")]
        public int BobTailMiles { get; set; }

        [DisplayName("Other Miles")]
        public int OtherMiles { get; set; }

        [Column(TypeName ="decimal(18,2)")]
        [DisplayName("Load Pay")]
        public decimal LoadPay { get; set; }

        [DisplayName(" Cargo Weight")]
        public double CargoWeight { get; set; }

        [DisplayName("Cargo Description")]
        public string? CargoDescription { get; set; }


        //Relationships
        [DisplayName("Broker")]
        public int BrokerId { get; set; }

        [ForeignKey("BrokerId")]
        public Broker Broker { get; set; }

        [DisplayName("Driver")]
        public int DriverId { get; set; }

        [ForeignKey("DriverId")]
        public Driver Driver { get; set; }

        [DisplayName("Truck")]
        public int TruckId { get; set; }

        [ForeignKey("TruckId")]
        public Truck Truck { get; set; }

        [DisplayName("Trailer")]
        public int TrailerId { get; set; }

        [ForeignKey("TrailerId")]
        public Trailer Trailer { get; set; }


        [DisplayName("Dispatcher")]
        public int DispatcherId { get; set; }

        [ForeignKey("DispatcherId")]
        public Dispatcher Dispatcher { get; set; }






    }
}
