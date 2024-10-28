using System.ComponentModel.DataAnnotations;

namespace VillalbaJuan_examen1.Models
{
    public class ErrorViewModel
    {
        [Key] 
        public int Id { get; set; }
        public float peso { get; set; }
        public string Nombre { get; set; }
        public bool genero { get; set; }
        public int fecha { get; set; }
    }
}
