using Microsoft.AspNetCore.Mvc;

namespace NguyenHoangLongMVC.Web.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
