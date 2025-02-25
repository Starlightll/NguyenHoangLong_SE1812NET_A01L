using NguyenHoangLongMVC.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHoangLongMVC.Data.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAllCategoryAsync();

        Task<Category> AddCategoryAsync(Category category);

        Task<Category> GetCategoryByIdAsync(int id);

        Task<Category> UpdateCategory(Category category);

        Task<Category> DeleteCategory(Category category);
    }
}
