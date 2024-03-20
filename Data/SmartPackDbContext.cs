using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace SmartPack.Data
{
    public class AppDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public AppDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to postgres with connection string from app settings
            options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"));
        }

    public DbSet<Gjenstand> Gjenstander { get; set; }
    public DbSet<Kategori> Kategorier { get; set; }
    public DbSet<Regelverk> Regelverker { get; set; }
    public DbSet<Regelverktag> Regelverktager { get; set; }
    }
}