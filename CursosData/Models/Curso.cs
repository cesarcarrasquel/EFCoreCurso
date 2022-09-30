namespace CursosData.Models
{
    public class Curso
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Objetivo { get; set; }
        public DateTime FechaDeAlta { get; set; }
        
        //FK (Clave Foránea) Estatus    One-To-Many   (Uno)
        public int EstatusId { get; set; }   //Nombre de la tabla + campo Id
        public Estatus Estatus { get; set; } //Debe ponerse 

        //FK Profesor
        public int ProfesorId { get; set; }
        public Profesor Profesor {get; set;}


        public IEnumerable<CursosEstudiantes> CursosEstudiantes {get; set;}

    }
}