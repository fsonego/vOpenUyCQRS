﻿using AutoMapper;
using vOpenUYCQRS.Application.Common.Mappings;
using vOpenUYCQRS.Domain.Entities;

namespace vOpenUYCQRS.Application.Categories.Queries.GetCategoriesList
{
    public class CategoryLookupDto : IMapFrom<Category>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Category, CategoryLookupDto>()
                .ForMember(d => d.Id, opt => opt.MapFrom(s => s.CategoryId))
                .ForMember(d => d.Name, opt => opt.MapFrom(s => s.CategoryName));
        }
    }
}
