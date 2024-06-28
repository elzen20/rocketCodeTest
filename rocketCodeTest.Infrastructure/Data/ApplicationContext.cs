using Microsoft.EntityFrameworkCore;
using rocketCodeTest.Domain.Entities;
using Microsoft.Extensions.Configuration;

namespace rocketCodeTest.Infrastructure.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        private readonly IConfiguration _configuration;

        public ApplicationContext(DbContextOptions<ApplicationContext> options, IConfiguration configuration)
            : base(options)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
               optionsBuilder.UseMySQL(_configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("ConnectionString not found."));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuración del modelo para la entidad User
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users_test_carlos_quintero"); // Nombre de la tabla en la base de datos

                entity.HasKey(e => e.Id); // Definir la clave primaria

                // Mapeo de propiedades
                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Nombre).HasColumnName("nombre");
                entity.Property(e => e.SegundoNombre).HasColumnName("segundo_nombre");
                entity.Property(e => e.ApellidoPaterno).HasColumnName("apellido_paterno");
                entity.Property(e => e.ApellidoMaterno).HasColumnName("apellido_materno");
                entity.Property(e => e.FechaDeNacimiento).HasColumnName("fecha_de_nacimiento");
                entity.Property(e => e.Email).HasColumnName("email");
                entity.Property(e => e.Telefono).HasColumnName("telefono");
            });
        }
    }
}
