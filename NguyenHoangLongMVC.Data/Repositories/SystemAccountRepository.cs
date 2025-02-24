using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using NguyenHoangLongMVC.Data.Contexts;
using NguyenHoangLongMVC.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHoangLongMVC.Data.Repositories
{
    public class SystemAccountRepository : ISystemAccountRepository
    {
        private readonly MyDbContext _context;

        public SystemAccountRepository(MyDbContext context)
        {
            _context = context;
        }

        public async Task<SystemAccount> GetSystemAccountByEmail(string email)
        {
            return  await _context.SystemAccounts.FirstOrDefaultAsync(x => x.AccountEmail == email);
        }

        public async Task<SystemAccount?> GetSystemAccountByEmailAndPassword(string email, string password)
        {
            return await _context.SystemAccounts.FirstOrDefaultAsync(x => x.AccountEmail == email && x.AccountPassword == password);
        }

        public async Task<IEnumerable<SystemAccount>> GetAllSystemAccount()
        {
            return await _context.SystemAccounts.ToListAsync();
        }

        public async Task<SystemAccount> GetSystemAccountById(int id)
        {
            return await _context.SystemAccounts.FirstOrDefaultAsync(x => x.AccountId == id);
        }
    }
}
