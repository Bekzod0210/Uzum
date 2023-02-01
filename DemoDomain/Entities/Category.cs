namespace Uzum.Domain.Entities
{
    public class Category
    {

        public Category()
        {
            Products = new List<Product>();
        }
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        ICollection<Product> Products { get; set; }
    }
}
