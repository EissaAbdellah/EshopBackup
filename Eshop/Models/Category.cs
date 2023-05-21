using System.ComponentModel.DataAnnotations;

namespace Eshop.Models
{
    public class Category
    {
        public Category()
        {
            Products = new List<Product>();
        }

        [Key,Required]
        public int Id { get; set; }

        [Required,MaxLength(100), MinLength(2),DataType(DataType.Text)]
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }


    }
}
