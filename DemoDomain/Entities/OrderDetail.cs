namespace Uzum.Domain.Entities
{
    public class OrderDetail
    {
        public OrderDetail()
        {
            Purchases = new HashSet<Purchase>();
        }
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int MerchantProductId { get; set; }
        public int Quantitiy { get; set; }

        public Order? Order { get; set; }
        public MerchantProduct? MerchantProduct { get; set; }

        public ICollection<Purchase> Purchases { get; set; }

    }
}
