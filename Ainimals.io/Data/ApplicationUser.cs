using Microsoft.AspNetCore.Identity;

namespace Ainimals.io.Data;

public class ApplicationUser : IdentityUser
{
    public ICollection<Order> Orders { get; set; }
}