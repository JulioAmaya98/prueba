using AppTiendaLol.Models;
using Microsoft.EntityFrameworkCore;

namespace AppTiendaLol
{
    public class AppDbContex : DbContext
    {

        DbSet<Producto> Productos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data source=JULIO\\SQLEXPRESS;Initial Catalog=db_Lolsito; Integrated Security=True;TrustServerCertificate=True; MultipleActiveResultSets=True");
        }

    }
}
