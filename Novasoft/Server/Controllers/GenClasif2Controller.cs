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
    public class GenClasif2Controller : Controller
    {
        private readonly BdlaboratorioContext _context;

        public GenClasif2Controller(BdlaboratorioContext context)
        {
            _context = context;
        }

        // GET: GenClasif2
        public async Task<IActionResult> Index()
        {
              return _context.GenClasif2s != null ? 
                          View(await _context.GenClasif2s.ToListAsync()) :
                          Problem("Entity set 'BdlaboratorioContext.GenClasif2s'  is null.");
        }

        // GET: GenClasif2/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.GenClasif2s == null)
            {
                return NotFound();
            }

            var genClasif2 = await _context.GenClasif2s
                .FirstOrDefaultAsync(m => m.Codigo == id);
            if (genClasif2 == null)
            {
                return NotFound();
            }

            return View(genClasif2);
        }

        // GET: GenClasif2/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GenClasif2/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Codigo,Nombre,Estado")] GenClasif2 genClasif2)
        {
            if (ModelState.IsValid)
            {
                _context.Add(genClasif2);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(genClasif2);
        }

        // GET: GenClasif2/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.GenClasif2s == null)
            {
                return NotFound();
            }

            var genClasif2 = await _context.GenClasif2s.FindAsync(id);
            if (genClasif2 == null)
            {
                return NotFound();
            }
            return View(genClasif2);
        }

        // POST: GenClasif2/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Codigo,Nombre,Estado")] GenClasif2 genClasif2)
        {
            if (id != genClasif2.Codigo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(genClasif2);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GenClasif2Exists(genClasif2.Codigo))
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
            return View(genClasif2);
        }

        // GET: GenClasif2/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.GenClasif2s == null)
            {
                return NotFound();
            }

            var genClasif2 = await _context.GenClasif2s
                .FirstOrDefaultAsync(m => m.Codigo == id);
            if (genClasif2 == null)
            {
                return NotFound();
            }

            return View(genClasif2);
        }

        // POST: GenClasif2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.GenClasif2s == null)
            {
                return Problem("Entity set 'BdlaboratorioContext.GenClasif2s'  is null.");
            }
            var genClasif2 = await _context.GenClasif2s.FindAsync(id);
            if (genClasif2 != null)
            {
                _context.GenClasif2s.Remove(genClasif2);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GenClasif2Exists(string id)
        {
          return (_context.GenClasif2s?.Any(e => e.Codigo == id)).GetValueOrDefault();
        }
    }
}
