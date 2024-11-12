using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Buys
    {
        [Key]
        public int BuysId { get; set; }
        public int UserBuysId { get; set; } 
        public DateTime PurchaseDate { get; set; }
        public List<DetailBuys> Details { get; set; }
        public decimal TotalBuy => Details?.Sum(d => d.Total) ?? 0;
    }

    public class DetailBuys
    {
        [Key]
        public int DetailBuysId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal Total => UnitPrice * Quantity;
    }
}
