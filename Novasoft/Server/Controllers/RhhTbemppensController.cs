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
    public class RhhTbemppensController : Controller
    {
        private readonly BdlaboratorioContext _context;

        public RhhTbemppensController(BdlaboratorioContext context)
        {
            _context = context;
        }

        // GET: RhhTbemppens
        public async Task<IActionResult> Index()
        {
              return _context.RhhTbemppens != null ? 
                          View(await _context.RhhTbemppens.ToListAsync()) :
                          Problem("Entity set 'BdlaboratorioContext.RhhTbemppens'  is null.");
        }

        // GET: RhhTbemppens/Details/5
        public async Task<IActionResult> Details(short? id)
        {
            if (id == null || _context.RhhTbemppens == null)
            {
                return NotFound();
            }

            var rhhTbemppen = await _context.RhhTbemppens
                .FirstOrDefaultAsync(m => m.TipPen == id);
            if (rhhTbemppen == null)
            {
                return NotFound();
            }

            return View(rhhTbemppen);
        }

        // GET: RhhTbemppens/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RhhTbemppens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TipPen,DesTipPen")] RhhTbemppen rhhTbemppen)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rhhTbemppen);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(rhhTbemppen);
        }

        // GET: RhhTbemppens/Edit/5
        public async Task<IActionResult> Edit(short? id)
        {
            if (id == null || _context.RhhTbemppens == null)
            {
                return NotFound();
            }

            var rhhTbemppen = await _context.RhhTbemppens.FindAsync(id);
            if (rhhTbemppen == null)
            {
                return NotFound();
            }
            return View(rhhTbemppen);
        }

        // POST: RhhTbemppens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(short id, [Bind("TipPen,DesTipPen")] RhhTbemppen rhhTbemppen)
        {
            if (id != rhhTbemppen.TipPen)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rhhTbemppen);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RhhTbemppenExists(rhhTbemppen.TipPen))
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
            return View(rhhTbemppen);
        }

        // GET: RhhTbemppens/Delete/5
        public async Task<IActionResult> Delete(short? id)
        {
            if (id == null || _context.RhhTbemppens == null)
            {
                return NotFound();
            }

            var rhhTbemppen = await _context.RhhTbemppens
                .FirstOrDefaultAsync(m => m.TipPen == id);
            if (rhhTbemppen == null)
            {
                return NotFound();
            }

            return View(rhhTbemppen);
        }

        // POST: RhhTbemppens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(short id)
        {
            if (_context.RhhTbemppens == null)
            {
                return Problem("Entity set 'BdlaboratorioContext.RhhTbemppens'  is null.");
            }
            var rhhTbemppen = await _context.RhhTbemppens.FindAsync(id);
            if (rhhTbemppen != null)
            {
                _context.RhhTbemppens.Remove(rhhTbemppen);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RhhTbemppenExists(short id)
        {
          return (_context.RhhTbemppens?.Any(e => e.TipPen == id)).GetValueOrDefault();
        }
    }
}
