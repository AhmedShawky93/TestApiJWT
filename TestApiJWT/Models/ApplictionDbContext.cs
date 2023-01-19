using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TestApiJWT.Models
{
    public class ApplictionDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplictionDbContext(DbContextOptions<ApplictionDbContext> options) : base(options)
        {

        }
    }
}
