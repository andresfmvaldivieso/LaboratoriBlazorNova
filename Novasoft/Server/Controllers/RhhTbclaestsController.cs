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
    public class RhhTbclaestsController : Controller
    {
        private readonly BdlaboratorioContext _context;

        public RhhTbclaestsController(BdlaboratorioContext context)
        {
            _context = context;
        }

        // GET: RhhTbclaests
        public async Task<IActionResult> Index()
        {
              return _context.RhhTbclaests != null ? 
                          View(await _context.RhhTbclaests.ToListAsync()) :
                          Problem("Entity set 'BdlaboratorioContext.RhhTbclaests'  is null.");
        }

        // GET: RhhTbclaests/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.RhhTbclaests == null)
            {
                return NotFound();
            }

            var rhhTbclaest = await _context.RhhTbclaests
                .FirstOrDefaultAsync(m => m.TipEst == id);
            if (rhhTbclaest == null)
            {
                return NotFound();
            }

            return View(rhhTbclaest);
        }

        // GET: RhhTbclaests/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RhhTbclaests/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TipEst,DesEst,IndCurso,OrdEst,NivEstHom,CodDian,TipEstExtr")] RhhTbclaest rhhTbclaest)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rhhTbclaest);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(rhhTbclaest);
        }

        // GET: RhhTbclaests/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.RhhTbclaests == null)
            {
                return NotFound();
            }

            var rhhTbclaest = await _context.RhhTbclaests.FindAsync(id);
            if (rhhTbclaest == null)
            {
                return NotFound();
            }
            return View(rhhTbclaest);
        }

        // POST: RhhTbclaests/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("TipEst,DesEst,IndCurso,OrdEst,NivEstHom,CodDian,TipEstExtr")] RhhTbclaest rhhTbclaest)
        {
            if (id != rhhTbclaest.TipEst)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rhhTbclaest);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RhhTbclaestExists(rhhTbclaest.TipEst))
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
            return View(rhhTbclaest);
        }

        // GET: RhhTbclaests/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.RhhTbclaests == null)
            {
                return NotFound();
            }

            var rhhTbclaest = await _context.RhhTbclaests
                .FirstOrDefaultAsync(m => m.TipEst == id);
            if (rhhTbclaest == null)
            {
                return NotFound();
            }

            return View(rhhTbclaest);
        }

        // POST: RhhTbclaests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.RhhTbclaests == null)
            {
                return Problem("Entity set 'BdlaboratorioContext.RhhTbclaests'  is null.");
            }
            var rhhTbclaest = await _context.RhhTbclaests.FindAsync(id);
            if (rhhTbclaest != null)
            {
                _context.RhhTbclaests.Remove(rhhTbclaest);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RhhTbclaestExists(string id)
        {
          return (_context.RhhTbclaests?.Any(e => e.TipEst == id)).GetValueOrDefault();
        }
    }
}
