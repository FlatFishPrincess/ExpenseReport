using ExpenseReport.Application.Interfaces.CacheRepositories;
using ExpenseReport.Application.Interfaces.Repositories;
using ExpenseReport.Domain.Entities.Catalog;
using ExpenseReport.Infrastructure.CacheKeys;
using AspNetCoreHero.Extensions.Caching;
using AspNetCoreHero.ThrowR;
using Microsoft.Extensions.Caching.Distributed;
using System.Collections.Generic;
using System.Threading.Tasks;
using ExpenseReport.Domain.Entities.Expense;

namespace ExpenseReport.Infrastructure.CacheRepositories
{
    public class CategoryCacheRepository : ICategoryCacheRepository
    {
        private readonly IDistributedCache _distributedCache;
        private readonly ICategoryRepository _categoryRepository;

        public CategoryCacheRepository(IDistributedCache distributedCache, ICategoryRepository categoryRepository)
        {
            _distributedCache = distributedCache;
            _categoryRepository = categoryRepository;
        }

        public async Task<Category> GetByIdAsync(int categoryId)
        {
            string cacheKey = CategoryCacheKeys.GetKey(categoryId);
            var category = await _distributedCache.GetAsync<Category>(cacheKey);
            if (category == null)
            {
                category = await _categoryRepository.GetByIdAsync(categoryId);
                Throw.Exception.IfNull(category, "Category", "No Category Found");
                await _distributedCache.SetAsync(cacheKey, category);
            }
            return category;
        }

        public async Task<List<Category>> GetCachedListAsync()
        {
            string cacheKey = CategoryCacheKeys.ListKey;
            var categoryList = await _distributedCache.GetAsync<List<Category>>(cacheKey);
            if (categoryList == null)
            {
                categoryList = await _categoryRepository.GetListAsync();
                await _distributedCache.SetAsync(cacheKey, categoryList);
            }
            return categoryList;
        }
    }
}