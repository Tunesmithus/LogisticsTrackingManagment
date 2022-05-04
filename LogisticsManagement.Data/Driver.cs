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
        public string? StreetAddress { get; set; }

        public string? City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateTime ApplicationDate { get; set; }

        public DateTime HireDate { get; set; }

        public string EmergencyContact { get; set; }

        public string EmergencyContactPhone { get; set; }

        public string DriverNotes { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal DriverPay { get; set; }


        //Relationships

        public List<Load> Loads { get; set; }


    }
}
