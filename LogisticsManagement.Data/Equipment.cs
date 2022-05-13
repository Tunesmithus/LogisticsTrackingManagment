using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsManagement.Data
{
    public class Equipment
    {
        [Key]
        public int Id { get; set; }


        public int Year { get; set; }

        public string Make { get; set; }

        [Required]
        [Display(Name ="Equipment #")]
        public int EquipmentNumber { get; set; }

        [Display(Name = "VIN")]

        public string VinNumber { get; set; }

        [Display(Name = "License Plate")]

        public string LicensePlateNumber { get; set; }

        public string Color { get; set; }

        [Display(Name = "Notes")]

        public string Description { get; set; }

    }
}
