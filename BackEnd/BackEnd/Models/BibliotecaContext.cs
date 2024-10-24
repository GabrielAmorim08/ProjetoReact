using BackEnd.Models.Usuarios;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Models
{
    public class BibliotecaContext : DbContext
    {
        BibliotecaContext(DbContextOptions<BibliotecaContext> context) : base(context) {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var connectionString = builder["ConnectionStrings:bibliotecaContext"];
            optionsBuilder.UseSqlServer(connectionString);
        }
        public DbSet<Usuario> Usuario { get; set; }
    }
}
