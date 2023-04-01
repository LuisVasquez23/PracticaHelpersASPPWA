using Microsoft.EntityFrameworkCore;
using WebMVC_PWA.Models;

namespace WebMVC_PWA.Data
{
    public class EquipoContext : DbContext
    {

        public EquipoContext(DbContextOptions options) : base(options)
        {

        }


        public DbSet<marcas> marcas { get; set; }   

    }
}
