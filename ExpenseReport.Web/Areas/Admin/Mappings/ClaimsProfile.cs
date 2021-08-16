using ExpenseReport.Web.Areas.Admin.Models;
using AutoMapper;
using System.Security.Claims;

namespace ExpenseReport.Web.Areas.Admin.Mappings
{
    public class ClaimsProfile : Profile
    {
        public ClaimsProfile()
        {
            CreateMap<Claim, RoleClaimsViewModel>().ReverseMap();
        }
    }
}