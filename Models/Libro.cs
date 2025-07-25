using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibreriaCRUD.Models
{
    public class Libro
    {

       
        public int Id { get; set; }

        [Required(ErrorMessage = "El titulo del libro es obligatorio.")]
        [StringLength(150)]

        public string Titulo { get; set; }

        //Relación con Autor 

        public int AutorId { get; set; }

        [ForeignKey("AutorId")]

        public Autor Autor { get; set; }
    }
}