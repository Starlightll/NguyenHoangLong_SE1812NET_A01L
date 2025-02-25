using AutoMapper;
using NguyenHoangLongMVC.Application.DTOs;
using NguyenHoangLongMVC.Application.Interfaces;
using NguyenHoangLongMVC.Data.Entities;
using NguyenHoangLongMVC.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHoangLongMVC.Application.Services
{

    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<CategoryDto> AddCategoryAsync(Category category)
        {
            var newCategory = await _categoryRepository.AddCategoryAsync(category);
            return _mapper.Map<CategoryDto>(newCategory);
        }

        public async Task<IEnumerable<CategoryDto>> GetAllCategoryAsync()
        {
            var categories = await _categoryRepository.GetAllCategoryAsync();
            return _mapper.Map<IEnumerable<CategoryDto>>(categories);
        }

        public async Task<CategoryDto> GetCategoryByIdAsync(int id)
        {
            var category = await _categoryRepository.GetCategoryByIdAsync(id);
            return _mapper.Map<CategoryDto>(category);
        }

        public async Task<CategoryDto> UpdateCategoryAsync(Category category)
        {
            var existingCategory = await _categoryRepository.GetCategoryByIdAsync(category.CategoryId);
            if (existingCategory == null)
                throw new Exception("Category not found");
            existingCategory.CategoryName = category.CategoryName;
            existingCategory.CategoryDesciption = category.CategoryDesciption;
            existingCategory.IsActive = category.IsActive;
            existingCategory.ParentCategoryId = category.ParentCategoryId;

            var updatedCategory = await _categoryRepository.UpdateCategory(existingCategory);
            return _mapper.Map<CategoryDto>(updatedCategory);
        }


        public async Task<int> DeleteCategoryAsync(int id)
        {
            try
            {
                Category category = await _categoryRepository.GetCategoryByIdAsync(id);
                if (category == null)
                {
                    return 0;
                }
                await _categoryRepository.DeleteCategory(category);
                return 1;
            }catch(Exception e)
            {
                return -1;
            }
        }
    }
}
