using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class File
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
