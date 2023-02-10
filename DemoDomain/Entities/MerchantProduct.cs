namespace Uzum.Domain.Entities
{
    public class MerchantProduct : User
    {
        public MerchantProduct()
        {
            Details = new HashSet<OrderDetail>();
        }
        public int MerchantId { get; set; }
        public int ProductId { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }

        public Merchant? Merchant { get; set; }
        public Product? Product { get; set; }
        public ICollection<OrderDetail> Details { get; set; }
    }
}
