using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WishList.Data;
using WishList.Models;

namespace WishList.Controllers
{
    public class ItemController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ItemController(ApplicationDbContext _context)
        {
            this._context = _context;
        }

       

        public IActionResult Index()
        {
            var items = this._context.Items.ToList();
            return View("Index",items);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        public IActionResult Create(Item item)
        {
            this._context.Add(item);
            this._context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpDelete]
        public IActionResult Delete(int Id)
        {
            var item = this._context.Items.Find(Id);
            this._context.Remove(item);
            this._context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
