using Eshop.Models;
using Eshop.Services.Category_Repo;
using Eshop.Services.Product_Repo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Eshop.Controllers
{
    public class CategoryController : Controller
    {

        private readonly ICategoryRepo _categoryRepo;
        private readonly IProductRepo _productRepo;

        public CategoryController(ICategoryRepo categoryRepo, IProductRepo productRepo )
        {
            _categoryRepo = categoryRepo;
            _productRepo = productRepo;
        }
        // GET: CategoryController
        public ActionResult Index()
        {
           
            return View(_categoryRepo.GetAll());
        }

        // GET: CategoryController/Details/5
        public ActionResult Details(int id)
        {
            Category categ = _categoryRepo.GetDetails(id);
            return View(categ);
        }

        // GET: CategoryController/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Category catg)
        {
            try
            {
                _categoryRepo.Insert(catg);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoryController/Edit/5
        public ActionResult Edit(int id)
        {

            return View(_categoryRepo.GetDetails(id));
        }

        // POST: CategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Category catg)
        {
            try
            {
                _categoryRepo.UpdateByID(id, catg);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoryController/Delete/5
        public ActionResult Delete(int id)
        {

            return View(_categoryRepo.GetDetails(id));
        }

        // POST: CategoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Category catg)
        {
            try
            {
                _categoryRepo.DeleteByID(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult GetAllProductsByCatId(int id)
        {
            var Products = _productRepo.GetAll();
            return View(Products);
        }



    }
}
