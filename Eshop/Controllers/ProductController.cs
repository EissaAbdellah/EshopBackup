using Eshop.Models;
using Eshop.Services.Category_Repo;
using Eshop.Services.Product_Repo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Eshop.Controllers
{
    public class ProductController : Controller
    {
       private readonly IProductRepo _productRepo;
       private readonly ICategoryRepo _categoryRepo;


        public ProductController(IProductRepo productRepo, ICategoryRepo categoryRepo)
        {
            _productRepo = productRepo;
            _categoryRepo = categoryRepo;
        }



        // GET: ProductController
        public ActionResult Index()
        {
            return View(_productRepo.GetAll());
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {

            return View(_productRepo.GetDetails(id));
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            ViewBag.Category = _categoryRepo.GetAll();
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task< ActionResult> Create(Product prd)
        {
           

            try
            {
              if(Request.Form.Count>0)
                {
                    var file = Request.Form.Files.FirstOrDefault();
                    using(var datastream=new MemoryStream())
                    {
                        await file.CopyToAsync(datastream);
                        prd.Image = datastream.ToArray();
                    }
                }

                prd.Category = _categoryRepo.GetDetails(prd.Category.Id);
                
                _productRepo.Insert(prd);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {

            return View(_productRepo.GetDetails(id));
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Product prd )
        {
            try
            {
                _productRepo.UpdateByID(id,prd);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {

            return View(_productRepo.GetDetails(id));
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                _productRepo.DeleteByID(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
