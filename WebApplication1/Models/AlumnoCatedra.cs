using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class AlumnoCatedra
    {
        [Display(Name = "Alumno")]
        public int AlumnoId { get; set; }

        [Display(Name = "Cátedra")]
        public int CatedraId { get; set; }

        [Display(Name = "Alumno")]
        public Alumno Alumno { get; set; }

        [Display(Name = "Cátedra")]
        public Catedra Catedra { get; set; }

        [Display(Name = "Cuatrimestre")]
        [Range(1, 2, ErrorMessage = "El número debe ser 1 o 2")]
        [Required(ErrorMessage = "Este campo no debe ser vacío")]
        public int Cuatrimestre { get; set; }

        [Display(Name = "Fecha de Inscripción")]
        [Required(ErrorMessage = "Este campo no debe ser vacío")]
        public DateTime FechaInscripto { get; set; }
    }
}
