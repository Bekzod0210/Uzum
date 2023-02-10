namespace Uzum.Domain.Entities
{
    public class Manufacturer
    {
        public Manufacturer()
        {
            Products = new HashSet<Product>();
        }
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Country { get; set; } = string.Empty;
        public ICollection<Product> Products { get; set; }

    }
}
