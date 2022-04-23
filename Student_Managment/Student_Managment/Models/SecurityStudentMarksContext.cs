using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Student_Managment.Models
{
    public class SecurityStudentMarksContext : IdentityDbContext<IdentityUser>
    {
        public SecurityStudentMarksContext(DbContextOptions<SecurityStudentMarksContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
