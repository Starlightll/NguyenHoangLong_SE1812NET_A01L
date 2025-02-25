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

        public Task AddNewsArticleAsync(NewsArticle newsArticle)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<NewsArticle>> GetAllNewsArticleAsync()
        {
            return await _context.NewsArticles.Include(na => na.CreatedBy).Include(na => na.Category).Include(na => na.Tags).Where(na => na.NewsStatus == true).ToListAsync();
        }

        public async Task<NewsArticle> GetNewsArticleByIdAsync(string newsArticleId)
        {
            return await _context.NewsArticles.Include(na => na.CreatedBy).Include(na => na.Category).Include(na => na.Tags).FirstOrDefaultAsync(na => na.NewsArticleId == newsArticleId);
        }



        public Task UpdateNewsArticleAsync(NewsArticle newsArticle)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<NewsArticle>> GetAll()
        {
            return await _context.NewsArticles.Include(na => na.CreatedBy).Include(na => na.Category).Include(na => na.Tags).ToListAsync();
        }
    }
}
