using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebAppMovies_MVC.Data;
using WebApplication1.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using WebApplication1.ViewModel;
using Microsoft.AspNetCore.Authorization;

namespace WebApplication1.Controllers
{
    [Authorize (Roles = "SuperAdmin, Admin")] //Si no estamos logueados como usuario, no podremos acceder (Nivel de controller)
                                              //Ademas de un manejo de roles de usuario (puede que este logueado pero iguanlmente no tengo acceso)
    public class AlumnosController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IHostingEnvironment _env;

        //Esto aplica injeccion de dependencias (configurado en service -> Startup)
        public AlumnosController(ApplicationDbContext context, IHostingEnvironment env)
        {
            _context = context;
            _env = env;
        }

        // GET: Alumnos
        //[Authorize] //Si no estamos logueados como usuario, no podremos acceder (Nivel de accion)
        [AllowAnonymous] //Este acceso prevalece sobre el Authorize
        public async Task<IActionResult> Index(string textoBusqueda, int? CursoId, int pagina=1)
        {
            var applicationDbContext = _context.Alumnos
                 .Include(a => a.Localidad)
                 .Include(a => a.Curso).Select(e => e);

            //Filtrado y busqueda
            if (!string.IsNullOrEmpty(textoBusqueda))
            {
                applicationDbContext = applicationDbContext.Where(e => e.Nombre.Contains(textoBusqueda));
            }
            if (CursoId.HasValue)
            {
                applicationDbContext = applicationDbContext.Where(e => e.CursoId == CursoId.Value);
            }

            //Paginado
            int RegistrosPorPagina = 4;

            var registrosMostrar = applicationDbContext
                        .Skip((pagina - 1) * RegistrosPorPagina)
                        .Take(RegistrosPorPagina);

            //Crear modelo para la vista
            AlumnosViewModel alumnosViewModel = new AlumnosViewModel()
            {
                Alumnos = await registrosMostrar.ToListAsync(),
                ListaCursos = new SelectList(_context.Cursos, "Id", "Descripcion", CursoId),
                textoBusqueda = textoBusqueda,
                CursoId = CursoId
            };

            alumnosViewModel.paginador.PaginaActual = pagina;
            alumnosViewModel.paginador.RegistrosPorPagina = RegistrosPorPagina;
            alumnosViewModel.paginador.TotalRegistros = await applicationDbContext.CountAsync();

            if (!string.IsNullOrEmpty(textoBusqueda))
            {
                alumnosViewModel.paginador.ValoresQueryString.Add("textoBusqueda", textoBusqueda);
            }

            if (CursoId.HasValue)
            {
                alumnosViewModel.paginador.ValoresQueryString.Add("CursoId", CursoId.Value.ToString());
            }

            return View(alumnosViewModel);

        }

     // GET: Alumnos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alumno = await _context.Alumnos
                .Include(a=>a.Curso)
                .Include(a => a.Localidad)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (alumno == null)
            {
                return NotFound();
            }

            return View(alumno);
        }

        // GET: Alumnos/Create
        public IActionResult Create()
        {
            ViewData["LocalidadId"] = new SelectList(_context.Localidades, "Id", "Nombre");
            ViewData["CursoId"] = new SelectList(_context.Cursos, "Id", "Descripcion");
            return View();
        }

        // POST: Alumnos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        //Debemos indicar que vamos a estar enviando un archivo (Foto Carnet)
        public async Task<IActionResult> Create([Bind("Id,Nombre,Apellido,Legajo,Edad,AñoIngreso,AñoCursado,LocalidadId,CursoId,FotoCarnet")] Alumno alumno)
        {
            if (ModelState.IsValid)
            {
                var archivos = HttpContext.Request.Form.Files;
                if(archivos != null && archivos.Count > 0)
                {
                    var archivoFoto = archivos[0];
                    var pathDestino = Path.Combine(_env.WebRootPath, "images\\alumnos");
                    if(archivoFoto.Length > 0)
                    {
                        //var archivoDestino = Guid.NewGuid().ToString().Replace("-", "");

                        var archivoDestino = Guid.NewGuid().ToString().Replace("-", "") + Path.GetExtension(archivoFoto.FileName);

                        using (var filestream = new FileStream(Path.Combine(pathDestino, archivoDestino), FileMode.Create))
                        {
                            archivoFoto.CopyTo(filestream);
                            alumno.FotoCarnet = archivoDestino;
                        }
                    }
                }

                _context.Add(alumno);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["LocalidadId"] = new SelectList(_context.Localidades, "Id", "Nombre", alumno.LocalidadId);
            ViewData["CursoId"] = new SelectList(_context.Cursos,"Id","Descripcion", alumno.CursoId);
            return View(alumno);
        }

        // GET: Alumnos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var alumno = await _context.Alumnos
                .Include(a => a.AlumnosCatedras)
                .ThenInclude(a => a.Catedra)
                .FirstOrDefaultAsync(a => a.Id ==  id);
            if (alumno == null)
            {
                return NotFound();
            }
            ViewData["LocalidadId"] = new SelectList(_context.Localidades, "Id", "Nombre", alumno.LocalidadId);
            ViewData["CursoId"] = new SelectList(_context.Cursos, "Id", "Descripcion", alumno.CursoId);
            return View(alumno);
        }

        // POST: Alumnos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Apellido,Legajo,Edad,AñoIngreso,AñoCursado,LocalidadId,CursoId,FotoCarnet")] Alumno alumno)
        {
            if (id != alumno.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var archivos = HttpContext.Request.Form.Files;
                if (archivos != null && archivos.Count > 0)
                {
                    var archivoFoto = archivos[0];
                    var pathDestino = Path.Combine(_env.WebRootPath, "images\\alumnos");
                    if (archivoFoto.Length > 0)
                    {

                        var archivoDestino = Guid.NewGuid().ToString().Replace("-", "") + Path.GetExtension(archivoFoto.FileName);

                        using (var filestream = new FileStream(Path.Combine(pathDestino, archivoDestino), FileMode.Create))
                        {
                            archivoFoto.CopyTo(filestream);

                            string viejoArchivo = Path.Combine(pathDestino, alumno.FotoCarnet);
                            if (System.IO.File.Exists(viejoArchivo))
                            {
                                System.IO.File.Delete(viejoArchivo);
                            }
                            alumno.FotoCarnet = archivoDestino;
                        }
                    }
                }

                try
                {
                    _context.Update(alumno);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlumnoExists(alumno.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }

            ViewData["LocalidadId"] = new SelectList(_context.Localidades, "Id", "Nombre", alumno.LocalidadId);
            ViewData["CursoId"] = new SelectList(_context.Cursos, "Id", "Descripcion", alumno.CursoId);
            return View(alumno);
        }

        // GET: Alumnos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alumno = await _context.Alumnos
                .Include(a => a.Curso)
                .Include(a => a.Localidad)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (alumno == null)
            {
                return NotFound();
            }

            return View(alumno);
        }

        // POST: Alumnos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var alumno = await _context.Alumnos.FindAsync(id);
            _context.Alumnos.Remove(alumno);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AlumnoExists(int id)
        {
            return _context.Alumnos.Any(e => e.Id == id);
        }
    }
}
