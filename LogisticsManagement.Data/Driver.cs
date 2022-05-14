using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsManagement.Data
{
    public class Driver
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? FirstName { get; set; }

        [Required]
        public string? LastName { get; set; }

        [Required]
        public string? Email { get; set; }

        [Required]
        public string? PhoneNumber { get; set; }

        [Required]
        [Display(Name ="Street Address")]
        public string? StreetAddress { get; set; }

        public string? City { get; set; }

        public string State { get; set; }


        public string ZipCode { get; set; }

        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Application Date")]
        public DateTime ApplicationDate { get; set; }

        [Display(Name = "Hire Date")]
        public DateTime HireDate { get; set; }

        [Display(Name = "Emergency Contact")]
        public string EmergencyContact { get; set; }

        [Display(Name = "Emergency Contact #")]
        public string EmergencyContactPhone { get; set; }


        [Display(Name = "Notes")]
        public string DriverNotes { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Display(Name = "Pay")]
        public decimal DriverPay { get; set; }


        //Relationships
        [ValidateNever]
        public List<Load> Loads { get; set; }


    }
}
