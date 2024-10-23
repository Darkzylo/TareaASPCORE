using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TareaCursoCore.Data;
using TareaCursoCore.Models;

namespace TareaCursoCore.Controllers
{
    public class SolicitudBeneficiosController : Controller
    {
        private readonly BienestarContext _context;

        public SolicitudBeneficiosController(BienestarContext context)
        {
            _context = context;
        }

        // GET: SolicitudBeneficios
        public async Task<IActionResult> Index()
        {
            return View(await _context.SolicitudBeneficios.ToListAsync());
        }

        // GET: SolicitudBeneficios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var solicitudBeneficio = await _context.SolicitudBeneficios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (solicitudBeneficio == null)
            {
                return NotFound();
            }

            return View(solicitudBeneficio);
        }

        // GET: SolicitudBeneficios/Create
        public IActionResult Create()
        {
            var afiliados = new SelectList(_context.Afiliados, "Id", "Nombre");
            ViewData["AfiliadoId"] = afiliados;
            return View();
        }

        // POST: SolicitudBeneficios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AfiliadoId,Monto,TipoBeneficio")] SolicitudBeneficio solicitudBeneficio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(solicitudBeneficio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(solicitudBeneficio);
        }

        // GET: SolicitudBeneficios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var solicitudBeneficio = await _context.SolicitudBeneficios.FindAsync(id);
            if (solicitudBeneficio == null)
            {
                return NotFound();
            }
            return View(solicitudBeneficio);
        }

        // POST: SolicitudBeneficios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Monto,TipoBeneficio")] SolicitudBeneficio solicitudBeneficio)
        {
            if (id != solicitudBeneficio.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(solicitudBeneficio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SolicitudBeneficioExists(solicitudBeneficio.Id))
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
            return View(solicitudBeneficio);
        }

        // GET: SolicitudBeneficios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var solicitudBeneficio = await _context.SolicitudBeneficios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (solicitudBeneficio == null)
            {
                return NotFound();
            }

            return View(solicitudBeneficio);
        }

        // POST: SolicitudBeneficios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var solicitudBeneficio = await _context.SolicitudBeneficios.FindAsync(id);
            if (solicitudBeneficio != null)
            {
                _context.SolicitudBeneficios.Remove(solicitudBeneficio);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SolicitudBeneficioExists(int id)
        {
            return _context.SolicitudBeneficios.Any(e => e.Id == id);
        }
    }
}
