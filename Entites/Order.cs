namespace Entites
{
    public class Order
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public List<OrderItem>? orderItems { get; set; }
        public DateTime PurchaseDate { get; set; }
        public decimal? TotalPrice { get; set; }
        public decimal TaxPrice { get; set; }

    }
}
