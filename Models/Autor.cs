using LibreriaCRUD.Controllers;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibreriaCRUD.Models
{
    public class Autor
    {
        public Autor()
        {
            Libros = new HashSet<Libro>();
        }

        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre del autor debe ser Obligatorio.")]
        [StringLength(100)]

        public string Nombre { get; set; }

        public ICollection<Libro> Libros { get; set; }
    }
}