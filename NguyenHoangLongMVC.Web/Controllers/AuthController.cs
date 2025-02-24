using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NguyenHoangLongMVC.Application.DTOs;
using NguyenHoangLongMVC.Application.Interfaces;
using NguyenHoangLongMVC.Application.Services;
using NguyenHoangLongMVC.Web.ViewModels;
using System.Security.Claims;
using System.Text.Json.Serialization;

namespace NguyenHoangLongMVC.Web.Controllers
{
    public class AuthController : Controller
    {
        private readonly IConfiguration _config;

        private readonly IAuthService _authService;

        private readonly IAccountService _accountService;


        public AuthController(IConfiguration config, IAuthService auth, IAccountService accountService)
        {
            _config = config;
            _authService = auth;
            _accountService = accountService;
        }

        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "NewsArticle"); 
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if(ModelState.IsValid)
            {
                var adminEmail = _config["AdminAccount:Email"];
                var adminPassword = _config["AdminAccount:Password"];
                var accountDto = new SystemAccountDto();

                if(model.Email == adminEmail && model.Password == adminPassword)
                {
                    accountDto.AccountEmail = adminEmail;
                    accountDto.AccountName = "Admin";
                    accountDto.AccountRole = 0;
                }
                else
                {
                    accountDto = await _authService.AuthenticateAsync(model.Email, model.Password);
                    if(accountDto == null)
                    {
                        ModelState.AddModelError("", "Invalid email or password");
                        return View(model);
                    }
                }
                

                string role = _accountService.getRoleName(accountDto.AccountRole);
                var accountJson = JsonConvert.SerializeObject(accountDto);

                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, accountDto.AccountName==null?"Anonymous":accountDto.AccountName),
                    new Claim(ClaimTypes.Email, model.Email),
                    new Claim(ClaimTypes.Role, role),
                    new Claim("AccountObject", accountJson)
                };
                    
                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                //var authProperties = new AuthenticationProperties
                //{
                //    IsPersistent = model.Equals(role)
                //};

                var principal = new ClaimsPrincipal(claimsIdentity);

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                return RedirectToAction("Index", "NewsArticle");

            }
            ModelState.AddModelError("", "Invalid email or password");
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

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login");
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
