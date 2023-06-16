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
    public class RhhTbtippensController : Controller
    {
        private readonly BdlaboratorioContext _context;

        public RhhTbtippensController(BdlaboratorioContext context)
        {
            _context = context;
        }

        // GET: RhhTbtippens
        public async Task<IActionResult> Index()
        {
              return _context.RhhTbtippens != null ? 
                          View(await _context.RhhTbtippens.ToListAsync()) :
                          Problem("Entity set 'BdlaboratorioContext.RhhTbtippens'  is null.");
        }

        // GET: RhhTbtippens/Details/5
        public async Task<IActionResult> Details(short? id)
        {
            if (id == null || _context.RhhTbtippens == null)
            {
                return NotFound();
            }

            var rhhTbtippen = await _context.RhhTbtippens
                .FirstOrDefaultAsync(m => m.TipPen == id);
            if (rhhTbtippen == null)
            {
                return NotFound();
            }

            return View(rhhTbtippen);
        }

        // GET: RhhTbtippens/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RhhTbtippens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TipPen,DesTipPen")] RhhTbtippen rhhTbtippen)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rhhTbtippen);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(rhhTbtippen);
        }

        // GET: RhhTbtippens/Edit/5
        public async Task<IActionResult> Edit(short? id)
        {
            if (id == null || _context.RhhTbtippens == null)
            {
                return NotFound();
            }

            var rhhTbtippen = await _context.RhhTbtippens.FindAsync(id);
            if (rhhTbtippen == null)
            {
                return NotFound();
            }
            return View(rhhTbtippen);
        }

        // POST: RhhTbtippens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(short id, [Bind("TipPen,DesTipPen")] RhhTbtippen rhhTbtippen)
        {
            if (id != rhhTbtippen.TipPen)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rhhTbtippen);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RhhTbtippenExists(rhhTbtippen.TipPen))
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
            return View(rhhTbtippen);
        }

        // GET: RhhTbtippens/Delete/5
        public async Task<IActionResult> Delete(short? id)
        {
            if (id == null || _context.RhhTbtippens == null)
            {
                return NotFound();
            }

            var rhhTbtippen = await _context.RhhTbtippens
                .FirstOrDefaultAsync(m => m.TipPen == id);
            if (rhhTbtippen == null)
            {
                return NotFound();
            }

            return View(rhhTbtippen);
        }

        // POST: RhhTbtippens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(short id)
        {
            if (_context.RhhTbtippens == null)
            {
                return Problem("Entity set 'BdlaboratorioContext.RhhTbtippens'  is null.");
            }
            var rhhTbtippen = await _context.RhhTbtippens.FindAsync(id);
            if (rhhTbtippen != null)
            {
                _context.RhhTbtippens.Remove(rhhTbtippen);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RhhTbtippenExists(short id)
        {
          return (_context.RhhTbtippens?.Any(e => e.TipPen == id)).GetValueOrDefault();
        }
    }
}
