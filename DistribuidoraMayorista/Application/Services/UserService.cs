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
            string userType = userDto.UserType switch
            {
                "Admin" => "Admin",
                "SysAdmin" => "SysAdmin",
                _ => "Client" 
            };

            return _userRepository.AddUser(new User
            {
                UserName = userDto.UserName,
                Email = userDto.Email,
                Password = userDto.Password,
                UserType = userType,
            });
        }

        public UserDto UpdateUser(int id, UserDto userDto)
        {

            var existingUser = _userRepository.GetUserById(id);

            if (existingUser == null)
            {
                throw new Exception("Usuario no encontrado.");
            }

            existingUser.UserName = userDto.UserName ?? existingUser.UserName;
            existingUser.Email = userDto.Email ?? existingUser.Email;

            _userRepository.UpdateUser(id, existingUser);

            return UserDto.Create(existingUser);
        }

        public void DeleteUser(int id)
        {
            _userRepository.DeleteUser(id);
        }



    }
}
