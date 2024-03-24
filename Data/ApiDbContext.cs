using DemoApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoApp.Data;

public class ApiDbContext : DbContext
{
    public ApiDbContext(DbContextOptions options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<User>()
                           .HasMany(u => u.Roles)
                           .WithMany(r => r.Users)
                           .UsingEntity<UserRole>(
                                userRole => userRole.HasKey(e => new { e.RoleId, e.UserId }));
                                // userRole => userRole.HasOne<Role>().WithMany().HasForeignKey(r => r.RoleId),
                                // userRole => userRole.HasOne<User>().WithMany().HasForeignKey(u => u.UserId),
    }



    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
}
