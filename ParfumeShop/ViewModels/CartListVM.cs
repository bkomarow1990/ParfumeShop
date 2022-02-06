using ParfumeShop.Models;
using System.Collections.Generic;

namespace ParfumeShop.ViewModels
{
    public class CartListVM
    {
        public IEnumerable<Parfume> Parfumes { get; set; }
    }
}
