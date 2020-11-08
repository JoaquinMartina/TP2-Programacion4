﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.ViewModel
{
    public class AlumnosCatedrasViewModel
    {
        public List<AlumnoCatedra> AlumnosCatedras { get; set; }
        public SelectList ListaCatedras { get; set; }
        public string textoBusqueda { get; set; }
        public int? CatedraId { get; set; }
        public Paginador paginador { get; set; } = new Paginador();
    }
}
