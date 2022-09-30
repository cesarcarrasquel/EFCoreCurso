namespace CursosData.Models
{
    public class Profesor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaDeAlta{ get; set; }
        
        //FK (Clave Foránea)    One-To-Many
        public int EstatusId { get; set; }   //Nombre de la tabla + campo Id
        public Estatus Estatus { get; set; } //Debe ponerse 

        //
        public IEnumerable<Curso> Cursos {get; set;}
    }
}