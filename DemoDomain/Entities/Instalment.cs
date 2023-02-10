namespace Uzum.Domain.Entities
{
    public class Instalment
    {
        public Instalment()
        {
            Debts = new HashSet<InstalmentDebt>();
        }

        public int Id { get; set; }
        public DateTime StartedDateTime { get; set; }
        public int Month { get; set; }
        public double Percent { get; set; }

        public double InitialFee { get; set; }

        public int OrderId { get; set; }

        public Order? Order { get; set; }

        public ICollection<InstalmentDebt> Debts { get; set; }


    }
}
