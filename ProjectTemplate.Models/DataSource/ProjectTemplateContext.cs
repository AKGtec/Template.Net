using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectTemplate.Models.Entities;

namespace ProjectTemplate.Models.DataSource;

public class ProjectTemplateContext : IdentityDbContext
{
    public ProjectTemplateContext(DbContextOptions<ProjectTemplateContext> options) : base(options)
    {
    }

    // Add your DbSets here
    // Example: public DbSet<User> Users { get; set; }
    // Example: public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configure your entity relationships here
        // Example:
        // modelBuilder.Entity<User>()
        //     .HasKey(u => u.Id);
        
        // modelBuilder.Entity<Product>()
        //     .HasOne(p => p.User)
        //     .WithMany(u => u.Products)
        //     .HasForeignKey(p => p.UserId);
    }
}
