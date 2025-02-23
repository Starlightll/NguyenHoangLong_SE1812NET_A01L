using Microsoft.AspNetCore.Mvc;
using NguyenHoangLongMVC.Web.ViewModels;

namespace NguyenHoangLongMVC.Web.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                // Check login
                if (model.Username == "admin" && model.Password == "123456")
                {
                    // Login success
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    // Login fail
                    ModelState.AddModelError("", "Username or password is incorrect");
                }
            }
            return View(model);
        }
  

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult ForgotPassword()
        {
            return View();
        }

        public IActionResult ResetPassword()
        {
            return View();
        }

        public IActionResult ChangePassword()
        {
            return View();
        }

        public IActionResult Logout()
        {
            return View();
        }

        public IActionResult AccessDenied()
        {
            return View();
        }

        public IActionResult Lockout()
        {
            return View();
        }

        public IActionResult ConfirmEmail()
        {
            return View();
        }


    }
}
