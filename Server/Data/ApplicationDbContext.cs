using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PaginaWebCEAA.Server.Models;
//using PaginaWebCEAA.Shared;



namespace PaginaWebCEAA.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        //public DbSet<Empleado> Empleados { get; set; }
        //public DbSet<Salario> Salarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          
            base.OnModelCreating(modelBuilder);

            // Definir la clave primaria para la entidad Usuarios
            //modelBuilder.Entity<Empleado>().HasKey(u => u.id_emp);
            //modelBuilder.Entity<Salario>().HasKey(u => u.id_sal);

            // Otros ajustes de configuración del modelo...
        }
    }
}


