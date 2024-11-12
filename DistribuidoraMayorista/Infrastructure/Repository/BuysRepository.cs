using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Repository
{
    public class BuysRepository : IBuysRepository
    {
        private readonly ProductDbContext _dbContext;

        public BuysRepository(ProductDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Buys> GetAllBuys()
        {
            return _dbContext.Buys.Include(b => b.Details).ToList();
        }

        public List<Buys> GetBuysByUserId(int userId)
        {
            return _dbContext.Buys.Include(b => b.Details)
                                   .Where(b => b.UserBuysId == userId).ToList();
        }

        public Buys AddBuy(Buys buy)
        {
            _dbContext.Buys.Add(buy);
            _dbContext.SaveChanges();
            return buy; 
        }
    }
}
