using Data.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using ParfumeShop.Data;
using ParfumeShop.Models;
using ParfumeShop.Utilities;
using ParfumeShop.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace ParfumeShop.Controllers
{
    [Authorize]
    public class CartController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IEmailSender _emailSender;
        private readonly IViewRender _viewRender;
        public CartController(ParfumeDBContext context, IEmailSender emailSender, IViewRender viewRender)
        {
            //_context = context;
            _emailSender = emailSender;
            _viewRender = viewRender;
            _unitOfWork = new UnitOfWork(context);
        }
        [AllowAnonymous]
        public IActionResult Index()
        {
            //List<ShoppingProduct> products = HttpContext.Session.GetObject<List<ShoppingProduct>>(WebConstants.cartKey);
            //if (products == null)
            //    products = new List<ShoppingProduct>();

            //int[] productIds = products.Select(i => i.ProductId).ToArray();

            CartListVM viewModel = new CartListVM()
            {
                Parfumes = GetParfumesFromSession()//_context.Cars.Where(c => productIds.Contains(c.Id))
            };

            return View(viewModel);
        }

        private IEnumerable<Parfume> GetParfumesFromSession()
        {
            List<ShoppingProduct> products = HttpContext.Session.GetObject<List<ShoppingProduct>>(WebConstants.cartKey);
            if (products == null)
                products = new List<ShoppingProduct>();

            int[] productIds = products.Select(i => i.ProductId).ToArray();

            return _unitOfWork.ParfumeRepository.Get(c => productIds.Contains(c.Id)); //_context.Cars.Where(c => productIds.Contains(c.Id));
        }

        public IActionResult Confirm()
        {
            string userEmail = User.Identity.Name;
            var items = GetParfumesFromSession();

            var html = this._viewRender.Render("Mails/OrderSummary", new OrderSummaryMail
            {
                UserName = userEmail,
                Cars = items,
                TotalPrice = items.Sum(i => i.Price)
            });

            _emailSender.SendEmailAsync(userEmail, "Order Summary", html);

            return View();
        }
    }
}
