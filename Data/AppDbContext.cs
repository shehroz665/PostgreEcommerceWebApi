using Microsoft.EntityFrameworkCore;
using PostgreEcommerceWebApi.Models;

namespace PostgreEcommerceWebApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) { }
        public DbSet<Product> Products => Set<Product>();
    
    }
}
