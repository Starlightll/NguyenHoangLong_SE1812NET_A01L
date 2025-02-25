using Microsoft.AspNetCore.Mvc;
using NguyenHoangLongMVC.Application.DTOs;
using NguyenHoangLongMVC.Application.Interfaces;

namespace NguyenHoangLongMVC.Web.Controllers
{
    public class NewsArticleController : Controller
    {
        private readonly INewsArticleService newsArticleService;
        public NewsArticleController(INewsArticleService newsArticleService)
        {
            this.newsArticleService = newsArticleService;
        }

        public async Task<IActionResult> Index()
        {

            IEnumerable<NewsArticleDto> newsArticles = await newsArticleService.GetAllNewsArticleAsync();
            return View(newsArticles);
        }

        public async Task<IActionResult> Details(string id)
        {
            if(string.IsNullOrEmpty(id))
            {
                return NotFound();
            }

            var newsArticle = await newsArticleService.GetNewsArticleByIdAsync(id);
            if (newsArticle == null)
            {
                return NotFound("Article not found.");
            }
            return View(newsArticle);
        }
    }
}
