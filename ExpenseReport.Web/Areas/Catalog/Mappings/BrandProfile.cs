using ExpenseReport.Application.Features.Brands.Commands.Create;
using ExpenseReport.Application.Features.Brands.Commands.Update;
using ExpenseReport.Application.Features.Brands.Queries.GetAllCached;
using ExpenseReport.Application.Features.Brands.Queries.GetById;
using ExpenseReport.Web.Areas.Catalog.Models;
using AutoMapper;

namespace ExpenseReport.Web.Areas.Catalog.Mappings
{
    internal class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<GetAllBrandsCachedResponse, BrandViewModel>().ReverseMap();
            CreateMap<GetBrandByIdResponse, BrandViewModel>().ReverseMap();
            CreateMap<CreateBrandCommand, BrandViewModel>().ReverseMap();
            CreateMap<UpdateBrandCommand, BrandViewModel>().ReverseMap();
        }
    }
}