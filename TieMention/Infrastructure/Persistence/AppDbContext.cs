using Microsoft.EntityFrameworkCore;
using TieMention.Domain.Entities;

namespace TieMention.Infrastructure.Persistence;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Mention> Mentions => Set<Mention>();
    public DbSet<Category> Categories => Set<Category>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // // Exemplo de configuração adicional
            // modelBuilder.Entity<Mention>()
            //     .HasOne(m => m.Category)
            //     .WithMany()
            //     .HasForeignKey(m => m.CategoryId);
        }
}
