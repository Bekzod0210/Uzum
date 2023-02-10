namespace Uzum.Domain.Entities
{
    public class InstalmentDebt
    {
        public int Id { get; set; }

        public DateTime PaymentDate { get; set; }

        public bool isPayed { get; set; }
        public double Sum { get; set; }
        public int InstalmentId { get; set; }
        public Instalment? Instalment { get; set; }
    }
}
