using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsManagement.Data
{
    public class Trailer:Equipment
    {

        [Display(Name ="Type")]
        public TrailerType TrailerType { get; set; }

        public string FullTrailerDescription
        {
            get { return $"{Year} {Make} {TrailerType} ({EquipmentNumber})"; }
        }

        //public string TypeOfTrailer { get; set; }
        [ValidateNever]
        public List<Load> Loads { get; set; }
    }
}
