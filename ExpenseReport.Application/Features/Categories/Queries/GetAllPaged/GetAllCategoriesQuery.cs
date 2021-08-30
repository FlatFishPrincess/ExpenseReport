using ExpenseReport.Application.Interfaces.CacheRepositories;
using AspNetCoreHero.Results;
using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System;
using ExpenseReport.Domain.Entities.Expense;
using ExpenseReport.Application.Interfaces.Repositories;
using System.Linq;
using ExpenseReport.Application.Extensions;

namespace ExpenseReport.Application.Features.Categories.Queries.GetAllCached
{
    public class GetAllCategoriesQuery : IRequest<PaginatedResult<GetAllCategoriesResponse>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }

        public GetAllCategoriesQuery(int pageNumber, int pageSize)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
        }
    }

    public class GetAllCategoriesQueryHandler : IRequestHandler<GetAllCategoriesQuery, PaginatedResult<GetAllCategoriesResponse>>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public GetAllCategoriesQueryHandler(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<PaginatedResult<GetAllCategoriesResponse>> Handle(GetAllCategoriesQuery request, CancellationToken cancellationToken)
        {
            Expression<Func<Category, GetAllCategoriesResponse>> expression = expression => new GetAllCategoriesResponse
            {
                Id = expression.Id,
                Name = expression.Name,
                Code = expression.Code,
                ClaimItems = expression.ClaimItems
            };

            var paginatedList = await _categoryRepository.Categories
                                    .Select(expression)
                                    .ToPaginatedListAsync(request.PageNumber, request.PageSize);
            return paginatedList;
        }
    }
}