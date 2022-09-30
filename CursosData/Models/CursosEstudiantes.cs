namespace CursosData.Models
{
    public class CursosEstudiantes
    {
        //public int Id { get; set; }

        //Clave Foránea Curso
        public int CursoId { get; set; }
        public Curso Curso { get; set; }

        //Clave Foránea Estudiante
        public int EstudianteId { get; set; }
        public Estudiante Estudiante { get; set; }
    }
}