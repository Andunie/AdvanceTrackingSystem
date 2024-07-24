using Microsoft.EntityFrameworkCore;

namespace AspireApp2.Web.Model
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Kullanici> Kullanicilar { get; set; }

        public DbSet<Teminat> Teminatlar { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teminat>()
                .Property(t => t.Statement)
                .HasDefaultValue("Onay Bekliyor");

            base.OnModelCreating(modelBuilder);
        }
    }
}