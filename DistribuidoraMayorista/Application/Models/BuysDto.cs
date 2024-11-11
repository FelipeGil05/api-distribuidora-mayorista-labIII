namespace Application.Models
{
    public class BuysDto
    {
        public int BuysId { get; set; }
        public int UserBuysId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public List<DetailBuysDto> Details { get; set; }
        public decimal TotalBuy { get; set; }
    }

    public class DetailBuysDto
    {
        public int DetailId { get; set; }
        public int ProductDetailId { get; set; }
        public int Amount { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Total => Amount * UnitPrice;
    }
}
