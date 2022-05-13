using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace LogisticsManagement.Common.StaticUtility
{
    public static class StaticList
    {
        

        public static IEnumerable<SelectListItem> GetStates()
        {
            List<SelectListItem> states = new ()
            {
                new SelectListItem() { Text = "Alabama", Value = "AL" },
                new SelectListItem() { Text = "Alaska", Value = "AK" },
                new SelectListItem() { Text = "Arizona", Value = "AZ" },
                new SelectListItem() { Text = "Arkansas", Value = "AR" },
                new SelectListItem() { Text = "California", Value = "CA" },
                new SelectListItem() { Text = "Colorado", Value = "CO" },
                new SelectListItem() { Text = "Connecticut", Value = "CT" },
                new SelectListItem() { Text = "District of Columbia", Value = "DC" },
                new SelectListItem() { Text = "Delaware", Value = "DE" },
                new SelectListItem() { Text = "Florida", Value = "FL" },
                new SelectListItem() { Text = "Georgia", Value = "GA" },
                new SelectListItem() { Text = "Hawaii", Value = "HI" },
                new SelectListItem() { Text = "Idaho", Value = "ID" },
                new SelectListItem() { Text = "Illinois", Value = "IL" },
                new SelectListItem() { Text = "Indiana", Value = "IN" },
                new SelectListItem() { Text = "Iowa", Value = "IA" },
                new SelectListItem() { Text = "Kansas", Value = "KS" },
                new SelectListItem() { Text = "Kentucky", Value = "KY" },
                new SelectListItem() { Text = "Louisiana", Value = "LA" },
                new SelectListItem() { Text = "Maine", Value = "ME" },
                new SelectListItem() { Text = "Maryland", Value = "MD" },
                new SelectListItem() { Text = "Massachusetts", Value = "MA" },
                new SelectListItem() { Text = "Michigan", Value = "MI" },
                new SelectListItem() { Text = "Minnesota", Value = "MN" },
                new SelectListItem() { Text = "Mississippi", Value = "MS" },
                new SelectListItem() { Text = "Missouri", Value = "MO" },
                new SelectListItem() { Text = "Montana", Value = "MT" },
                new SelectListItem() { Text = "Nebraska", Value = "NE" },
                new SelectListItem() { Text = "Nevada", Value = "NV" },
                new SelectListItem() { Text = "New Hampshire", Value = "NH" },
                new SelectListItem() { Text = "New Jersey", Value = "NJ" },
                new SelectListItem() { Text = "New Mexico", Value = "NM" },
                new SelectListItem() { Text = "New York", Value = "NY" },
                new SelectListItem() { Text = "North Carolina", Value = "NC" },
                new SelectListItem() { Text = "North Dakota", Value = "ND" },
                new SelectListItem() { Text = "Ohio", Value = "OH" },
                new SelectListItem() { Text = "Oklahoma", Value = "OK" },
                new SelectListItem() { Text = "Oregon", Value = "OR" },
                new SelectListItem() { Text = "Pennsylvania", Value = "PA" },
                new SelectListItem() { Text = "Rhode Island", Value = "RI" },
                new SelectListItem() { Text = "South Carolina", Value = "SC" },
                new SelectListItem() { Text = "South Dakota", Value = "SD" },
                new SelectListItem() { Text = "Tennessee", Value = "TN" },
                new SelectListItem() { Text = "Texas", Value = "TX" },
                new SelectListItem() { Text = "Utah", Value = "UT" },
                new SelectListItem() { Text = "Vermont", Value = "VT" },
                new SelectListItem() { Text = "Virginia", Value = "VA" },
                new SelectListItem() { Text = "Washington", Value = "WA" },
                new SelectListItem() { Text = "West Virginia", Value = "WV" },
                new SelectListItem() { Text = "Wisconsin", Value = "WI" },
                new SelectListItem() { Text = "Wyoming", Value = "WY" }
            };

            return states;
        }

        public static IEnumerable<SelectListItem> GetTruckMakes()
        {
            List<SelectListItem> truckMakes = new List<SelectListItem>()
            {
                new SelectListItem() {Text = "Freightliner", Value = "Freightliner"},
                new SelectListItem() {Text = "Kenworth", Value = "Kenworth"},
                new SelectListItem() {Text = "Volvo", Value = "Volvo"},
                new SelectListItem() {Text = "Mack", Value = "Mack"},
                new SelectListItem() {Text = "International", Value = "International"},
                new SelectListItem() {Text = "Western Star", Value = "Western Star"},
                new SelectListItem() {Text = "Iszu", Value = ""},
                new SelectListItem() {Text = "Paccar", Value = "Paccar"},

            };
            
            return truckMakes;
        }

        public static IEnumerable<SelectListItem> GetTrailerMakes()
        {
            List<SelectListItem> trailerMakes = new List<SelectListItem>()
            {
                new SelectListItem() {Text = "Utility", Value="Utility Trailer Manufacturing Company"},
                new SelectListItem() {Text = "Wabash", Value="Wabash"},
                new SelectListItem() {Text = "Hyundai", Value="Hyundai Translead"},
                new SelectListItem() {Text = "Vanguard", Value="Vanguard"},
                new SelectListItem() {Text = "Timpte", Value="Timpte"},
                new SelectListItem() {Text = "MAC", Value="MAC Trailer Manufacturing"},
                new SelectListItem() {Text = "Felling", Value="Felling Trailers Inc"},
                new SelectListItem() {Text = "Trail King", Value="Trail King Industries"},
                new SelectListItem() {Text = "Reitnouer", Value="Reitnouer Inc"},
                new SelectListItem() {Text = "East Manufacturing", Value="East Manufacturing Corporation"},
                new SelectListItem() {Text = "Transcraft", Value="Transcraft Corporation"},
                new SelectListItem() {Text = "Stoughton", Value="Stoughton Trailers"},
                new SelectListItem() {Text = "Pitts", Value="Pitts Trailers"},
                new SelectListItem() {Text = "Strick", Value="Strick Trailers LLC"},
                new SelectListItem() {Text = "Benson", Value="Benson Trailers"},
                new SelectListItem() {Text = "Fontaine", Value="Fontaine Commercial Trailer Inc"},
                new SelectListItem() {Text = "Premier", Value="Premire Trailer Manufacturing"}

            };


            return trailerMakes;
        }

        public static IEnumerable<SelectListItem> GetTrailerType()
        {
            List<SelectListItem> trailerType = new List<SelectListItem>()
            {
                new SelectListItem() {Text="Dry Van", Value = "Dry Van"},
                new SelectListItem() {Text="Reefer", Value = "Reefer"},
                new SelectListItem() {Text="FlatBed", Value = "FlatBed"},
                new SelectListItem() {Text="Low Boy", Value = "Low Boy"},
                new SelectListItem() {Text="Step Deck", Value = "Step Deck"},
                new SelectListItem() {Text="Dump", Value = "Dump"},
                new SelectListItem() {Text="Tanker", Value = "Tanker"},
                new SelectListItem() {Text="Tipper", Value = "Tipper"},
                new SelectListItem() {Text="Other", Value = "Other"}
                
            };

            return trailerType;
        }

        public static IEnumerable<SelectListItem> GetColors()
        {
            List<SelectListItem> colorList = new List<SelectListItem>()
            {
                new SelectListItem() {Text="Red", Value="Red"},
                new SelectListItem() {Text="White", Value="White"},
                new SelectListItem() {Text="Blue", Value="Blue"},
                new SelectListItem() {Text="Orange", Value="Orange"},
                new SelectListItem() {Text="Black", Value="Black"},
                new SelectListItem() {Text="Green", Value="Green"},
                new SelectListItem() {Text="Purple", Value="Purple"},
                new SelectListItem() {Text="Pink", Value="Pink"},
                new SelectListItem() {Text="Yellow", Value="Yellow"},
            };

            return colorList;
        }

        public static List<SelectListItem> GetYearList()
        {
            int yearMax = 2050;
            int yearMin = 1999;
            List<SelectListItem> yearList = new List<SelectListItem>();

            for (int i = yearMin; i < yearMax; i++)
            {
                yearList.Add(new SelectListItem() { Text= i.ToString(), Value= i.ToString() });
            }

            return yearList;
        }


    }
}
