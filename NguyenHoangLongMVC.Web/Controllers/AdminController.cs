using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NguyenHoangLongMVC.Application.DTOs;
using NguyenHoangLongMVC.Application.Interfaces;
using NguyenHoangLongMVC.Data.Entities;

namespace NguyenHoangLongMVC.Web.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly IAccountService _accountService;

        public AdminController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        public IActionResult Index()
        {
            return View();
        }


        public async Task<IActionResult> AccountManagement()
        {

            IEnumerable<SystemAccountDto> systemAccounts = await _accountService.GetAllSystemAccountAsync();
            return View(systemAccounts);
        }

        //API
        [HttpGet("api/Admin/GetSystemAccountById/{id}")]
        public async Task<IActionResult> GetSystemAccountById(int id)
        {
            var systemAccount = await _accountService.GetSystemAccountByIdAsync(id);
            if (systemAccount == null) return NotFound("Account not found");
            return Ok(systemAccount); // Trả về JSON
        }



    }
}
