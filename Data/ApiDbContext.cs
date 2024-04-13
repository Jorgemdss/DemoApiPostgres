using DemoApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace DemoApp.Data;

public class ApiDbContext : IdentityDbContext
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
    }



    /// <summary>
    /// The DB set for the user Entity.
    /// Do not confuse with the Identity DB set "Users"
    /// </summary>
    /// <value></value>
    public DbSet<User> UsersApi { get; set; }
    public DbSet<Role> RolesApi { get; set; }

}
