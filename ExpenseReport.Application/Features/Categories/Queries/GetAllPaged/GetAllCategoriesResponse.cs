using ExpenseReport.Domain.Entities.Expense;
using System.Collections.Generic;

namespace ExpenseReport.Application.Features.Categories.Queries.GetAllCached
{
    public class GetAllCategoriesResponse
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public ICollection<ClaimItem>? ClaimItems { get; set; }
    }
}