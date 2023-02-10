namespace Uzum.Domain.Entities
{
    public class Customer : User
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }
        public double Balance { get; set; }

        public ICollection<Order> Orders { get; set; }

    }
}
