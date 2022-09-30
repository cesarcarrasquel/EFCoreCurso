namespace CursosData.Models
{
    public class Estudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public DateTime FechaDeAlta{ get; set; }

        //FK (Clave Foránea)    One-To-Many
        public int EstatusId { get; set; }   //Nombre de la tabla + campo Id
        public Estatus Estatus { get; set; } //Debe ponerse 


        //
        public IEnumerable<CursosEstudiantes> CursosEstudiantes {get; set;}
    }
}