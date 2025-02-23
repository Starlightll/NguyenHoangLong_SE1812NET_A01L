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
    }
}
