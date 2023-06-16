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
    public class GenCcostosController : Controller
    {
        private readonly BdlaboratorioContext _context;

        public GenCcostosController(BdlaboratorioContext context)
        {
            _context = context;
        }

        // GET: GenCcostos
        public async Task<IActionResult> Index()
        {
              return _context.GenCcostos != null ? 
                          View(await _context.GenCcostos.ToListAsync()) :
                          Problem("Entity set 'BdlaboratorioContext.GenCcostos'  is null.");
        }

        // GET: GenCcostos/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.GenCcostos == null)
            {
                return NotFound();
            }

            var genCcosto = await _context.GenCcostos
                .FirstOrDefaultAsync(m => m.CodCco == id);
            if (genCcosto == null)
            {
                return NotFound();
            }

            return View(genCcosto);
        }

        // GET: GenCcostos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GenCcostos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CodCco,NomCco,EstCco,CodCcoExtr")] GenCcosto genCcosto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(genCcosto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(genCcosto);
        }

        // GET: GenCcostos/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.GenCcostos == null)
            {
                return NotFound();
            }

            var genCcosto = await _context.GenCcostos.FindAsync(id);
            if (genCcosto == null)
            {
                return NotFound();
            }
            return View(genCcosto);
        }

        // POST: GenCcostos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CodCco,NomCco,EstCco,CodCcoExtr")] GenCcosto genCcosto)
        {
            if (id != genCcosto.CodCco)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(genCcosto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GenCcostoExists(genCcosto.CodCco))
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
            return View(genCcosto);
        }

        // GET: GenCcostos/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.GenCcostos == null)
            {
                return NotFound();
            }

            var genCcosto = await _context.GenCcostos
                .FirstOrDefaultAsync(m => m.CodCco == id);
            if (genCcosto == null)
            {
                return NotFound();
            }

            return View(genCcosto);
        }

        // POST: GenCcostos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.GenCcostos == null)
            {
                return Problem("Entity set 'BdlaboratorioContext.GenCcostos'  is null.");
            }
            var genCcosto = await _context.GenCcostos.FindAsync(id);
            if (genCcosto != null)
            {
                _context.GenCcostos.Remove(genCcosto);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GenCcostoExists(string id)
        {
          return (_context.GenCcostos?.Any(e => e.CodCco == id)).GetValueOrDefault();
        }
    }
}
