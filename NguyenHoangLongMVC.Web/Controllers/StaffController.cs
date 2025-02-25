using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NguyenHoangLongMVC.Application.DTOs;
using NguyenHoangLongMVC.Application.Interfaces;
using NguyenHoangLongMVC.Data.Entities;
using NguyenHoangLongMVC.Web.ViewModels;

namespace NguyenHoangLongMVC.Web.Controllers
{
    [Authorize(Roles = "Staff")]
    public class StaffController : Controller
    {

        private readonly INewsArticleService _newsArticleService;

        private readonly IAccountService _accountService;

        private readonly ICategoryService _categoryService;

        public StaffController(INewsArticleService newsArticleService, ICategoryService categoryService)
        {
            _newsArticleService = newsArticleService;
            _categoryService = categoryService;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

        public async Task<IActionResult> CategoryManagement()
        {
            var categories = await _categoryService.GetAllCategoryAsync();
            return View(categories);
        }

        public async Task<IActionResult> NewsArticleManagement()
        {

            var newsArticles = await _newsArticleService.GetAllNewsArticleAsync();
            return View(newsArticles);
        }


        public async Task<IActionResult> History()
        {
            var history = await _newsArticleService.GetHistory();
            return View(history);
        }



        //API Section
        [HttpGet("api/Staff/Categories")]
        public async Task<IActionResult> GetCategories()
        {
            var categories = await _categoryService.GetAllCategoryAsync();
            if (categories == null || !categories.Any())
                return NotFound("No categories found");

            return Ok(categories);
        }



        [HttpPost("api/Staff/Category")]
        public async Task<IActionResult> AddCategory([FromBody] CategoryModel categoryModel)
        {
            if (categoryModel == null)
                return BadRequest(new { Message = "Category data is required" });

            var newCategory = new Category
            {
                CategoryName = categoryModel.CategoryName,
                CategoryDesciption = categoryModel.CategoryDesciption,
                IsActive = categoryModel.IsActive,
                ParentCategoryId = categoryModel.ParentCategoryId
            };

            await _categoryService.AddCategoryAsync(newCategory);

            return Ok(new { Message = "Category added successfully", CategoryId = newCategory.CategoryId });
        }

        [HttpGet("api/Staff/Category/{id}")]
        public async Task<IActionResult> GetCategoryById(int id)
        {
            CategoryDto category = await _categoryService.GetCategoryByIdAsync(id);

            return Ok(category);
        }


        [HttpPut("api/Staff/Category")]
        public async Task<IActionResult> UpdateCategory([FromBody] CategoryModel categoryModel)
        {
            if (categoryModel == null)
                return BadRequest(new { Message = "Category data is required" });
            var category = new Category
            {
                CategoryId = categoryModel.CategoryID,
                CategoryName = categoryModel.CategoryName,
                CategoryDesciption = categoryModel.CategoryDesciption,
                IsActive = categoryModel.IsActive,
                ParentCategoryId = categoryModel.ParentCategoryId
            };
            await _categoryService.UpdateCategoryAsync(category);
            return Ok(new { Message = "Category updated successfully", CategoryId = category.CategoryId });

        }

        [HttpDelete("api/Staff/Category/{id}")]
        public async Task<IActionResult> DetekeCategoryById(int id)
        {
            int status = await _categoryService.DeleteCategoryAsync(id);
            

            return Ok(status);
        }


    }
}
