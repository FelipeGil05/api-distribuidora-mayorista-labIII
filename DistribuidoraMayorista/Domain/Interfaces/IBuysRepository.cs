using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IBuysRepository
    {
        public List<Buys> GetAllBuys();
        public Buys GetBuyById(int buysId);
        public List<Buys> GetBuysByUserId(int userId);
        public int AddBuy(Buys buy);
        public void UpdateBuy(int buysId, Buys buy);
        public void DeleteBuy(int buysId);
    }
}
