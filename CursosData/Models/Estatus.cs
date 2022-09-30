namespace CursosData.Models
{
    public class Estatus
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaDeAlta{ get; set; }

        //One-To-Many (Muchos)
        public IEnumerable<Profesor> Profesores {get; set;}
        public IEnumerable<Estudiante> Estudiantes {get; set;}
        public IEnumerable<Curso> Cursos {get; set;}
    }
}