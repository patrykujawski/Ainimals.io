using Ainimals.io.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Ainimals.io.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<Order> Orders { get; set; }
    // public DbSet<PaymentState> PaymentStates { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Order>()
            .HasKey(x => x.Id)
            .HasName("PK_OrderId");
        builder.Entity<Order>()
        .HasOne(x => x.User)
        .WithMany(x => x.Orders)
        .HasForeignKey(x => x.UserId)
        .IsRequired();
        // builder.Entity<Order>()
        //     .Property(x => x.PaymentStatus)
        //     .HasConversion(v => v.ToString(),
        //         v => (PaymentStatus)Enum.Parse(typeof(PaymentStatus), v));
        // builder.Entity<PaymentState>()
        //     .HasNoKey()
        //     .Property(x=>x.PaymentStatus)
        //     .HasConversion(v=>v.ToString(), 
        //         v=>(PaymentStatus)Enum.Parse(typeof(PaymentStatus),v));
        
        base.OnModelCreating(builder);
    }
}