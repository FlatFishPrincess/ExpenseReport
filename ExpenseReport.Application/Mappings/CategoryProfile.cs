using AutoMapper;
using ExpenseReport.Domain.Entities.Expense;
using ExpenseReport.Application.Features.Categories.Commands.Create;
using ExpenseReport.Application.Features.Categories.Queries.GetById;
using ExpenseReport.Application.Features.Categories.Queries.GetAllCached;

namespace ExpenseReport.Application.Mappings
{
    internal class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<CreateCategoryCommand, Category>().ReverseMap();
            CreateMap<GetCategoryByIdResponse, Category>().ReverseMap();
            CreateMap<GetAllCategoriesResponse, Category>().ReverseMap();
        }
    }
}