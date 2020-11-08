using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class AlumnoCatedra
    {
        public int AlumnoId { get; set; }
        public int CatedraId { get; set; }

        public Alumno Alumno { get; set; }

        public Catedra Catedra { get; set; }

        public int Cuatrimestre { get; set; }

        [Display(Name = "Inscripción")]
        public DateTime FechaInscripto { get; set; }
    }
}
