using AspNetCoreHero.Abstractions.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseReport.Domain.Entities.Expense
{
    public class Category : AuditableEntity
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public ICollection<ClaimItem>? ClaimItems { get; set; }
    }
}
