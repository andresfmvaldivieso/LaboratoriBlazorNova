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
    public class RhhTbestlabsController : Controller
    {
        private readonly BdlaboratorioContext _context;

        public RhhTbestlabsController(BdlaboratorioContext context)
        {
            _context = context;
        }

        // GET: RhhTbestlabs
        public async Task<IActionResult> Index()
        {
              return _context.RhhTbestlabs != null ? 
                          View(await _context.RhhTbestlabs.ToListAsync()) :
                          Problem("Entity set 'BdlaboratorioContext.RhhTbestlabs'  is null.");
        }

        // GET: RhhTbestlabs/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.RhhTbestlabs == null)
            {
                return NotFound();
            }

            var rhhTbestlab = await _context.RhhTbestlabs
                .FirstOrDefaultAsync(m => m.EstLab == id);
            if (rhhTbestlab == null)
            {
                return NotFound();
            }

            return View(rhhTbestlab);
        }

        // GET: RhhTbestlabs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RhhTbestlabs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EstLab,NomEst,IndLiq")] RhhTbestlab rhhTbestlab)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rhhTbestlab);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(rhhTbestlab);
        }

        // GET: RhhTbestlabs/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.RhhTbestlabs == null)
            {
                return NotFound();
            }

            var rhhTbestlab = await _context.RhhTbestlabs.FindAsync(id);
            if (rhhTbestlab == null)
            {
                return NotFound();
            }
            return View(rhhTbestlab);
        }

        // POST: RhhTbestlabs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("EstLab,NomEst,IndLiq")] RhhTbestlab rhhTbestlab)
        {
            if (id != rhhTbestlab.EstLab)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rhhTbestlab);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RhhTbestlabExists(rhhTbestlab.EstLab))
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
            return View(rhhTbestlab);
        }

        // GET: RhhTbestlabs/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.RhhTbestlabs == null)
            {
                return NotFound();
            }

            var rhhTbestlab = await _context.RhhTbestlabs
                .FirstOrDefaultAsync(m => m.EstLab == id);
            if (rhhTbestlab == null)
            {
                return NotFound();
            }

            return View(rhhTbestlab);
        }

        // POST: RhhTbestlabs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.RhhTbestlabs == null)
            {
                return Problem("Entity set 'BdlaboratorioContext.RhhTbestlabs'  is null.");
            }
            var rhhTbestlab = await _context.RhhTbestlabs.FindAsync(id);
            if (rhhTbestlab != null)
            {
                _context.RhhTbestlabs.Remove(rhhTbestlab);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RhhTbestlabExists(string id)
        {
          return (_context.RhhTbestlabs?.Any(e => e.EstLab == id)).GetValueOrDefault();
        }
    }
}
