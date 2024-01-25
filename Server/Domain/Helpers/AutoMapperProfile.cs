using AutoMapper;
using Domain.DTOs;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            //Answer
            CreateMap<Answer, AnswerReadDTO>();
            CreateMap<Answer, AnswerSubmitDTO>();
            CreateMap<AnswerSubmitDTO, Answer>();
            //Category
            CreateMap<Category, CategoryReadDTO>();
            CreateMap<Category, CategorySubmitDTO>();
            CreateMap<CategorySubmitDTO, Category>();
            // Test
            CreateMap<Test, TestReadDTO>()
                .ForMember(dest => dest.Answers, opt => opt.MapFrom(src => src.Answers));
            CreateMap<Test, TestSubmitDTO>();
            CreateMap<TestSubmitDTO, Test>();
            //MBTI
            CreateMap<MBTI, MBTIReadDTO>();
            //UserAnswer
            CreateMap<UserAnswer, UserAnswerSubmitDTO>();
            CreateMap<UserAnswerSubmitDTO, UserAnswer>();
            //User
            CreateMap<User, UserSubmitDTO>();   
            CreateMap<UserSubmitDTO, User>(); 
        }
    }
}
