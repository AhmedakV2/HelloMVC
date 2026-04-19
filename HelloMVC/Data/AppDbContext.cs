using HelloMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace HelloMVC.Data
{
   
    public class AppDbContext : DbContext
    {
        
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<Ogretmen> Ogretmenler { get; set; }
    }
}