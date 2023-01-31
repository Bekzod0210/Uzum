using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzum.Domain.Entities
{
    public class Transaction
    {
        public int Id { get; set; }

        public decimal totalSum { get; set; }

        public int ShopProductId { get; set; }

        public ShopProduct ShopProduct { get; set; }
    }
}
