
using Microsoft.EntityFrameworkCore;
using NEWMVC.Models;

namespace NEWMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Person> Person { get; set; } = default!;
        public DbSet<Student> Student { get; set; } = default!;
    }
}
