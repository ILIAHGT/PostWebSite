using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PostWebSite.Models;

namespace PostWebSite.Pages
{
    public class CreateTagModel : PageModel
    {
        [BindProperty]
        public Tag Tag { get; set; }
        
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            using(AppDbContext dbcontext = new AppDbContext())
            {
                dbcontext.Tags.Add(Tag);
                dbcontext.SaveChanges();
            }


            return RedirectToPage("Index");
        }
    }
}
