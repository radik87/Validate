using Microsoft.EntityFrameworkCore;

namespace Validation.Models
{
    public class DijaDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=DijaTestTaskDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
