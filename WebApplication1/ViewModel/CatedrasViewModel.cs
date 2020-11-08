using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.ViewModel
{
    public class CatedrasViewModel
    {
        public List<Catedra> Catedra { get; set; }
        public SelectList ListaCursos { get; set; }
        public string textoBusqueda { get; set; }
        public int? CursoId { get; set; }
        public Paginador paginador { get; set; } = new Paginador();
    }
}
