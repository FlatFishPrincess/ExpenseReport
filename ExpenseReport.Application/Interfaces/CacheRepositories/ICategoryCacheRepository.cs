using ExpenseReport.Domain.Entities.Expense;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExpenseReport.Application.Interfaces.CacheRepositories
{
    public interface ICategoryCacheRepository
    {
        Task<List<Category>> GetCachedListAsync();

        Task<Category> GetByIdAsync(int categoryId);
    }
}