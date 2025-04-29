using TieMention.Core.Models; // Entidades do domínio
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace TieMention.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Mention> Mention { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configuração para UUID no PostgreSQL (PONTO 5)
        modelBuilder.HasPostgresExtension("uuid-ossp"); // Habilita a extensão UUID

        // Configuração da entidade Mention
        modelBuilder.Entity<Mention>(entity =>
        {
            entity.HasKey(p => p.Id);

            entity.Property(p => p.Id)
                .HasDefaultValueSql("uuid_generate_v4()"); // Gera UUID automaticamente

            entity.Property(p => p.Title)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(p => p.Content)
                .IsRequired();

            entity.Property(p => p.CreatedAt)
                .HasDefaultValueSql("NOW()"); // PostgreSQL usa NOW()

            // entity.HasMany(p => p.Comments)
            //     .WithOne(c => c.Post)
            //     .HasForeignKey(c => c.PostId)
            //     .OnDelete(DeleteBehavior.Cascade);
        });

    }
}