using Domain.DTOs;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IUserAnswerService
    {
        Task<UserAnswerSubmitDTO> CreateUserAnswer(UserAnswerSubmitDTO userAnswer);
        Task DeleteUserAnswer(int id);
    }
}