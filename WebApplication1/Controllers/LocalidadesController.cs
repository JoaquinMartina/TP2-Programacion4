using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebAppMovies_MVC.Data;
using WebApplication1.Models;
using WebApplication1.ViewModel;
using Microsoft.AspNetCore.Authorization;

namespace WebApplication1.Controllers
{
    [Authorize(Roles = "SuperAdmin, Admin")]
    public class LocalidadesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LocalidadesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Localidades
        [AllowAnonymous]
        public async Task<IActionResult> Index(string textoBusqueda, int pagina=1)
        {
            var applicationDbContext = from localidad in _context.Localidades select localidad;

            //Paginado
            int RegistrosPorPagina = 3;

            var registrosMostrar = applicationDbContext
                        .Skip((pagina - 1) * RegistrosPorPagina)
                        .Take(RegistrosPorPagina);

            //Crear modelo para la vista
            LocalidadesViewModel localidadViewModel = new LocalidadesViewModel()
            {
                Localidad = await registrosMostrar.ToListAsync(),
                textoBusqueda = textoBusqueda,
            };

            localidadViewModel.paginador.PaginaActual = pagina;
            localidadViewModel.paginador.RegistrosPorPagina = RegistrosPorPagina;
            localidadViewModel.paginador.TotalRegistros = await applicationDbContext.CountAsync();

            if (!string.IsNullOrEmpty(textoBusqueda))
            {
                localidadViewModel.paginador.ValoresQueryString.Add("textoBusqueda", textoBusqueda);
            }

            return View(localidadViewModel);
        }

        // GET: Localidades/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var localidad = await _context.Localidades
                .FirstOrDefaultAsync(m => m.Id == id);
            if (localidad == null)
            {
                return NotFound();
            }

            return View(localidad);
        }

        // GET: Localidades/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Localidades/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Provincia")] Localidad localidad)
        {
            if (ModelState.IsValid)
            {
                _context.Add(localidad);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(localidad);
        }

        // GET: Localidades/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var localidad = await _context.Localidades.FindAsync(id);
            if (localidad == null)
            {
                return NotFound();
            }
            return View(localidad);
        }

        // POST: Localidades/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Provincia")] Localidad localidad)
        {
            if (id != localidad.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(localidad);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LocalidadExists(localidad.Id))
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
            return View(localidad);
        }

        // GET: Localidades/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var localidad = await _context.Localidades
                .FirstOrDefaultAsync(m => m.Id == id);
            if (localidad == null)
            {
                return NotFound();
            }

            return View(localidad);
        }

        // POST: Localidades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var localidad = await _context.Localidades.FindAsync(id);
            _context.Localidades.Remove(localidad);

            //Manejo de error de Integridad Referencial
            try
            {
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateException ex)
            {
                if (ex.InnerException.Message.Contains("REFERENCE constraint"))
                {
                    ModelState.AddModelError(string.Empty, "Error! Existen Alumnos cargados con esta Localidad");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, ex.InnerException.Message);
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.InnerException.Message);
            }

            return View(localidad);
        }

        private bool LocalidadExists(int id)
        {
            return _context.Localidades.Any(e => e.Id == id);
        }
    }
}
