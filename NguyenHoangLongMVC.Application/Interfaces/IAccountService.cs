using NguyenHoangLongMVC.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHoangLongMVC.Application.Interfaces
{
    public interface IAccountService
    {
        public string getRoleName(int? roleId);
        public string getRoleName(int roleId);

        Task<IEnumerable<SystemAccountDto>> GetAllSystemAccountAsync();

        Task<SystemAccountDto> GetSystemAccountByIdAsync(int id);
    }
}
