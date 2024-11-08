using Domain.Entities;
using Domain.Interfaces;

namespace Infrastructure.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ProductDbContext _dbContext;

        public User? GetUserById(int id)  
        {
            return _dbContext.Users.FirstOrDefault(u => u.Id == id);
        }
        public User? GetUser(string email, string password)
        {
            return _dbContext.Users.FirstOrDefault(x => x.Email == email && x.Password == password);
        }
        public UserRepository(ProductDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<User> GetUsers()
        {
            return _dbContext.Users.ToList();
        }

        public int AddUser(User user)
        {
            _dbContext.Users.Add(user);

            _dbContext.SaveChanges();

            return user.Id;
        }

        public void UpdateUser(int id, User user)
        {
            var existingUser = _dbContext.Users.FirstOrDefault(u => u.Id == id);

            if (existingUser != null)
            {
                existingUser.UserName = user.UserName;
                existingUser.Email = user.Email;
               // existingUser.Password = user.Password;
                existingUser.UserType = user.UserType;

                _dbContext.SaveChanges();
            }
        }

        public void DeleteUser(int id)
        {
            var user = _dbContext.Users.FirstOrDefault(x => x.Id == id);

            if (user != null)
            {
                _dbContext.Users.Remove(user);
                _dbContext.SaveChanges();
            }
        }
    }
}
