using Eshop.Data;
using Eshop.Models;

namespace Eshop.Services.Category_Repo
{
    public class CategoryRepoServices:ICategoryRepo
    {

        private readonly EshopContext context;
        

        public CategoryRepoServices(EshopContext context)
        {
            this.context = context;
        }

        public List<Category> GetAll()
        {
            return (context.Categories.ToList());
        }

        public Category GetDetails(int id)
        {
            return context.Categories.Find(id);
        }

        public void Insert(Category catg)
        {
            context.Categories.Add(catg);
            context.SaveChanges();
        }

        public void UpdateByID(int id, Category catg)
        {
            Category category = context.Categories.Find(id);

            category.Name = catg.Name;

            context.SaveChanges();


        }


        public void DeleteByID(int id)
        {
            context.Categories.Remove(context.Categories.Find(id));

            context.SaveChanges();

            
        }

      


    }
}
