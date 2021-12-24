using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ParfumeShop.Models
{
    public class Category
    {

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        // Navigation 
        public virtual ICollection<Parfume> Parfumes { get; set; }
    }
}
