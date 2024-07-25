using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Ainimals.io.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<Order> Orders { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Order>().HasOne(x => x.User)
            .WithMany(x => x.Orders)
            .HasForeignKey(x => x.UserId)
            .IsRequired();
        base.OnModelCreating(builder);
    }
}