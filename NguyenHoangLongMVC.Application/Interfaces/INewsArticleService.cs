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

    }
}
