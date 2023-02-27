using Ecomm.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Ecomm.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
    }
}
