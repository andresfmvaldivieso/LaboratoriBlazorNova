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
    public class RhhTbmedidaDian2280Controller : Controller
    {
        private readonly BdlaboratorioContext _context;

        public RhhTbmedidaDian2280Controller(BdlaboratorioContext context)
        {
            _context = context;
        }

        // GET: RhhTbmedidaDian2280
        public async Task<IActionResult> Index()
        {
              return _context.RhhTbmedidaDian2280s != null ? 
                          View(await _context.RhhTbmedidaDian2280s.ToListAsync()) :
                          Problem("Entity set 'BdlaboratorioContext.RhhTbmedidaDian2280s'  is null.");
        }

        // GET: RhhTbmedidaDian2280/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.RhhTbmedidaDian2280s == null)
            {
                return NotFound();
            }

            var rhhTbmedidaDian2280 = await _context.RhhTbmedidaDian2280s
                .FirstOrDefaultAsync(m => m.Concepto == id);
            if (rhhTbmedidaDian2280 == null)
            {
                return NotFound();
            }

            return View(rhhTbmedidaDian2280);
        }

        // GET: RhhTbmedidaDian2280/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RhhTbmedidaDian2280/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Concepto,Descripcion")] RhhTbmedidaDian2280 rhhTbmedidaDian2280)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rhhTbmedidaDian2280);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(rhhTbmedidaDian2280);
        }

        // GET: RhhTbmedidaDian2280/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.RhhTbmedidaDian2280s == null)
            {
                return NotFound();
            }

            var rhhTbmedidaDian2280 = await _context.RhhTbmedidaDian2280s.FindAsync(id);
            if (rhhTbmedidaDian2280 == null)
            {
                return NotFound();
            }
            return View(rhhTbmedidaDian2280);
        }

        // POST: RhhTbmedidaDian2280/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Concepto,Descripcion")] RhhTbmedidaDian2280 rhhTbmedidaDian2280)
        {
            if (id != rhhTbmedidaDian2280.Concepto)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rhhTbmedidaDian2280);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RhhTbmedidaDian2280Exists(rhhTbmedidaDian2280.Concepto))
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
            return View(rhhTbmedidaDian2280);
        }

        // GET: RhhTbmedidaDian2280/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.RhhTbmedidaDian2280s == null)
            {
                return NotFound();
            }

            var rhhTbmedidaDian2280 = await _context.RhhTbmedidaDian2280s
                .FirstOrDefaultAsync(m => m.Concepto == id);
            if (rhhTbmedidaDian2280 == null)
            {
                return NotFound();
            }

            return View(rhhTbmedidaDian2280);
        }

        // POST: RhhTbmedidaDian2280/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.RhhTbmedidaDian2280s == null)
            {
                return Problem("Entity set 'BdlaboratorioContext.RhhTbmedidaDian2280s'  is null.");
            }
            var rhhTbmedidaDian2280 = await _context.RhhTbmedidaDian2280s.FindAsync(id);
            if (rhhTbmedidaDian2280 != null)
            {
                _context.RhhTbmedidaDian2280s.Remove(rhhTbmedidaDian2280);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RhhTbmedidaDian2280Exists(string id)
        {
          return (_context.RhhTbmedidaDian2280s?.Any(e => e.Concepto == id)).GetValueOrDefault();
        }
    }
}
