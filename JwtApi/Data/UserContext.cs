using Microsoft.EntityFrameworkCore;

namespace JwtApi.Data;

public class UserContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    public UserContext(DbContextOptions<UserContext> options) : base(options)
    {
        
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(new List<User>{
            new User { Id=1,Name="Ferhat",Age=25},
            new User { Id=2,Name="Betül",Age=25},
            new User { Id=3,Name="İlker",Age=30},
        });
        modelBuilder.Entity<Role>().HasData(new List<Role>{
            new Role { Id=1,Name="Admin"},
            new Role { Id=2,Name="Member"}
        });
        base.OnModelCreating(modelBuilder);
    }
}
