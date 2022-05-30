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

        [Required]
        [DisplayName("Start Date")]
        [DataType(DataType.Date)]

        public DateTime StartDate { get; set; }

        [Required]
        [DisplayName("End Date")]
        public DateTime EndDate { get; set; }

        [Required]
        [DisplayName("Paid Miles")]
        public int LoadedMiles { get; set; }

        [Required]
        [DisplayName("Unpaid Miles")]
        public int UnloadedMiles { get; set; }

        [DisplayName("Bobtail Miles")]
        public int BobTailMiles { get; set; }

        [DisplayName("Other Miles")]
        public int OtherMiles { get; set; }

        [Required]
        [Column(TypeName ="decimal(18,2)")]
        [DisplayName("Load Pay")]
        public decimal LoadPay { get; set; }

        [DisplayName(" Cargo Weight")]
        public double CargoWeight { get; set; }

        [DisplayName("Cargo Description")]
        public string? CargoDescription { get; set; }

        public string FullLoadDescription
        {
            get
            {
                return $"{StartDate} -- {LoadNumber} -- ${LoadPay}";
            }
        }


        //Relationships
        [Required]
        [DisplayName("Broker")]
        public int BrokerId { get; set; }

        
        [ForeignKey("BrokerId")]
        public Broker Broker { get; set; }

        [Required]
        [DisplayName("Driver")]
        public int DriverId { get; set; }

        [ForeignKey("DriverId")]
        public Driver Driver { get; set; }

        [Required]
        [DisplayName("Truck")]
        public int TruckId { get; set; }

        [ForeignKey("TruckId")]
        public Truck Truck { get; set; }

        [Required]
        [DisplayName("Trailer")]
        public int TrailerId { get; set; }

        [ForeignKey("TrailerId")]
        public Trailer Trailer { get; set; }

        [Required]
        [DisplayName("Dispatcher")]
        public int DispatcherId { get; set; }

        [ForeignKey("DispatcherId")]
        public Dispatcher Dispatcher { get; set; }






    }
}
