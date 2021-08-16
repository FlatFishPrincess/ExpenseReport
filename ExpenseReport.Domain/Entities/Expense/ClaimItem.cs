using AspNetCoreHero.Abstractions.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseReport.Domain.Entities.Expense
{
    public class ClaimItem : AuditableEntity
    {
        public string Payee { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public decimal USDAmount { get; set; }
        public byte[] Receipt { get; set; }
        public int ClaimId { get; set; }
        public Claim Claim { get; set; }
        public int? CategoryId{ get; set; }
        public Category? Category { get; set; }

        public string? CurrencyCode { get; set; }
        public Currency? Currency { get; set; }
    }
}
