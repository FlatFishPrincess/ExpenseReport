using ExpenseReport.Application.Features.Products.Commands.Create;
using ExpenseReport.Application.Features.Products.Queries.GetAllCached;
using ExpenseReport.Application.Features.Products.Queries.GetAllPaged;
using ExpenseReport.Application.Features.Products.Queries.GetById;
using ExpenseReport.Domain.Entities.Catalog;
using AutoMapper;

namespace ExpenseReport.Application.Mappings
{
    internal class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<CreateProductCommand, Product>().ReverseMap();
            CreateMap<GetProductByIdResponse, Product>().ReverseMap();
            CreateMap<GetAllProductsCachedResponse, Product>().ReverseMap();
            CreateMap<GetAllProductsResponse, Product>().ReverseMap();
        }
    }
}