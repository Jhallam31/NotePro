using NotePro.Models.Category;
using NotePro.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NotePro.WebMVC.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            var service = new CategoryService();
            var model = service.GetCategories();
            return View(model);
        }

        //GET: Create
        //....Category/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        //POST: Create
        //....Category/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CategoryCreate model)
        {
            if (!ModelState.IsValid) return View(model);

            var service = CreateCategoryService();

            if (service.CreateCategory(model))
            {
                TempData["SaveResult"] = "Your category was created.";
                return RedirectToAction("Index");
            };

            ModelState.AddModelError("", "Category could not be created.");

            return View(model);
        }

        //GET: Detail
        //..../Category/Detail/{id}
        [HttpGet]
        public ActionResult Details(string id)
        {
            var svc = CreateCategoryService();
            var model = svc.GetCategoryById(id);

            return View(model);
        }
        private CategoryService CreateCategoryService()
        {
            var service = new CategoryService();
            return service;
        }
    }
}