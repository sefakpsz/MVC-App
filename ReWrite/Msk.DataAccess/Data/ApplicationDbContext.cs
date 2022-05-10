using Microsoft.EntityFrameworkCore;
using ReWrite.Msk.Models.Models;

namespace ReWrite.Msk.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base()
        {

        }
        public DbSet<CoverType> CoverTypes { get; set; }
    }
}
