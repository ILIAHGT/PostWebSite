using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PostWebSite.Models;

namespace PostWebSite.Pages
{
    public class postdetailModel : PageModel
    {
        
        [BindProperty(SupportsGet =true)]
        public int id { get; set; }
        public Post post { get; set; }
        public void OnGet()
        {
            using (AppDbContext dbContext = new AppDbContext())
            {
                post = dbContext.Posts.Where(p => p.Id == id).Include(p => p.Tag).FirstOrDefault();
            }


        }
    }
}
