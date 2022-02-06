using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ParfumeShop.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
           return View();
        }
    }
}
