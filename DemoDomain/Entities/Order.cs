namespace Uzum.Domain.Entities
{
    public class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
            Instalments = new HashSet<Instalment>();
        }
        public int Id { get; set; }
        public DateTime DAteTime { get; set; }
        public double TotalSum { get; set; }
        public int CustomerId { get; set; }

        public Customer? Customer { get; set; }
        public Instalment? Instalment { get; set; }

        public ICollection<Instalment> Instalments { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }

    }
}
