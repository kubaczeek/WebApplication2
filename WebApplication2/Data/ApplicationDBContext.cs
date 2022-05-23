using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;
using File = WebApplication2.Models.File;

namespace WebApplication2.Data
{

    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

       public DbSet<Category> Categories { get; set; }
       public DbSet<File> Files { get; set; }
       public DbSet<Product> Products { get; set; }
       public DbSet<Person> People { get; set; }

    }
}
