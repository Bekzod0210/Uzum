using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzum.Domain.Entities
{
    public class Card
    {
        public Card()
        {
            Users = new List<User>();
        }

        public int Id { get; set; }

        public decimal TotalSum { get; set; }

        public string CardNumber { get; set; } = string.Empty;


        public ICollection<User> Users { get; set; }
    }
}
