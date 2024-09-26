using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Numerics;

namespace ConverseBankTaskAPI.DBContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Photo> Photos { get; set; }
    }
}
