using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsManagement.Data
{
    public class Equipment
    {
        public int Id { get; set; }
        public int Year { get; set; }

        public string Make { get; set; }

        public int EquipmentNumber { get; set; }

        public string VinNumber { get; set; }

        public string LicensePlateNumber { get; set; }

        public string Color { get; set; }

        public string Description { get; set; }

    }
}
