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
    public class RhhTbSubTipCotizasController : Controller
    {
        private readonly BdlaboratorioContext _context;

        public RhhTbSubTipCotizasController(BdlaboratorioContext context)
        {
            _context = context;
        }

        // GET: RhhTbSubTipCotizas
        public async Task<IActionResult> Index()
        {
              return _context.RhhTbSubTipCotizas != null ? 
                          View(await _context.RhhTbSubTipCotizas.ToListAsync()) :
                          Problem("Entity set 'BdlaboratorioContext.RhhTbSubTipCotizas'  is null.");
        }

        // GET: RhhTbSubTipCotizas/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.RhhTbSubTipCotizas == null)
            {
                return NotFound();
            }

            var rhhTbSubTipCotiza = await _context.RhhTbSubTipCotizas
                .FirstOrDefaultAsync(m => m.SubTipCot == id);
            if (rhhTbSubTipCotiza == null)
            {
                return NotFound();
            }

            return View(rhhTbSubTipCotiza);
        }

        // GET: RhhTbSubTipCotizas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RhhTbSubTipCotizas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SubTipCot,DesSubTip,CodPlasub,CodDian")] RhhTbSubTipCotiza rhhTbSubTipCotiza)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rhhTbSubTipCotiza);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(rhhTbSubTipCotiza);
        }

        // GET: RhhTbSubTipCotizas/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.RhhTbSubTipCotizas == null)
            {
                return NotFound();
            }

            var rhhTbSubTipCotiza = await _context.RhhTbSubTipCotizas.FindAsync(id);
            if (rhhTbSubTipCotiza == null)
            {
                return NotFound();
            }
            return View(rhhTbSubTipCotiza);
        }

        // POST: RhhTbSubTipCotizas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("SubTipCot,DesSubTip,CodPlasub,CodDian")] RhhTbSubTipCotiza rhhTbSubTipCotiza)
        {
            if (id != rhhTbSubTipCotiza.SubTipCot)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rhhTbSubTipCotiza);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RhhTbSubTipCotizaExists(rhhTbSubTipCotiza.SubTipCot))
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
            return View(rhhTbSubTipCotiza);
        }

        // GET: RhhTbSubTipCotizas/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.RhhTbSubTipCotizas == null)
            {
                return NotFound();
            }

            var rhhTbSubTipCotiza = await _context.RhhTbSubTipCotizas
                .FirstOrDefaultAsync(m => m.SubTipCot == id);
            if (rhhTbSubTipCotiza == null)
            {
                return NotFound();
            }

            return View(rhhTbSubTipCotiza);
        }

        // POST: RhhTbSubTipCotizas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.RhhTbSubTipCotizas == null)
            {
                return Problem("Entity set 'BdlaboratorioContext.RhhTbSubTipCotizas'  is null.");
            }
            var rhhTbSubTipCotiza = await _context.RhhTbSubTipCotizas.FindAsync(id);
            if (rhhTbSubTipCotiza != null)
            {
                _context.RhhTbSubTipCotizas.Remove(rhhTbSubTipCotiza);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RhhTbSubTipCotizaExists(string id)
        {
          return (_context.RhhTbSubTipCotizas?.Any(e => e.SubTipCot == id)).GetValueOrDefault();
        }
    }
}
