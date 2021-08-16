using ExpenseReport.Application.DTOs.Mail;
using System.Threading.Tasks;

namespace ExpenseReport.Application.Interfaces.Shared
{
    public interface IMailService
    {
        Task SendAsync(MailRequest request);
    }
}