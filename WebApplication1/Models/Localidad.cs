using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Localidad
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo no debe ser vacío")]
        [Display(Name = "Nombre")]
        [StringLength(20)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Este campo no debe ser vacío")]
        [Display(Name = "Provincia")]
        [StringLength(20)]
        public string Provincia { get; set; }

        public List<Alumno> Alumnos { get; set; }
    }
}
