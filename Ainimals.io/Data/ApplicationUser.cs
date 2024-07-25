using Microsoft.AspNetCore.Identity;

namespace Ainimals.io.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    public ICollection<Order> Orders { get; set; }
}