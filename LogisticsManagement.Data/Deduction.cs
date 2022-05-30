﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsManagement.Data
{
    public class Deduction
    {
        public int Id { get; set; }

        [Display(Name = "Date Of Expense")]
        public DateTime DateOfExpense { get; set; }
        public string? Description { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }

        public int Odometer { get; set; }

        public string? Notes { get; set; }


        //Navigation Properties
        [Display(Name = "Expense Category")]
        public int ExpenseTypeId { get; set; }

        [ForeignKey("ExpenseTypeId")]
        public ExpenseType ExpenseType { get; set; }

        [Display(Name = "Driver")]
        public int DriverId { get; set; }

        [ForeignKey("DriverId")]
        public Driver Driver { get; set; }

        [Display(Name = "Load Number")]
        public int LoadId { get; set; }

        [ForeignKey("LoadId")]

        public Load Load { get; set; }

        [Display(Name = "Truck")]
        public int TruckId { get; set; }

        [ForeignKey("TruckId")]

        public Truck Truck { get; set; }

        [Display(Name = "Trailer")]
        public int TrailerId { get; set; }

        [ForeignKey("TrailerId")]

        public Trailer Trailer { get; set; }
    }
}