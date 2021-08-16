using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseReport.Domain.Entities.Expense
{
    public class Currency
    {
        [Key]
        public string Code { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }

        public ICollection<ClaimItem>? ClaimItems { get; set; }
    }
}
