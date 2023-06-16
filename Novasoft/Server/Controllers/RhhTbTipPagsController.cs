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
    public class RhhTbTipPagsController : Controller
    {
        private readonly BdlaboratorioContext _context;

        public RhhTbTipPagsController(BdlaboratorioContext context)
        {
            _context = context;
        }

        // GET: RhhTbTipPags
        public async Task<IActionResult> Index()
        {
              return _context.RhhTbTipPags != null ? 
                          View(await _context.RhhTbTipPags.ToListAsync()) :
                          Problem("Entity set 'BdlaboratorioContext.RhhTbTipPags'  is null.");
        }

        // GET: RhhTbTipPags/Details/5
        public async Task<IActionResult> Details(short? id)
        {
            if (id == null || _context.RhhTbTipPags == null)
            {
                return NotFound();
            }

            var rhhTbTipPag = await _context.RhhTbTipPags
                .FirstOrDefaultAsync(m => m.TipPag == id);
            if (rhhTbTipPag == null)
            {
                return NotFound();
            }

            return View(rhhTbTipPag);
        }

        // GET: RhhTbTipPags/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RhhTbTipPags/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TipPag,NomPag,ForPag,TipCta,CodNomElec")] RhhTbTipPag rhhTbTipPag)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rhhTbTipPag);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(rhhTbTipPag);
        }

        // GET: RhhTbTipPags/Edit/5
        public async Task<IActionResult> Edit(short? id)
        {
            if (id == null || _context.RhhTbTipPags == null)
            {
                return NotFound();
            }

            var rhhTbTipPag = await _context.RhhTbTipPags.FindAsync(id);
            if (rhhTbTipPag == null)
            {
                return NotFound();
            }
            return View(rhhTbTipPag);
        }

        // POST: RhhTbTipPags/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(short id, [Bind("TipPag,NomPag,ForPag,TipCta,CodNomElec")] RhhTbTipPag rhhTbTipPag)
        {
            if (id != rhhTbTipPag.TipPag)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rhhTbTipPag);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RhhTbTipPagExists(rhhTbTipPag.TipPag))
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
            return View(rhhTbTipPag);
        }

        // GET: RhhTbTipPags/Delete/5
        public async Task<IActionResult> Delete(short? id)
        {
            if (id == null || _context.RhhTbTipPags == null)
            {
                return NotFound();
            }

            var rhhTbTipPag = await _context.RhhTbTipPags
                .FirstOrDefaultAsync(m => m.TipPag == id);
            if (rhhTbTipPag == null)
            {
                return NotFound();
            }

            return View(rhhTbTipPag);
        }

        // POST: RhhTbTipPags/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(short id)
        {
            if (_context.RhhTbTipPags == null)
            {
                return Problem("Entity set 'BdlaboratorioContext.RhhTbTipPags'  is null.");
            }
            var rhhTbTipPag = await _context.RhhTbTipPags.FindAsync(id);
            if (rhhTbTipPag != null)
            {
                _context.RhhTbTipPags.Remove(rhhTbTipPag);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RhhTbTipPagExists(short id)
        {
          return (_context.RhhTbTipPags?.Any(e => e.TipPag == id)).GetValueOrDefault();
        }
    }
}
