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
    public class RhhTbsindicalizdoesController : Controller
    {
        private readonly BdlaboratorioContext _context;

        public RhhTbsindicalizdoesController(BdlaboratorioContext context)
        {
            _context = context;
        }

        // GET: RhhTbsindicalizdoes
        public async Task<IActionResult> Index()
        {
              return _context.RhhTbsindicalizdos != null ? 
                          View(await _context.RhhTbsindicalizdos.ToListAsync()) :
                          Problem("Entity set 'BdlaboratorioContext.RhhTbsindicalizdos'  is null.");
        }

        // GET: RhhTbsindicalizdoes/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.RhhTbsindicalizdos == null)
            {
                return NotFound();
            }

            var rhhTbsindicalizdo = await _context.RhhTbsindicalizdos
                .FirstOrDefaultAsync(m => m.TipSindclzdo == id);
            if (rhhTbsindicalizdo == null)
            {
                return NotFound();
            }

            return View(rhhTbsindicalizdo);
        }

        // GET: RhhTbsindicalizdoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RhhTbsindicalizdoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TipSindclzdo,Descripcion")] RhhTbsindicalizdo rhhTbsindicalizdo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rhhTbsindicalizdo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(rhhTbsindicalizdo);
        }

        // GET: RhhTbsindicalizdoes/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.RhhTbsindicalizdos == null)
            {
                return NotFound();
            }

            var rhhTbsindicalizdo = await _context.RhhTbsindicalizdos.FindAsync(id);
            if (rhhTbsindicalizdo == null)
            {
                return NotFound();
            }
            return View(rhhTbsindicalizdo);
        }

        // POST: RhhTbsindicalizdoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("TipSindclzdo,Descripcion")] RhhTbsindicalizdo rhhTbsindicalizdo)
        {
            if (id != rhhTbsindicalizdo.TipSindclzdo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rhhTbsindicalizdo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RhhTbsindicalizdoExists(rhhTbsindicalizdo.TipSindclzdo))
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
            return View(rhhTbsindicalizdo);
        }

        // GET: RhhTbsindicalizdoes/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.RhhTbsindicalizdos == null)
            {
                return NotFound();
            }

            var rhhTbsindicalizdo = await _context.RhhTbsindicalizdos
                .FirstOrDefaultAsync(m => m.TipSindclzdo == id);
            if (rhhTbsindicalizdo == null)
            {
                return NotFound();
            }

            return View(rhhTbsindicalizdo);
        }

        // POST: RhhTbsindicalizdoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.RhhTbsindicalizdos == null)
            {
                return Problem("Entity set 'BdlaboratorioContext.RhhTbsindicalizdos'  is null.");
            }
            var rhhTbsindicalizdo = await _context.RhhTbsindicalizdos.FindAsync(id);
            if (rhhTbsindicalizdo != null)
            {
                _context.RhhTbsindicalizdos.Remove(rhhTbsindicalizdo);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RhhTbsindicalizdoExists(string id)
        {
          return (_context.RhhTbsindicalizdos?.Any(e => e.TipSindclzdo == id)).GetValueOrDefault();
        }
    }
}
