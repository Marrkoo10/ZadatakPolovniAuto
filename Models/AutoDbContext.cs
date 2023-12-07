using Microsoft.EntityFrameworkCore;

namespace ZadatakPolovniAuto.Models
{
    public class AutoDbContext : DbContext 
    {
        public AutoDbContext(DbContextOptions<AutoDbContext> options) : base(options)
        {

        }

        public DbSet<Car> Cars { get; set; }
    }
}

