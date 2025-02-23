using Microsoft.EntityFrameworkCore;
using NguyenHoangLongMVC.Data.Contexts;
using NguyenHoangLongMVC.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHoangLongMVC.Data.Repositories
{
    public class NewsArticleRepository : INewsArticleRepository
    {
        private readonly MyDbContext _context;

        public NewsArticleRepository(MyDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<NewsArticle>> GetAllNewsArticleAsync()
        {
            return await _context.NewsArticles.Include(na => na.CreatedBy).ToListAsync();
        }

        public Task<NewsArticle> GetNewsArticleByIdAsync(string newsArticleId)
        {
            throw new NotImplementedException();
        }
    }
}
