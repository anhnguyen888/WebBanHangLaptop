using Microsoft.EntityFrameworkCore;
using WebBanHangLaptop.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
namespace WebBanHangLaptop.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
    }
}
