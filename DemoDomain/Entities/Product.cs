namespace Uzum.Domain.Entities
{
    public class Product
    {
        public Product()
        {
            MerchantProducts = new HashSet<MerchantProduct>();
        }
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int ManufacturerId { get; set; }
        public int CategoryId { get; set; }

        public Manufacturer? Manufacturer { get; set; }
        public Category? Category { get; set; }
        public ICollection<MerchantProduct>? MerchantProducts { get; set; }


    }
}
