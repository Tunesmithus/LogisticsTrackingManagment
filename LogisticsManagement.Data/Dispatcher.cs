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
    public class Dispatcher
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name ="Dispatch Fee")]
        [Range(0.01, 0.20)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal DispatchFee { get; set; }

        [NotMapped]
        [ValidateNever]
        public List<Load> Loads { get; set; }
    }
}
