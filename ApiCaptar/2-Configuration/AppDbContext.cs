using apiCaptar._1_Domain;
using Microsoft.EntityFrameworkCore;
using System.Reflection.PortableExecutable;

namespace apiCaptar.Configuration
{
    public class MySQLContext : DbContext
    {
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios
        {
            get; set;
        }public DbSet<pesquisa> pesquisa
        {
            get; set;
        }
    }
}
