using NguyenHoangLongMVC.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHoangLongMVC.Application.Interfaces
{
    public interface IAuthService
    {
        Task<bool> IsAuthenticated { get; set; }
        Task<SystemAccountDto> AuthenticateAsync(string username, string password);
        Task Logout();
        Task<bool> Register(string username, string password);

        Task<bool> ChangePassword(string username, string oldPassword, string newPassword);

        Task<bool> ForgotPassword(string username);

        Task<bool> ResetPassword(string username, string newPassword);

    }
}
