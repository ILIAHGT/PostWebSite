using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;

namespace PostWebSite.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string AuthorName { get; set; }

        public DateTime PulishedDate { get; set; }

        public Tag Tag { get; set; }
    }
}
