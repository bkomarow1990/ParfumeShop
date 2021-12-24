using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ParfumeShop.Data;
using ParfumeShop.Models;
using ParfumeShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParfumeShop.Controllers
{
    public class ParfumeController : Controller
    {
        private ParfumeDBContext _context;

        public ParfumeController(ParfumeDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Parfumes.Include(nameof(Parfume.Category)));
        }
        public IActionResult Create()
        {
            //IEnumerable<SelectListItem> categories = _context.Categories.Select(i => new SelectListItem()
            //{
            //    Text = i.Name,
            //    Value = i.Id.ToString()
            //});

            // ViewData
            //ViewData["CategoryList"] = categories;

            // ViewBag
            //ViewBag.CategoryList = categories;

            ParfumeVM viewModel = new ParfumeVM()
            {
                Categories = _context.Categories.Select(i => new SelectListItem()
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                })
            };

            return View(viewModel);
        }

        public IActionResult Upsert()
        {
            ParfumeVM viewModel = new ParfumeVM()
            {
                Categories = _context.Categories.Select(i => new SelectListItem()
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                })
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Upsert(ParfumeVM model)
        {
            if (!ModelState.IsValid) return NotFound();

            if (model.Parfume.Id == 0)
            {
                _context.Parfumes.Add(model.Parfume);
                _context.SaveChanges();
            }
            else
            {
                _context.Parfumes.Update(model.Parfume);
                _context.SaveChanges();
            }


            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult Create(ParfumeVM model)
        {
            if (!ModelState.IsValid) return View();

            _context.Parfumes.Add(model.Parfume);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id <= 0) return NotFound();

            var carToRemove = _context.Parfumes.Find(id);

            if (carToRemove == null) return NotFound();

            _context.Parfumes.Remove(carToRemove);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id <= 0) return NotFound();

            var car = _context.Parfumes.Find(id);

            if (car == null) return NotFound();

            IEnumerable<SelectListItem> categories = _context.Parfumes.Select(i => new SelectListItem()
            {
                Text = i.Name,
                Value = i.Id.ToString()
            });
            ViewBag.CategoryList = categories;

            return View(car);
        }

        [HttpPost]
        public IActionResult Edit(Parfume obj)
        {
            if (!ModelState.IsValid) return View();

            _context.Parfumes.Update(obj);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
