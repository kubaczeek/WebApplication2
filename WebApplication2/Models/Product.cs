using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Product
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public ICollection<File> Photos { get; set; }
    }
}
