using Microsoft.EntityFrameworkCore;
namespace mvcPractica01.Models
{
    public class equiposDbContext : DbContext
    {
        public equiposDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<marcas> marcas { get; set; }
    }
}
