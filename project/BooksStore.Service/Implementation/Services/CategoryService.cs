﻿using AutoMapper;
using BooksStore.Core.Entities;
using BooksStore.Infastructure.Interfaces.Repositories;
using BooksStore.Infrastructure.Exceptions;
using BooksStore.Infrastructure.Interfaces;
using BooksStore.Services.DTO;
using BooksStore.Services.Interfaces;
using BooksStore.Web.CacheOptions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BooksStore.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        private readonly IMapper _mapper;

        private readonly ICacheManager _cacheManager;

        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper, ICacheManager cacheManager)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
            _cacheManager = cacheManager;
        }

        public async Task AddCategoryAsync(CategoryDTO categoryDTO)
        {
            var category = new Category(categoryDTO.Name);
            await _categoryRepository.AddAsync(category);
        }
                              
        public async Task<CategoryDTO> GetCategoryById(int categoryId)
        {
            var category = await _categoryRepository.GetByIdAsync(categoryId);

            if (category == null)
            {
                throw new NotFoundException(nameof(Category), category);
            }

            return _mapper.Map<CategoryDTO>(category);
        }

        public async Task<IEnumerable<CategoryDTO>> GetCategories(int skip, int take)
        {
            var categories = await _categoryRepository.GetAsync(skip, take);

            return _mapper.Map<IEnumerable<CategoryDTO>>(categories);
        }

        public async Task RemoveCategoryAsync(int categoryId)
        {            
            var category = await _categoryRepository.GetByIdAsync(categoryId);

            if (category == null)
            {
                throw new NotFoundException(nameof(Category), category);
            }

            await _categoryRepository.RemoveAsync(category);
            _cacheManager.Remove(CacheKeys.GetCategoryKey(categoryId));
        }

        public async Task UpdateCategoryAsync(CategoryDTO categoryDTO)
        {
            var category = _mapper.Map<Category>(categoryDTO);
            await _categoryRepository.UpdateAsync(category);
            _cacheManager.Remove(CacheKeys.GetCategoryKey(categoryDTO.Id));
        }

        public async Task<int> GetCountCategories()
        {
            return await _categoryRepository.GetCount();
        }
    }
}
