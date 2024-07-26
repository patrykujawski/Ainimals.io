using Ainimals.io.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Ainimals.io.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<Order> Orders { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Order>()
            .HasOne(x => x.User)
            .WithMany(x => x.Orders)
            .HasForeignKey(x => x.UserId)
            .IsRequired();

        builder.Entity<PaymentState>()
            .HasOne(p => p.Order)
            .WithOne(x => x.State)
            .HasForeignKey<Order>(x=>x.PaymentStateId);
        
        
        builder.Entity<PaymentState>()
            .Property(x => x.State)
            .HasConversion(v => v.ToString(),
                v => (PaymentStatus)Enum.Parse(typeof(PaymentStatus), v));

        base.OnModelCreating(builder);
    }
}