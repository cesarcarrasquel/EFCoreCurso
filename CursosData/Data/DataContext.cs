using CursosData.Models;
using Microsoft.EntityFrameworkCore;

namespace CursosData.Data
{
    public class DataContext: DbContext
    {
        // constructor con Inyección de Dependencias
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
            
        }

        // para que se hace esto?
        public DbSet<Estatus> Estatus {get; set;}
        public DbSet<Curso> Cursos {get; set;}
        public DbSet<Profesor> Profesores {get; set;}
        public DbSet<Estudiante> Estudiantes {get; set;}
        public DbSet<CursosEstudiantes> CursosEstudiantes {get; set;}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //Definimos nuestra llave primaria
            builder.Entity<CursosEstudiantes>().HasKey(ce=>new {ce.CursoId, ce.EstudianteId});

            // definimos nuestras relaciones entre tablas o Foreign key
            // Cursos
            builder.Entity<CursosEstudiantes>()
                .HasOne<Curso>(ce => ce.Curso)
                .WithMany(c => c.CursosEstudiantes)
                .HasForeignKey(ce => ce.CursoId);

            // Estudiantes
            builder.Entity<CursosEstudiantes>()
                .HasOne<Estudiante>(e => e.Estudiante)
                .WithMany(c => c.CursosEstudiantes)
                .HasForeignKey(ce => ce.EstudianteId);

        }
    }
}