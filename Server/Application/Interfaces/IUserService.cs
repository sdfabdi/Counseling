using Domain.DTOs;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IUserService
    {
        Task<UserSubmitDTO> CreateUser(UserSubmitDTO user);
        Task DeleteUser(int id);
    }
}