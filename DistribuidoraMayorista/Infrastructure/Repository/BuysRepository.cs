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

        public Buys GetBuyById(int buysId)
        {
            return _dbContext.Buys.Include(b => b.Details)
                                   .FirstOrDefault(b => b.BuysId == buysId);
        }

        public List<Buys> GetBuysByUserId(int userId)
        {
            return _dbContext.Buys.Include(b => b.Details)
                                   .Where(b => b.UserBuysId == userId).ToList();
        }

        public int AddBuy(Buys buy)
        {
            _dbContext.Buys.Add(buy);
            _dbContext.SaveChanges();

            return buy.BuysId;
        }

        public void UpdateBuy(int buysId, Buys buy)
        {
            var existingBuy = _dbContext.Buys.Include(b => b.Details)
                                             .FirstOrDefault(b => b.BuysId == buysId);

            if (existingBuy != null)
            {
                existingBuy.UserBuysId = buy.UserBuysId;
                existingBuy.PurchaseDate = buy.PurchaseDate;
                existingBuy.Details = buy.Details;

                _dbContext.SaveChanges();
            }
        }

        public void DeleteBuy(int buysId)
        {
            var buy = _dbContext.Buys.FirstOrDefault(b => b.BuysId == buysId);

            if (buy != null)
            {
                _dbContext.Buys.Remove(buy);
                _dbContext.SaveChanges();
            }
        }
    }
}
