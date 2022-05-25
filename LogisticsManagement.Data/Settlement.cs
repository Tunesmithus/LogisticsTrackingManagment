using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsManagement.Data
{
    public class Settlement
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string SettlementNumber { get; set; }

        [Required]
        public DateTime DateCreated { get; set; }

        [Required]
        public DateTime PayrollStartDate { get; set; }

        [Required]
        public DateTime PayrollEndDate { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Expenses { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal AdditionalDriverPay { get;set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Deductions { get; set; }

        [Column(TypeName = "decimal(18,2)")]

        
        public decimal SettlementTotal { get; set; }
        public string DriverInternalNote { get; set; }
        public string DriverSettlementNote { get; set; }


        //Navigation Properties

        [Required]
        public int DriverId { get; set; }

        [ForeignKey("DriverId")]
        public Driver Driver { get; set; }

        [Required]
        public int TruckId { get; set; }

        [ForeignKey("TruckId")]
        public Truck Truck { get; set; }

        [Required]
        public int TrailerId { get; set; }

        [ForeignKey("TrailerId")]
        public Trailer Trailer { get; set; }

        [Required]
        public int LoadId { get; set; }

        [ForeignKey("LoadId")]
        public Load Load { get; set; }

        [Required]
        public int BrokerId { get; set; }

        [ForeignKey("BrokerId")]
        public Broker Broker { get; set; }

        [Required]
        public int DispatcherId { get; set; }

        [ForeignKey("DispatcherId")]
        public Dispatcher Dispatcher { get; set; }

    }
}
