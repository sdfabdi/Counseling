using Application.Interfaces;
using AutoMapper;
using Domain.DTOs;
using Domain.Model;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Services
{
    public class AnswerService : IAnswerService
    {
        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;
        public AnswerService(DataContext dataContext, IMapper mapper)
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }
        public async Task<AnswerSubmitDTO> CreateAnswer(AnswerSubmitDTO answer)
        {
            if (answer == null)
            {
                throw new InvalidOperationException("Answer Cannot be null");
            }
            var submitAnswer = _mapper.Map<Answer>(answer);
            _dataContext.Answers.Add(submitAnswer);
            await _dataContext.SaveChangesAsync();

            return answer;
        }
        public async Task<IEnumerable<AnswerReadDTO>> GetAnswersByCategory(int categoryId)
        {

            var answers = await _dataContext.Answers
                    .Where(a => a.CategoryID == categoryId)
                    .Include(a => a.Category)
                    .ToListAsync();
            var answerDto = _mapper.Map<List<AnswerReadDTO>>(answers);
            if (answerDto == null || answerDto.Count == 0)
            {
                throw new InvalidOperationException("Answer Cannot be null");
            }

            return answerDto;

        }
    }
}