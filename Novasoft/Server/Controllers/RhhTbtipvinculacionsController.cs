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
    public class RhhTbtipvinculacionsController : Controller
    {
        private readonly BdlaboratorioContext _context;

        public RhhTbtipvinculacionsController(BdlaboratorioContext context)
        {
            _context = context;
        }

        // GET: RhhTbtipvinculacions
        public async Task<IActionResult> Index()
        {
              return _context.RhhTbtipvinculacions != null ? 
                          View(await _context.RhhTbtipvinculacions.ToListAsync()) :
                          Problem("Entity set 'BdlaboratorioContext.RhhTbtipvinculacions'  is null.");
        }

        // GET: RhhTbtipvinculacions/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.RhhTbtipvinculacions == null)
            {
                return NotFound();
            }

            var rhhTbtipvinculacion = await _context.RhhTbtipvinculacions
                .FirstOrDefaultAsync(m => m.Tipo == id);
            if (rhhTbtipvinculacion == null)
            {
                return NotFound();
            }

            return View(rhhTbtipvinculacion);
        }

        // GET: RhhTbtipvinculacions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RhhTbtipvinculacions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Tipo,Nombre,CodDian")] RhhTbtipvinculacion rhhTbtipvinculacion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rhhTbtipvinculacion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(rhhTbtipvinculacion);
        }

        // GET: RhhTbtipvinculacions/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.RhhTbtipvinculacions == null)
            {
                return NotFound();
            }

            var rhhTbtipvinculacion = await _context.RhhTbtipvinculacions.FindAsync(id);
            if (rhhTbtipvinculacion == null)
            {
                return NotFound();
            }
            return View(rhhTbtipvinculacion);
        }

        // POST: RhhTbtipvinculacions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Tipo,Nombre,CodDian")] RhhTbtipvinculacion rhhTbtipvinculacion)
        {
            if (id != rhhTbtipvinculacion.Tipo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rhhTbtipvinculacion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RhhTbtipvinculacionExists(rhhTbtipvinculacion.Tipo))
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
            return View(rhhTbtipvinculacion);
        }

        // GET: RhhTbtipvinculacions/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.RhhTbtipvinculacions == null)
            {
                return NotFound();
            }

            var rhhTbtipvinculacion = await _context.RhhTbtipvinculacions
                .FirstOrDefaultAsync(m => m.Tipo == id);
            if (rhhTbtipvinculacion == null)
            {
                return NotFound();
            }

            return View(rhhTbtipvinculacion);
        }

        // POST: RhhTbtipvinculacions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.RhhTbtipvinculacions == null)
            {
                return Problem("Entity set 'BdlaboratorioContext.RhhTbtipvinculacions'  is null.");
            }
            var rhhTbtipvinculacion = await _context.RhhTbtipvinculacions.FindAsync(id);
            if (rhhTbtipvinculacion != null)
            {
                _context.RhhTbtipvinculacions.Remove(rhhTbtipvinculacion);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RhhTbtipvinculacionExists(string id)
        {
          return (_context.RhhTbtipvinculacions?.Any(e => e.Tipo == id)).GetValueOrDefault();
        }
    }
}
