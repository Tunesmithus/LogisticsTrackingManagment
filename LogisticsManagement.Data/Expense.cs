using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsManagement.Data
{
    public class Expense
    {

        public int Id { get; set; }

        public DateTime DateOfExpense { get; set; }
        public string Description { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }

        public int Odometer { get; set; }

        public string Notes { get; set; }


        //Navigation Properties
        public int ExpenseCategoryId { get; set; }

        [ForeignKey("ExpenseTypeId")]
        public ExpenseType ExpenseType { get; set; }

        public int DriverId { get; set; }

        [ForeignKey("DriverId")]
        public Driver Driver { get; set; }

        public int LoadId { get; set; }

        [ForeignKey("LoadId")]
        public Load Load { get; set; }

        public int TruckId { get; set; }

        [ForeignKey("TruckId")]
        public Truck Truck { get; set; }

        public int TrailerId { get; set; }

        [ForeignKey("TrailerId")]
        public Trailer Trailer { get; set; }
    }
}
