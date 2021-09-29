
using Microsoft.EntityFrameworkCore;
using Dominio;

namespace Persistencia
{
    public class ApplicationDbContext : DbContext
    {
        
        public DbSet<Personas> Personas { set; get; }
        public DbSet<Clientes> Clientes { set; get; }
        public DbSet<Empleados> Empleados { set; get; }
        public DbSet<Empresas> Empresas { set; get; }
        public DbSet<Cargos> Cargos { set; get; }
        public DbSet<Categorias_Directivos> Categorias_Directivos { set; get; }
        
        private const string ConnectionString = @"Data source=localhost\sqlexpress;Initial Catalog = solusoft;Integrated Security = True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
                optionsBuilder
                .UseSqlServer(ConnectionString);
            }
        }
    }
}