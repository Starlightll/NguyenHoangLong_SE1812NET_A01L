using NguyenHoangLongMVC.Application.DTOs;
using NguyenHoangLongMVC.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHoangLongMVC.Application.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryDto>> GetAllCategoryAsync();

        Task<CategoryDto> AddCategoryAsync(Category category);

        Task<CategoryDto> GetCategoryByIdAsync(int id);

        Task<CategoryDto> UpdateCategoryAsync(Category category);

        Task<int> DeleteCategoryAsync(int id);
    }
}
