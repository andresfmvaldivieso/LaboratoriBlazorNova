using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Novasoft.Server.Data;

namespace Novasoft.Server.Controllers
{
    public class GthRptEstadoesController : Controller
    {
        private readonly BdlaboratorioContext _context;

        public GthRptEstadoesController(BdlaboratorioContext context)
        {
            _context = context;
        }

        // GET: GthRptEstadoes
        public async Task<IActionResult> Index()
        {
              return _context.GthRptEstados != null ? 
                          View(await _context.GthRptEstados.ToListAsync()) :
                          Problem("Entity set 'BdlaboratorioContext.GthRptEstados'  is null.");
        }

        // GET: GthRptEstadoes/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.GthRptEstados == null)
            {
                return NotFound();
            }

            var gthRptEstado = await _context.GthRptEstados
                .FirstOrDefaultAsync(m => m.CodEst == id);
            if (gthRptEstado == null)
            {
                return NotFound();
            }

            return View(gthRptEstado);
        }

        // GET: GthRptEstadoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GthRptEstadoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CodEst,DescEst")] GthRptEstado gthRptEstado)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gthRptEstado);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(gthRptEstado);
        }

        // GET: GthRptEstadoes/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.GthRptEstados == null)
            {
                return NotFound();
            }

            var gthRptEstado = await _context.GthRptEstados.FindAsync(id);
            if (gthRptEstado == null)
            {
                return NotFound();
            }
            return View(gthRptEstado);
        }

        // POST: GthRptEstadoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CodEst,DescEst")] GthRptEstado gthRptEstado)
        {
            if (id != gthRptEstado.CodEst)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gthRptEstado);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GthRptEstadoExists(gthRptEstado.CodEst))
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
            return View(gthRptEstado);
        }

        // GET: GthRptEstadoes/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.GthRptEstados == null)
            {
                return NotFound();
            }

            var gthRptEstado = await _context.GthRptEstados
                .FirstOrDefaultAsync(m => m.CodEst == id);
            if (gthRptEstado == null)
            {
                return NotFound();
            }

            return View(gthRptEstado);
        }

        // POST: GthRptEstadoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.GthRptEstados == null)
            {
                return Problem("Entity set 'BdlaboratorioContext.GthRptEstados'  is null.");
            }
            var gthRptEstado = await _context.GthRptEstados.FindAsync(id);
            if (gthRptEstado != null)
            {
                _context.GthRptEstados.Remove(gthRptEstado);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GthRptEstadoExists(string id)
        {
          return (_context.GthRptEstados?.Any(e => e.CodEst == id)).GetValueOrDefault();
        }
    }
}
