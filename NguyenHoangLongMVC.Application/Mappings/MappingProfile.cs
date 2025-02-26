﻿using AutoMapper;
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
               .ForMember(dest => dest.NewsStatus, opt => opt.MapFrom(src => src.NewsStatus))
               .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.Category))
               .ForMember(dest => dest.CreatedBy, opt => opt.MapFrom(src => src.CreatedBy))
               .ForMember(dest => dest.Tags, opt => opt.MapFrom(src => src.Tags));

            CreateMap<SystemAccount, SystemAccountDto>()
                .ForMember(dest => dest.AccountId, opt => opt.MapFrom(src => src.AccountId))
                .ForMember(dest => dest.AccountName, opt => opt.MapFrom(src => src.AccountName))
                .ForMember(dest => dest.AccountEmail, opt => opt.MapFrom(src => src.AccountEmail))
                .ForMember(dest => dest.AccountRole, opt => opt.MapFrom(src => src.AccountRole));

            CreateMap<Category, CategoryDto>()
                .ForMember(dest => dest.CategoryId, opt => opt.MapFrom(src => src.CategoryId))
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.CategoryName))
                .ForMember(dest => dest.CategoryDesciption, opt => opt.MapFrom(src => src.CategoryDesciption))
                .ForMember(dest => dest.ParentCategory, opt => opt.MapFrom(src => src.ParentCategory))
                .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive));
        }
    }
}
