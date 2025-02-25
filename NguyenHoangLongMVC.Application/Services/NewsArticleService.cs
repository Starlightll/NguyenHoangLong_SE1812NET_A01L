using AutoMapper;
using NguyenHoangLongMVC.Application.DTOs;
using NguyenHoangLongMVC.Application.Interfaces;
using NguyenHoangLongMVC.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHoangLongMVC.Application.Services
{
    public class NewsArticleService : INewsArticleService
    {
        private readonly INewsArticleRepository _newsArticleRepository;
        private readonly IMapper _mapper;

        public NewsArticleService(INewsArticleRepository newsArticleRepository, IMapper mapper)
        {
            _newsArticleRepository = newsArticleRepository;
            _mapper = mapper;
        }

        public Task AddNewsArticleAsync(NewsArticleDto newsArticleDto)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<NewsArticleDto>> GetAllNewsArticleAsync()
        {
            var newsArticles = await _newsArticleRepository.GetAllNewsArticleAsync();
            return _mapper.Map<IEnumerable<NewsArticleDto>>(newsArticles);
        }

        public Task<IEnumerable<NewsArticleDto>> GetNewsArticleByCategoryAsync(int categoryId)
        {
            throw new NotImplementedException();
        }

        public async Task<NewsArticleDto> GetNewsArticleByIdAsync(string newsArticleId)
        {
            var newsArticle = await _newsArticleRepository.GetNewsArticleByIdAsync(newsArticleId);
            return _mapper.Map<NewsArticleDto>(newsArticle);
        }

        public Task UpdateNewsArticleAsync(NewsArticleDto newsArticleDto)
        {
            throw new NotImplementedException();
        }
    }
}
