using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsManagement.Data
{
    public class Truck:Equipment
    {
        public string Model { get; set; }

        [NotMapped]
        public string FullVehicleDescription
        {
            get { return $"{Year} {Model} ({EquipmentNumber})"; }
        }

        [ValidateNever]
        public List<Load> Loads { get; set; }
    }
}
