using System.Collections.Generic;
using ASPNET_MVC.Data;
using ASPNET_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNET_MVC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Index()
        {   
            IEnumerable<Category> objlist = _db.Category;
            return View(objlist);
        }

        [HttpGet]
        public IActionResult Create()
        {   
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category obj)
        {   
            if(ModelState.IsValid){
            _db.Category.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
            }
            return View();
        }
    }
}