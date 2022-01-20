using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ParfumeShop.Data;
using ParfumeShop.Models;
using ParfumeShop.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Http;

namespace ParfumeShop.Controllers
{
    public class ParfumeController : Controller
    {
        private IWebHostEnvironment _host;
        private ParfumeDBContext _context;

        public ParfumeController(ParfumeDBContext context, IWebHostEnvironment host)
        {
            
            _host = host;
            _context = context;
        }

        public IActionResult Index()
        {
            //Include(nameof(Parfume.Category)
            return View(_context.Parfumes.ToList());
        }

        public IActionResult Upsert(int? id)
        {
            ParfumeVM viewModel = new ParfumeVM()
            {
                Categories = _context.Categories.Select(i => new SelectListItem()
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                })
            };
            if (id != null)
            {
                viewModel.Parfume = _context.Parfumes.Find(id);
            }

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Upsert(ParfumeVM model)
        {
            //var oldParfume = _context.Parfumes.Find(model.Parfume.Id);
            //if (!ModelState.IsValid) return NotFound();
            //if (model.Image != null)
            //{
            //    using (var ms = new MemoryStream())
            //    {
            //        model.Image.CopyTo(ms);
            //        model.Parfume.Image = ms.ToArray();
            //    } 
            //}
            //else
            //{

            //}
            var files = HttpContext.Request.Form.Files;
            if (files != null && files.Count() != 0)
            {
                string fileName = SaveImage(files[0]);
                model.Parfume.Image = fileName;
            }
            
            if (model.Parfume.Id == 0)
            {
                _context.Parfumes.Add(model.Parfume);
                // _context.SaveChanges();
            }
            else
            {
                _context.Parfumes.Update(model.Parfume);
            }
            
            await _context.SaveChangesAsync();


            return RedirectToAction(nameof(Index));
        }
        private string SaveImage(IFormFile img)
        {
            string root = _host.WebRootPath;
            string folder = root + WebConstants.productImagesPath;
            string name = Guid.NewGuid().ToString();
            string extension = Path.GetExtension(img.FileName);

            string fullPath = Path.Combine(folder, name + extension);

            using (FileStream fs = new FileStream(fullPath, FileMode.Create))
            {
                img.CopyTo(fs);
            }

            return name + extension;
        }
        public IActionResult Delete(int? id)
        {
            if (id == null || id <= 0) return NotFound();

            var parfumeToRemove = _context.Parfumes.Find(id);

            if (parfumeToRemove == null) return NotFound();

            _context.Parfumes.Remove(parfumeToRemove);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
        public ActionResult ShowImage(int id)
        {
            
            var model = _context.Parfumes.Find(id);
            return File(model.Image, "image/jpg");
        }
        // public IActionResult Edit(int? id)
        // {
        //     if (id == null || id <= 0) return NotFound();
        //
        //     var car = _context.Parfumes.Find(id);
        //
        //     if (car == null) return NotFound();
        //
        //     IEnumerable<SelectListItem> categories = _context.Parfumes.Select(i => new SelectListItem()
        //     {
        //         Text = i.Name,
        //         Value = i.Id.ToString()
        //     });
        //     ViewBag.CategoryList = categories;
        //
        //     return View(car);
        // }
        //
        // [HttpPost]
        // public IActionResult Edit(Parfume obj)
        // {
        //     if (!ModelState.IsValid) return View();
        //
        //     _context.Parfumes.Update(obj);
        //     _context.SaveChanges();
        //
        //     return RedirectToAction(nameof(Index));
        // }
    }
}
