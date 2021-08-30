using ExpenseReport.Application.Interfaces.CacheRepositories;
using AspNetCoreHero.Results;
using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ExpenseReport.Application.Features.Categories.Queries.GetAllCached
{
    public class GetAllCategoriesQuery : IRequest<Result<List<GetAllCategoriesResponse>>>
    {
        public GetAllCategoriesQuery()
        {
        }
    }

    public class GetAllCategoriesCachedQueryHandler : IRequestHandler<GetAllCategoriesQuery, Result<List<GetAllCategoriesResponse>>>
    {
        private readonly ICategoryCacheRepository _productCache;
        private readonly IMapper _mapper;

        public GetAllCategoriesCachedQueryHandler(ICategoryCacheRepository productCache, IMapper mapper)
        {
            _productCache = productCache;
            _mapper = mapper;
        }

        public async Task<Result<List<GetAllCategoriesResponse>>> Handle(GetAllCategoriesQuery request, CancellationToken cancellationToken)
        {
            var categoryList = await _productCache.GetCachedListAsync();
            var mappedCategories = _mapper.Map<List<GetAllCategoriesResponse>>(categoryList);
            return Result<List<GetAllCategoriesResponse>>.Success(mappedCategories);
        }
    }
}