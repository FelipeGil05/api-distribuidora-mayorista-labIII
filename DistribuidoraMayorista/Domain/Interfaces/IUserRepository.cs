using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IUserRepository
    {
        public User? GetUserById(int id);
        public User? GetUser(string email, string password);
        public List<User> GetUsers();
        public int AddUser(User user);
        public void UpdateUser(int id, User user);
        public void DeleteUser(int id);
    }
}
