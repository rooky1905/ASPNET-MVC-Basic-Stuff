using ASPNET_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPNET_MVC.Data
{
    public class ApplicationDbContext : DbContext
    {
       public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
       {
           
       } 

        public DbSet<Category> Category { get; set; }
        // public DbSet<Applications> Application { get; set; }
    }   
}