using ExpenseReport.Application.Features.Brands.Commands.Create;
using ExpenseReport.Application.Features.Brands.Queries.GetAllCached;
using ExpenseReport.Application.Features.Brands.Queries.GetById;
using ExpenseReport.Domain.Entities.Catalog;
using AutoMapper;

namespace ExpenseReport.Application.Mappings
{
    internal class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<CreateBrandCommand, Brand>().ReverseMap();
            CreateMap<GetBrandByIdResponse, Brand>().ReverseMap();
            CreateMap<GetAllBrandsCachedResponse, Brand>().ReverseMap();
        }
    }
}