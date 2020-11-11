using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using WebApplication1.Models;
using WebApplication1.ViewModel;
using WebAppMovies_MVC.Data;

namespace WebApplication1.Controllers
{
    [Authorize(Roles = "SuperAdmin, Admin")]
    public class AlumnoCatedrasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AlumnoCatedrasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: AlumnoCatedras
        [AllowAnonymous]
        public async Task<ActionResult> Index(string textoBusqueda, int pagina = 1)
        {
            var applicationDbContext = from alumnoCatedra in _context.AlumnosCatedras
                                       .Include(e => e.Alumno)
                                       .Include(e => e.Catedra) select alumnoCatedra;
            
            //Paginado
            int RegistrosPorPagina = 5;

            var registrosMostrar = applicationDbContext
                        .Skip((pagina - 1) * RegistrosPorPagina)
                        .Take(RegistrosPorPagina);

            //Crear modelo para la vista
            AlumnosCatedrasViewModel alumnosCatedrasViewModel = new AlumnosCatedrasViewModel()
            {
                AlumnosCatedras = await registrosMostrar.ToListAsync(),
                textoBusqueda = textoBusqueda,
            };

            alumnosCatedrasViewModel.paginador.PaginaActual = pagina;
            alumnosCatedrasViewModel.paginador.RegistrosPorPagina = RegistrosPorPagina;
            alumnosCatedrasViewModel.paginador.TotalRegistros = await applicationDbContext.CountAsync();

            if (!string.IsNullOrEmpty(textoBusqueda))
            {
                alumnosCatedrasViewModel.paginador.ValoresQueryString.Add("textoBusqueda", textoBusqueda);
            }

            return View(alumnosCatedrasViewModel);
        }

        // GET: AlumnoCatedras/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alumnoCatedra = await _context.AlumnosCatedras
                .Include(e => e.Alumno)
                .Include(e => e.Catedra)
                .FirstOrDefaultAsync(m => m.AlumnoId == id);
            if (alumnoCatedra == null)
            {
                return NotFound();
            }

            return View(alumnoCatedra);
        }

        // GET: AlumnoCatedras/Create
        public ActionResult Create()
        {
            ViewData["AlumnoId"] = new SelectList(_context.Alumnos, "Id", "Apellido" );
            ViewData["CatedraId"] = new SelectList(_context.Catedra, "Id", "Descripcion");
            return View();
        }

        // POST: AlumnoCatedras/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind("AlumnoId,CatedraId,Cuatrimestre,FechaInscripcion")] AlumnoCatedra alumnoCatedra)
        {
            if (ModelState.IsValid)
            {
                _context.Add(alumnoCatedra);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AlumnoId"] = new SelectList(_context.Alumnos, "Id", "Nombre", alumnoCatedra.AlumnoId);
            ViewData["CatedraId"] = new SelectList(_context.Catedra, "Id", "Descripcion", alumnoCatedra.CatedraId);
            return View(alumnoCatedra);

        }

        // GET: AlumnoCatedras/Edit/5
        public async Task<ActionResult> Edit(int? idAlumno, int? idCatedra)
        {
            if (idAlumno == null || idCatedra == null)
            {
                return NotFound();
            }

            var alumnoCatedra = await _context.AlumnosCatedras.FindAsync(idAlumno, idCatedra);
            if (alumnoCatedra == null)
            {
                return NotFound();
            }
            ViewData["AlumnoId"] = new SelectList(_context.Alumnos, "Id", "Apellido", alumnoCatedra.AlumnoId);
            ViewData["CatedraId"] = new SelectList(_context.Catedra, "Id", "Descripcion", alumnoCatedra.CatedraId);
            return View(alumnoCatedra);
        }

        // POST: AlumnoCatedras/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind("AlumnoId,CatedraId,Cuatrimestre,FechaInscripcion")] AlumnoCatedra alumnoCatedra)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(alumnoCatedra);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlumnoCatedraExists(alumnoCatedra.AlumnoId))
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
            ViewData["AlumnoId"] = new SelectList(_context.Alumnos, "Id", "Nombre", alumnoCatedra.AlumnoId);
            ViewData["CatedraId"] = new SelectList(_context.Catedra, "Id", "Descripcion", alumnoCatedra.CatedraId);
            return View(alumnoCatedra);
        }

        // GET: AlumnoCatedras/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alumnoCatedra = await _context.AlumnosCatedras
                .Include(e => e.Alumno)
                .Include(e => e.Catedra)
                .FirstOrDefaultAsync(m => m.AlumnoId == id);
            if (alumnoCatedra == null)
            {
                return NotFound();
            }

            return View(alumnoCatedra);
        }

        // POST: AlumnoCatedras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var estudianteMateria = await _context.AlumnosCatedras.FindAsync(id);
            _context.AlumnosCatedras.Remove(estudianteMateria);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AlumnoCatedraExists(int id)
        {
            return _context.AlumnosCatedras.Any(e => e.AlumnoId == id);
        }
    }
}