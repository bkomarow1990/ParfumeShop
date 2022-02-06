using ParfumeShop.Models;
using System.Collections.Generic;

namespace ParfumeShop.Controllers
{
    internal class OrderSummaryMail
    {
        public string UserName { get; set; }
        public IEnumerable<Parfume> Cars { get; set; }
        public float TotalPrice { get; set; }
    }
}