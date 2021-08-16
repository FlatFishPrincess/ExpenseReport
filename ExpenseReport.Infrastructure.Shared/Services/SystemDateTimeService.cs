using ExpenseReport.Application.Interfaces.Shared;
using System;

namespace ExpenseReport.Infrastructure.Shared.Services
{
    public class SystemDateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}