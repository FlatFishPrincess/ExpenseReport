using ExpenseReport.Domain.Entities.Catalog;
using ExpenseReport.Domain.Entities.Expense;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace ExpenseReport.Application.Interfaces.Contexts
{
    public interface IApplicationDbContext
    {
        IDbConnection Connection { get; }
        bool HasChanges { get; }

        EntityEntry Entry(object entity);

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);

        DbSet<Product> Products { get; set; }
        DbSet<Currency> Currencies { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<Claim> Claims { get; set; }
        DbSet<ClaimItem> ClaimItems { get; set; }

    }
}