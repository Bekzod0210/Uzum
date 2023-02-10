namespace Uzum.Domain.Entities
{
    public class Merchant : User
    {
        public Merchant()
        {
            Products = new HashSet<MerchantProduct>();
        }
        public double Balance { get; set; }

        public ICollection<MerchantProduct> Products { get; set; }
    }
}
