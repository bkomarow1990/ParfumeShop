using Microsoft.AspNetCore.Identity;

namespace ParfumeShop.Data
{
    public class User : IdentityUser
    {
        public string FullName { get; set; }
    }
}