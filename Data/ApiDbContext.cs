using DemoApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoApp.Data;

public class ApiDbContext : DbContext
{
    public ApiDbContext(DbContextOptions options)
        : base(options) { }

    // do i need this?
    //   protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //             => optionsBuilder.UseNpgsql("Host=my_host;Database=my_db;Username=my_user;Password=my_pw");
    //     }
    public DbSet<User> Users { get; set; }
}
