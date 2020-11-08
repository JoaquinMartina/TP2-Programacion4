using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.ViewModel
{
    public class LocalidadesViewModel
    {
        public List<Localidad> Localidad { get; set; }
        public string textoBusqueda { get; set; }
        public Paginador paginador { get; set; } = new Paginador();
    }
}
