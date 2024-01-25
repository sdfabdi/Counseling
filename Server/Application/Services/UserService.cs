using System.Threading.Tasks;
using AutoMapper;
using Domain.Model;
using Microsoft.EntityFrameworkCore;
using Persistence;
using Domain.DTOs;
using Application.Interfaces;

namespace Application.Services{
    public class UserService : IUserService
    {
        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;

        public UserService(DataContext dataContext, IMapper mapper)
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<UserSubmitDTO> CreateUser(UserSubmitDTO user)
        {
            var submitUser = _mapper.Map<User>(user);
            _dataContext.Users.Add(submitUser);
            await _dataContext.SaveChangesAsync();

            var userDto = _mapper.Map<UserSubmitDTO>(user);
            return userDto;
        }

        public async Task DeleteUser(int id)
        {
            var user = await _dataContext.Users.FindAsync(id);
            if (user == null)
            {
                throw new InvalidOperationException("User not found");
            }
            _dataContext.Users.Remove(user);
            await _dataContext.SaveChangesAsync();
        }
    }
}