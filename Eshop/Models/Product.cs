using System.ComponentModel.DataAnnotations;

namespace Eshop.Models
{
    public class Product
    {
        public Product()
        {
            
        }

        [Key, Required]
        public int Id { get; set; }

        [Required, MaxLength(100), MinLength(2), DataType(DataType.Text)]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required,DataType(DataType.Date)]
        public string Date { get; set; } = DateTime.Now.ToString("dddd, dd MMMM yyyy");

        [Required]
        public byte[] Image { get; set; }

        [Required]
        public int QuantityInStocke { get; set; }


        public virtual Category Category { get; set; }

    }
}
