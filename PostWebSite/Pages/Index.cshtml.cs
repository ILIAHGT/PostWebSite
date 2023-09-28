using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PostWebSite.Models;
using Microsoft.EntityFrameworkCore;

namespace PostWebSite.Pages
{
    public class IndexModel : PageModel
    {
        public List<Post> PostList;
        public void OnGet()
        {
            using(AppDbContext dbContext = new AppDbContext())
            {
                PostList = dbContext.Posts.Include(p => p.Tag)
                    .OrderByDescending(p => p.PulishedDate)
                    .ToList();
            }
        }
    }
}