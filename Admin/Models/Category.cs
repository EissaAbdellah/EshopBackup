using System.ComponentModel.DataAnnotations;

namespace Admin.Models
{
    public class Category
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Text), MinLength(3), MaxLength(20)]
        public string Name { get; set; }


        [Required]
        [DataType(DataType.MultilineText), MaxLength(300)]
        public string Descreption { get; set; }

        public virtual ICollection<Product> Products { get; set; }


    }
}
