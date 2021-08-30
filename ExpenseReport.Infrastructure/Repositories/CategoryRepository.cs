﻿using ExpenseReport.Application.Interfaces.Repositories;
using ExpenseReport.Domain.Entities.Catalog;
using ExpenseReport.Domain.Entities.Expense;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpenseReport.Infrastructure.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly IRepositoryAsync<Category> _repository;
        private readonly IDistributedCache _distributedCache;

        public CategoryRepository(IDistributedCache distributedCache, IRepositoryAsync<Category> repository)
        {
            _distributedCache = distributedCache;
            _repository = repository;
        }

        public IQueryable<Category> Categories => _repository.Entities;

        public async Task DeleteAsync(Category category)
        {
            await _repository.DeleteAsync(category);
            await _distributedCache.RemoveAsync(CacheKeys.CategoryCacheKeys.ListKey);
            await _distributedCache.RemoveAsync(CacheKeys.CategoryCacheKeys.GetKey(category.Id));
        }

        public async Task<Category> GetByIdAsync(int categoryId)
        {
            return await _repository.Entities.Where(p => p.Id == categoryId).FirstOrDefaultAsync();
        }

        public async Task<List<Category>> GetListAsync()
        {
            return await _repository.Entities.ToListAsync();
        }

        public async Task<int> InsertAsync(Category category)
        {
            await _repository.AddAsync(category);
            await _distributedCache.RemoveAsync(CacheKeys.CategoryCacheKeys.ListKey);
            return category.Id;
        }

        public async Task UpdateAsync(Category category)
        {
            await _repository.UpdateAsync(category);
            await _distributedCache.RemoveAsync(CacheKeys.CategoryCacheKeys.ListKey);
            await _distributedCache.RemoveAsync(CacheKeys.CategoryCacheKeys.GetKey(category.Id));
        }
    }
}