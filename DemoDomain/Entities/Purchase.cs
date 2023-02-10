using Uzum.Domain.Enums;

namespace Uzum.Domain.Entities
{
    public class Purchase
    {
        public int Id { get; set; }
        public int OrderDetailId { get; set; }
        public double Sum { get; set; }
        public PurchaseStatus Status { get; set; }

        public OrderDetail? OrderDetail { get; set; }
    }
}
