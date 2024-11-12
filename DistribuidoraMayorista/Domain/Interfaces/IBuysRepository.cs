using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IBuysRepository
    {
        List<Buys> GetAllBuys();
        List<Buys> GetBuysByUserId(int userId);
        Buys AddBuy(Buys buy);

    }
}
