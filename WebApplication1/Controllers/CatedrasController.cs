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
    public class CatedrasController : Controller
    {
        private readonly ApplicationDbContext _context;

        //TODO injeccion de dependencias
        public CatedrasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Catedras
        [AllowAnonymous]
        public async Task<IActionResult> Index(string textoBusqueda, int pagina = 1)
        {

            var applicationDbContext = from catedra in _context.Catedra select catedra;

            //Paginado
            int RegistrosPorPagina = 3;

            var registrosMostrar = applicationDbContext
                        .Skip((pagina - 1) * RegistrosPorPagina)
                        .Take(RegistrosPorPagina);

            //Crear modelo para la vista
            CatedrasViewModel catedraViewModel = new CatedrasViewModel()
            {
                Catedra = await registrosMostrar.ToListAsync(),
                textoBusqueda = textoBusqueda,
            };

            catedraViewModel.paginador.PaginaActual = pagina;
            catedraViewModel.paginador.RegistrosPorPagina = RegistrosPorPagina;
            catedraViewModel.paginador.TotalRegistros = await applicationDbContext.CountAsync();

            if (!string.IsNullOrEmpty(textoBusqueda))
            {
                catedraViewModel.paginador.ValoresQueryString.Add("textoBusqueda", textoBusqueda);
            }

            if (!string.IsNullOrEmpty(textoBusqueda))
            {
                applicationDbContext = applicationDbContext.Where(e => e.Descripcion.Contains(textoBusqueda));
            }

            return View(catedraViewModel);
        }

        // GET: Catedras/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var catedra = await _context.Catedra
                .FirstOrDefaultAsync(m => m.Id == id);
            if (catedra == null)
            {
                return NotFound();
            }

            return View(catedra);
        }

        // GET: Catedras/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Catedras/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Descripcion")] Catedra catedra)
        {
            if (ModelState.IsValid)
            {
                _context.Add(catedra);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(catedra);
        }

        // GET: Catedras/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var catedra = await _context.Catedra.FindAsync(id);
            if (catedra == null)
            {
                return NotFound();
            }
            return View(catedra);
        }

        // POST: Catedras/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Descripcion")] Catedra catedra)
        {
            if (id != catedra.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(catedra);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CatedraExists(catedra.Id))
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
            return View(catedra);
        }

        // GET: Catedras/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var catedra = await _context.Catedra
                .FirstOrDefaultAsync(m => m.Id == id);
            if (catedra == null)
            {
                return NotFound();
            }

            return View(catedra);
        }

        // POST: Catedras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var catedra = await _context.Catedra.FindAsync(id);
            _context.Catedra.Remove(catedra);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CatedraExists(int id)
        {
            return _context.Catedra.Any(e => e.Id == id);
        }
    }
}
