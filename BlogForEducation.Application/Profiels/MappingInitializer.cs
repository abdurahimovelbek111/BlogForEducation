using AutoMapper;
using BlogForEducation.Application.DTOs;
using BlogForEducation.Domain.Models;

namespace BlogForEducation.Application.Profiels
{
    public class MappingInitializer:Profile
    {
        public MappingInitializer()
        {
            #region User uchun Mapping qilish 
            CreateMap<UserDto, User>().ReverseMap();
            CreateMap<UserForCreationDto, User>().ReverseMap();
            #endregion
            #region Blog uchun Mapping qilish 
            CreateMap<BlogDto, Blog>().ReverseMap();
            CreateMap<BlogForCreationDto, Blog>().ReverseMap();
            #endregion
        }
    }
}
