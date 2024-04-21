using Microsoft.EntityFrameworkCore;
using REM_BFF_V1.Infra.Connections;

namespace REM_BFF_V1.Infra.Models
{
    public class REMContext : DbContext
    {
        public REMContext(DbContextOptions<REMContext> options) : base(options) { }

        public DbSet<Profile> Profiles { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
