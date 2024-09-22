using DeMoMVC.Models;
using Microsoft.EntityFrameworkCore;
namespace DeMoMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}
        public DbSet<Person> Person { get; set;}
    }
}