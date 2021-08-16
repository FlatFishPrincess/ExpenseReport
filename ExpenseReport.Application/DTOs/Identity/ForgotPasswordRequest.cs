using System.ComponentModel.DataAnnotations;

namespace ExpenseReport.Application.DTOs.Identity
{
    public class ForgotPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}