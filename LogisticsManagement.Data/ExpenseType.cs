using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsManagement.Data
{
    public class ExpenseType
    {
        public int Id { get; set; }

        [Required]
        [Display(Name ="Expense Category")]
        public string ExpenseCategory { get; set; }

        public string? Description { get; set; }
    }
}
