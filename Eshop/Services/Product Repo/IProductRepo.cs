using Eshop.Models;

namespace Eshop.Services.Product_Repo
{
    public interface IProductRepo
    {
        public List<Product> GetAll();

        public Product GetDetails(int id);

        public void Insert(Product prd);

        public void UpdateByID(int id, Product prd);

        public void DeleteByID(int id);


        public List<Product> GetAllProductByCat(int catId);



       



    }
}
