using NguyenHoangLongMVC.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHoangLongMVC.Data.Repositories
{
    public interface INewsArticleRepository
    {
        Task<IEnumerable<NewsArticle>> GetAllNewsArticleAsync();
        Task<NewsArticle> GetNewsArticleByIdAsync(string newsArticleId);

        Task AddNewsArticleAsync(NewsArticle newsArticle);

        Task UpdateNewsArticleAsync(NewsArticle newsArticle);


    }
}
