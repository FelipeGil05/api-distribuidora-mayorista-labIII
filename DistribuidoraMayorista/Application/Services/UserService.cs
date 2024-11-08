using Application.Models;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class UserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository) {
            _userRepository = userRepository;
        }

        public List<UserDto> GetUsers()
        {

            var users = _userRepository.GetUsers();

            return users
                .Select(user => new UserDto
                {
                    Id = user.Id,
                    UserName = user.UserName,
                    Email = user.Email,
                    Password = user.Password,
                    UserType = user.UserType,
                })
                .ToList();
        }

        public int AddUser(UserDto userDto)
        {
            return _userRepository.AddUser(new User
            {
                UserName = userDto.UserName,
                Email = userDto.Email,
                Password = userDto.Password,
                UserType = userDto.UserType,
            });
        }

        public UserDto UpdateUser(int id, UserDto userDto)
        {
            var user = new User
            {
                Id = userDto.Id,
                UserName = userDto.UserName,
                Email = userDto.Email,
                Password = userDto.Password,
                UserType = userDto.UserType,
            };

            _userRepository.UpdateUser(id, user);

            return userDto;
        }

        public void DeleteUser(int id)
        {
            _userRepository.DeleteUser(id);
        }



    }
}
