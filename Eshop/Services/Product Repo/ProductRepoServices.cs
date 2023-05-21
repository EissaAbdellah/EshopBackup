using Eshop.Data;
using Eshop.Models;

namespace Eshop.Services.Product_Repo
{
    public class ProductRepoServices : IProductRepo
    {
        private readonly EshopContext _context;
        public ProductRepoServices(EshopContext context)
        {
            _context = context;
        }
        public void DeleteByID(int id)
        {
            _context.Products.Remove(_context.Products.Find(id));
            _context.SaveChanges();
        }

        public List<Product> GetAll()
        {
            return (_context.Products.ToList());
        }

        public List<Product> GetAllProductByCat(int catId)
        {
            return (_context.Products.Where(d=>d.Category.Id==catId).ToList());
        }

        public Product GetDetails(int id)
        {
            return (_context.Products.Find(id));
        }

        public void Insert(Product prd)
        {
            _context.Products.Add(prd);
            _context.SaveChanges();
        }

        public void UpdateByID(int id, Product prd)
        {
            Product product = _context.Products.Find(id);

            product.Name = prd.Name;
            product.Price = prd.Price;
            product.Category = prd.Category;
           
            
             //Apply Image update here

            _context.SaveChanges();


            //check her to update category

           

        }
    }
}
