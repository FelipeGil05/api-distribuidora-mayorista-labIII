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
        public int DetailBuysId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal Total => UnitPrice * Quantity;
    }
}
