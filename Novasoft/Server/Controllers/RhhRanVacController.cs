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
    public class RhhRanVacController : Controller
    {
        private readonly BdlaboratorioContext _context;

        public RhhRanVacController(BdlaboratorioContext context)
        {
            _context = context;
        }

        // GET: RhhRanVac
        public async Task<IActionResult> Index()
        {
              return _context.RhhRanVacs != null ? 
                          View(await _context.RhhRanVacs.ToListAsync()) :
                          Problem("Entity set 'BdlaboratorioContext.RhhRanVacs'  is null.");
        }

        // GET: RhhRanVac/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.RhhRanVacs == null)
            {
                return NotFound();
            }

            var rhhRanVac = await _context.RhhRanVacs
                .FirstOrDefaultAsync(m => m.CodRanVac == id);
            if (rhhRanVac == null)
            {
                return NotFound();
            }

            return View(rhhRanVac);
        }

        // GET: RhhRanVac/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RhhRanVac/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CodRanVac,DesRanVac")] RhhRanVac rhhRanVac)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rhhRanVac);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(rhhRanVac);
        }

        // GET: RhhRanVac/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.RhhRanVacs == null)
            {
                return NotFound();
            }

            var rhhRanVac = await _context.RhhRanVacs.FindAsync(id);
            if (rhhRanVac == null)
            {
                return NotFound();
            }
            return View(rhhRanVac);
        }

        // POST: RhhRanVac/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CodRanVac,DesRanVac")] RhhRanVac rhhRanVac)
        {
            if (id != rhhRanVac.CodRanVac)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rhhRanVac);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RhhRanVacExists(rhhRanVac.CodRanVac))
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
            return View(rhhRanVac);
        }

        // GET: RhhRanVac/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.RhhRanVacs == null)
            {
                return NotFound();
            }

            var rhhRanVac = await _context.RhhRanVacs
                .FirstOrDefaultAsync(m => m.CodRanVac == id);
            if (rhhRanVac == null)
            {
                return NotFound();
            }

            return View(rhhRanVac);
        }

        // POST: RhhRanVac/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.RhhRanVacs == null)
            {
                return Problem("Entity set 'BdlaboratorioContext.RhhRanVacs'  is null.");
            }
            var rhhRanVac = await _context.RhhRanVacs.FindAsync(id);
            if (rhhRanVac != null)
            {
                _context.RhhRanVacs.Remove(rhhRanVac);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RhhRanVacExists(string id)
        {
          return (_context.RhhRanVacs?.Any(e => e.CodRanVac == id)).GetValueOrDefault();
        }
    }
}
