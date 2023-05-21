using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Admin.Models
{
    public class Product
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Text), MinLength(3), MaxLength(20)]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required]
        [DataType(DataType.MultilineText), MaxLength(300)]
        public string Descreption { get; set; }

        [Required, DataType(DataType.ImageUrl)]
        public string ImageUrl { get; set; }

        [Required]
        public int QuantityInTheStock { get; set; }

        public int CategoryId { get; set; }
    }
}
