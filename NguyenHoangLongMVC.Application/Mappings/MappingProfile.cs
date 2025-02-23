using AutoMapper;
using NguyenHoangLongMVC.Application.DTOs;
using NguyenHoangLongMVC.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHoangLongMVC.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile() {
            CreateMap<NewsArticle, NewsArticleDto>()
               .ForMember(dest => dest.NewsArticleId, opt => opt.MapFrom(src => src.NewsArticleId))
               .ForMember(dest => dest.NewsTitle, opt => opt.MapFrom(src => src.NewsTitle))
               .ForMember(dest => dest.Headline, opt => opt.MapFrom(src => src.Headline))
               .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => src.CreatedDate))
               .ForMember(dest => dest.NewsContent, opt => opt.MapFrom(src => src.NewsContent))
               .ForMember(dest => dest.NewsSource, opt => opt.MapFrom(src => src.NewsSource))
               .ForMember(dest => dest.ModifiedDate, opt => opt.MapFrom(src => src.ModifiedDate))
               .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.Category))
               .ForMember(dest => dest.CreatedBy, opt => opt.MapFrom(src => src.CreatedBy))
               .ForMember(dest => dest.Tags, opt => opt.MapFrom(src => src.Tags));
        }
    }
}
