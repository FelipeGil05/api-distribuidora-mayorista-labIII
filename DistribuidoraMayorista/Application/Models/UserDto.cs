using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models
{
    public class UserDto
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public required string UserType { get; set; }

        public static UserDto Create(User user)
        {
            return new UserDto
            {
                Id = user.Id,
                UserName = user.UserName,
                Email = user.Email,
                Password = user.Password,
                UserType = user.UserType
            };
        }

        public static List<UserDto> CreateList(IEnumerable<User> users)
        {
            return users.Select(Create).ToList();
        }
    }
}
