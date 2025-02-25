using NguyenHoangLongMVC.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHoangLongMVC.Application.Interfaces
{
    public interface INewsArticleService
    {
        Task<IEnumerable<NewsArticleDto>> GetAllNewsArticleAsync();
        Task<IEnumerable<NewsArticleDto>> GetNewsArticleByCategoryAsync(int categoryId);
        Task<NewsArticleDto> GetNewsArticleByIdAsync(string newsArticleId);

        Task AddNewsArticleAsync(NewsArticleDto newsArticleDto);

        Task UpdateNewsArticleAsync(NewsArticleDto newsArticleDto);


    }
}
