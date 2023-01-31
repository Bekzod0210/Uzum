using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzum.Domain.Entities
{
    public class Contract
    {
        public Contract()
        {
            BoughtProducts = new List<BoughtProduct>();
            Payments = new List<Payment>();
            
        }

        public int Id { get; set; }

        public int UserId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public User User { get; set; }

        ICollection<BoughtProduct> BoughtProducts { get; set; }

        ICollection<Payment> Payments { get; set; }
    }
}
