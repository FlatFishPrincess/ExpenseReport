using ExpenseReport.Infrastructure.Identity.Models;
using ExpenseReport.Web.Areas.Admin.Models;
using AutoMapper;

namespace ExpenseReport.Web.Areas.Admin.Mappings
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<ApplicationUser, UserViewModel>().ReverseMap();
        }
    }
}