namespace backend_crud_examen.Models
{
    public class Persona    
    {

        public int Id { get; set; } 
        public string Código { get; set; } 

        public string Descripción { get; set; } 

        public string?UnidadMedida { get; set; }

        public DateTime FechaCreacion { get; set; }
    }
}
