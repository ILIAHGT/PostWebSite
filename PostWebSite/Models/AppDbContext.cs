using Microsoft.EntityFrameworkCore;

namespace PostWebSite.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<Tag> Tags { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string desktopaddress = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); 

            optionsBuilder.UseSqlite($"Data Source={desktopaddress}\\postapp.db;");
        }
    }
}
