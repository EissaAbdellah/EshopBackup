using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Eshop.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required,MaxLength(100)]
        public string Name { get; set; }

        [Required, MaxLength(100)]
        public string Address { get; set; }
    }
}
