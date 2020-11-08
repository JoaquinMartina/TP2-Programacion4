using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Catedra
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo no debe ser vacío")]
        [Display(Name = "Nombre Cátedra")]
        [StringLength(50)]
        public string Descripcion { get; set; }

        public List<AlumnoCatedra> AlumnosCatedras { get; set; }
    }
}
