using medical_plaza.Models;
using Microsoft.EntityFrameworkCore;

namespace medical_plaza.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Doctors> Doctors { get; set; }
    }
}
