using Domain.DTOs;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IAnswerService
    {
        public Task<AnswerSubmitDTO> CreateAnswer(AnswerSubmitDTO answer);
        public Task<IEnumerable<AnswerReadDTO>> GetAnswersByCategory(int categoryId);
    }
}
