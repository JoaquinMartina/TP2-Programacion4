using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Alumno
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo no debe ser vacío")]
        [Display(Name = "Nombre")]

        public string Nombre { get; set; }

        [Required(ErrorMessage = "Este campo no debe ser vacío")]
        [Display(Name = "Apellido")]

        public string Apellido { get; set; }

        [Required(ErrorMessage = "Este campo no debe ser vacío")]
        [Display(Name = "Legajo")]
        [Range(10000, 19999, ErrorMessage = "El número debe estar entre {1} - {2}")]

        public int Legajo { get; set; }

        [Required(ErrorMessage = "Este campo no debe ser vacío")]
        [Display(Name = "Edad")]
        [Range(17, 100, ErrorMessage = "La edad debe ser como minimo de {1}")]

        public int Edad { get; set; }

        [Required(ErrorMessage = "Este campo no debe ser vacío")]
        [Display(Name = "Año de Ingreso")]
        [Range(2010, 2020, ErrorMessage = "El año debe estar entre {1} - {2}")]

        public int AñoIngreso { get; set; }

        [Required(ErrorMessage = "Este campo no debe ser vacío")]
        [Display(Name = "Año de Cursado")]
        [Range(1, 6, ErrorMessage = "El año debe estar entre {1} - {2}")]

        public int AñoCursado { get; set; }

        [Display(Name = "Localidad")]
        public int? LocalidadId { get; set; }
        public Localidad Localidad { get; set; }
    
        [Display(Name = "Carrera")]
        public int? CursoId { get; set; }
        public Curso Curso { get; set; }

        [Display(Name = "Foto Alumno")]
        public string FotoCarnet { get; set; }

        public List<AlumnoCatedra> AlumnosCatedras { get; set; }
    }
}
