using Application.Interfaces;
using AutoMapper;
using Domain.DTOs;
using Domain.Model;
using Microsoft.EntityFrameworkCore;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Application.Services
{
    public class UserAnswerService :IUserAnswerService
    {
        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;
        public UserAnswerService(DataContext dataContext, IMapper mapper) 
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }
        public async Task<UserAnswerSubmitDTO> CreateUserAnswer(UserAnswerSubmitDTO userAnswer)
        {
            if (userAnswer == null)
            {
                throw new InvalidOperationException("Test data is null.");
            }
            var submitUserAnswer = _mapper.Map<UserAnswer>(userAnswer);
            _dataContext.UserAnswers.Add(submitUserAnswer);
            await _dataContext.SaveChangesAsync();

            return userAnswer;
        }

        public async Task DeleteUserAnswer(int id)
        {
            var userAnswer = await _dataContext.UserAnswers.FindAsync(id);
            if (userAnswer == null)
            {
                throw new InvalidOperationException("User answer not found");
            }

            _dataContext.UserAnswers.Remove(userAnswer);
            await _dataContext.SaveChangesAsync();
        }
    }
}