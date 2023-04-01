using Microsoft.EntityFrameworkCore;
using mvcPractica01.Models;
namespace mvcPractica01.Models
{
    public class equiposDbContext : DbContext
    {
        public equiposDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<marcas> marcas { get; set; }
        public DbSet<mvcPractica01.Models.Estados_equipo>? Estados_equipo { get; set; }
        public DbSet<mvcPractica01.Models.carreras>? carreras { get; set; }
        public DbSet<mvcPractica01.Models.estados_reserva>? estados_reserva { get; set; }
        public DbSet<mvcPractica01.Models.facultades>? facultades { get; set; }
        public DbSet<mvcPractica01.Models.tipo_equipo>? tipo_equipo { get; set; }
        public DbSet<mvcPractica01.Models.usuarios>? usuarios { get; set; }
    }
}
