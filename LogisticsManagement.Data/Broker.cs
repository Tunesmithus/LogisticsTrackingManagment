using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsManagement.Data
{
    public class Broker
    {
        public int Id { get; set; }

        [Display(Name = "Broker Name")]
        public string CompanyName { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        [Display(Name = "Postal Code")]
        public string ZipCode { get; set; }

        //Relationships
        [ValidateNever]
        public List<Load> Loads { get; set; }
    }
}
