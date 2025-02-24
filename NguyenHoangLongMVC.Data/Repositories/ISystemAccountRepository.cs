using NguyenHoangLongMVC.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHoangLongMVC.Data.Repositories
{
    public interface ISystemAccountRepository
    {
        Task<SystemAccount> GetSystemAccountByEmailAndPassword(string email, string password);
        Task<SystemAccount> GetSystemAccountByEmail(string email);
        Task<SystemAccount> GetSystemAccountById(int id);

        Task<IEnumerable<SystemAccount>> GetAllSystemAccount();

    }
}
