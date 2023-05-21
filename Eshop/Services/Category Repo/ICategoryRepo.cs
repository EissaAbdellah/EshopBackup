using Eshop.Models;

namespace Eshop.Services.Category_Repo
{
    public interface ICategoryRepo
    {
        
        public List<Category> GetAll();

        public Category GetDetails(int id);

        public void Insert(Category catg);
        public void UpdateByID(int id, Category catg);
        public void DeleteByID(int id);






    }
}
