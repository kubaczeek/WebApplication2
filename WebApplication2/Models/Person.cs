using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Person
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public ICollection<File> Products { get; set; }
        public File Photo { get; set; }
    }
}
