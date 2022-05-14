﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsManagement.Data
{
    public class Trailer:Equipment
    {
        public TrailerType TrailerType { get; set; }

        //public string TypeOfTrailer { get; set; }
        [ValidateNever]
        public List<Load> Loads { get; set; }
    }
}
