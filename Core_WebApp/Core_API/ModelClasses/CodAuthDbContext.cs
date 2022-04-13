using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Core_API.ModelClasses
{
    public class CodAuthDbContext : IdentityDbContext<IdentityUser>
    {
        public CodAuthDbContext(DbContextOptions<CodAuthDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }

}
