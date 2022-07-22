using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

//Update this using statement to include your project name
using Le_Crystal_HW4.Models;

//Upddate this namespace to match your project name
namespace Le_Crystal_HW4.DAL
{
    //NOTE: This class definition references the user class for this project.  
    //If your User class is called something other than AppUser, you will need
    //to change it in the line below
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            //this code makes sure the database is re-created on the $5/month Azure tier
            builder.HasPerformanceLevel("Basic");
            builder.HasServiceTier("Basic");
            base.OnModelCreating(builder);
        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        //Add Dbsets here.  Products is included as an example.
        public DbSet<Product> Products { get; set; }
    }
}