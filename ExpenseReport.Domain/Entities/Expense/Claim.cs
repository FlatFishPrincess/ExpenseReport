using AspNetCoreHero.Abstractions.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseReport.Domain.Entities.Expense
{
    public class Claim : AuditableEntity
    {
        public string Title { get; set; }
        public string Requester { get; set; }
        public string Approver { get; set; }
        public DateTime SubmitDate { get; set; }
        public DateTime ApprovalTime { get; set; }
        public DateTime ProcessedDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; }
        public string RequestComments { get; set; }
        public string ApproverComments { get; set; }
        public string FinanceComments { get; set; }

        public ICollection<ClaimItem> ClaimItems { get; set; }
    }
}
