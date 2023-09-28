using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PostWebSite.Models;

namespace PostWebSite.Pages
{
    public class CreatePostModel : PageModel
    {
        [BindProperty(SupportsGet =true)]
        public Post Post { get; set; }
        [BindProperty(SupportsGet = true)]
        public int id { get; set; }
        public List<Tag> TagList { get; set; }
        public void OnGet()
        {
            using (AppDbContext dbcontext = new AppDbContext())
            {
                Post = dbcontext.Posts.Where(p => p.Id == id).FirstOrDefault();
                TagList = dbcontext.Tags.ToList();
            }
        }

        public IActionResult OnPost()
        {
            using(AppDbContext dbcontext = new AppDbContext())
            {
                Post.PulishedDate = DateTime.Now;
                var tag = dbcontext.Tags.Where(t => t.Id ==  Post.Tag.Id).FirstOrDefault();
                Post.Tag = tag;
                
                
                if(id > 0)
                {
                    var p = dbcontext.Posts.Where(p => p.Id == id).FirstOrDefault();
                    Post.Id = p.Id;
                    dbcontext.Posts.Remove(p);
                }
                dbcontext.Posts.Add(Post);
                dbcontext.SaveChanges();
            }


            return RedirectToPage("Index");
        }
    }
}
