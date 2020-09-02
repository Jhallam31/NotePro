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

        //GET: Edit
        //....Category/Edit/{id}
        [HttpGet]
        public ActionResult Edit(string id)
        {
            var service = CreateCategoryService();
            var detail = service.GetCategoryById(id);
            var model =
                new CategoryEdit
                {
                    Name = detail.Name,
                    CategoryId = detail.CategoryId
                };
            return View(model);
        }

        //POST: Edit
        //....Category/Edit/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CategoryEdit model, string id)
        {
            if (!ModelState.IsValid) return View(model);
            if(model.CategoryId != id)
            {
                ModelState.AddModelError("", "Id Mismatch");
                return View(model);
            }
            var service = CreateCategoryService();
            if (service.UpdateCategory(model))
            {
                TempData["SaveResult"]= "Your category was updated";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Category could not be updated.");
            return View(model);
            
        }

        //GET: Delete
        //..../Category/Delete/{id}
        [HttpGet]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string id)
        {
            var svc = CreateCategoryService();
            var model = svc.GetCategoryById(id);

            return View(model);

        }

        //POST: Delete
        //..../Category/Delete/{id}
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeletePost(string id)
        {
            var service = CreateCategoryService();
            service.DeleteCategory(id);

            TempData["SaveResult"] = "Category was successfully deleted.";

            return RedirectToAction("Index");

        }
        private CategoryService CreateCategoryService()
        {
            var service = new CategoryService();
            return service;
        }
    }
}