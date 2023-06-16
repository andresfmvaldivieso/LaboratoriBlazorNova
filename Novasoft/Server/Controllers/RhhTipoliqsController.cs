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
    public class RhhTipoliqsController : Controller
    {
        private readonly BdlaboratorioContext _context;

        public RhhTipoliqsController(BdlaboratorioContext context)
        {
            _context = context;
        }

        // GET: RhhTipoliqs
        public async Task<IActionResult> Index()
        {
              return _context.RhhTipoliqs != null ? 
                          View(await _context.RhhTipoliqs.ToListAsync()) :
                          Problem("Entity set 'BdlaboratorioContext.RhhTipoliqs'  is null.");
        }

        // GET: RhhTipoliqs/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.RhhTipoliqs == null)
            {
                return NotFound();
            }

            var rhhTipoliq = await _context.RhhTipoliqs
                .FirstOrDefaultAsync(m => m.CodTlq == id);
            if (rhhTipoliq == null)
            {
                return NotFound();
            }

            return View(rhhTipoliq);
        }

        // GET: RhhTipoliqs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RhhTipoliqs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CodTlq,NomTlq,DiasTlq,IndPeriodoCom,CodNomElec")] RhhTipoliq rhhTipoliq)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rhhTipoliq);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(rhhTipoliq);
        }

        // GET: RhhTipoliqs/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.RhhTipoliqs == null)
            {
                return NotFound();
            }

            var rhhTipoliq = await _context.RhhTipoliqs.FindAsync(id);
            if (rhhTipoliq == null)
            {
                return NotFound();
            }
            return View(rhhTipoliq);
        }

        // POST: RhhTipoliqs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CodTlq,NomTlq,DiasTlq,IndPeriodoCom,CodNomElec")] RhhTipoliq rhhTipoliq)
        {
            if (id != rhhTipoliq.CodTlq)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rhhTipoliq);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RhhTipoliqExists(rhhTipoliq.CodTlq))
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
            return View(rhhTipoliq);
        }

        // GET: RhhTipoliqs/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.RhhTipoliqs == null)
            {
                return NotFound();
            }

            var rhhTipoliq = await _context.RhhTipoliqs
                .FirstOrDefaultAsync(m => m.CodTlq == id);
            if (rhhTipoliq == null)
            {
                return NotFound();
            }

            return View(rhhTipoliq);
        }

        // POST: RhhTipoliqs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.RhhTipoliqs == null)
            {
                return Problem("Entity set 'BdlaboratorioContext.RhhTipoliqs'  is null.");
            }
            var rhhTipoliq = await _context.RhhTipoliqs.FindAsync(id);
            if (rhhTipoliq != null)
            {
                _context.RhhTipoliqs.Remove(rhhTipoliq);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RhhTipoliqExists(string id)
        {
          return (_context.RhhTipoliqs?.Any(e => e.CodTlq == id)).GetValueOrDefault();
        }
    }
}
