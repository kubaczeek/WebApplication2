using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication2.Data;

namespace WebApplication2.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDBContext _db;

    public IndexModel(ApplicationDBContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
        }
    }
}
