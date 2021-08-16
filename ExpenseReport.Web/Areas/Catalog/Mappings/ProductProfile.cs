using ExpenseReport.Application.Features.Products.Commands.Create;
using ExpenseReport.Application.Features.Products.Commands.Update;
using ExpenseReport.Application.Features.Products.Queries.GetAllCached;
using ExpenseReport.Application.Features.Products.Queries.GetById;
using ExpenseReport.Web.Areas.Catalog.Models;
using AutoMapper;

namespace ExpenseReport.Web.Areas.Catalog.Mappings
{
    internal class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<GetAllProductsCachedResponse, ProductViewModel>().ReverseMap();
            CreateMap<GetProductByIdResponse, ProductViewModel>().ReverseMap();
            CreateMap<CreateProductCommand, ProductViewModel>().ReverseMap();
            CreateMap<UpdateProductCommand, ProductViewModel>().ReverseMap();
        }
    }
}