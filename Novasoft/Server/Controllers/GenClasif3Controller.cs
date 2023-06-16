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
    public class GenClasif3Controller : Controller
    {
        private readonly BdlaboratorioContext _context;

        public GenClasif3Controller(BdlaboratorioContext context)
        {
            _context = context;
        }

        // GET: GenClasif3
        public async Task<IActionResult> Index()
        {
              return _context.GenClasif3s != null ? 
                          View(await _context.GenClasif3s.ToListAsync()) :
                          Problem("Entity set 'BdlaboratorioContext.GenClasif3s'  is null.");
        }

        // GET: GenClasif3/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.GenClasif3s == null)
            {
                return NotFound();
            }

            var genClasif3 = await _context.GenClasif3s
                .FirstOrDefaultAsync(m => m.Codigo == id);
            if (genClasif3 == null)
            {
                return NotFound();
            }

            return View(genClasif3);
        }

        // GET: GenClasif3/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GenClasif3/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Codigo,Nombre,Estado")] GenClasif3 genClasif3)
        {
            if (ModelState.IsValid)
            {
                _context.Add(genClasif3);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(genClasif3);
        }

        // GET: GenClasif3/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.GenClasif3s == null)
            {
                return NotFound();
            }

            var genClasif3 = await _context.GenClasif3s.FindAsync(id);
            if (genClasif3 == null)
            {
                return NotFound();
            }
            return View(genClasif3);
        }

        // POST: GenClasif3/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Codigo,Nombre,Estado")] GenClasif3 genClasif3)
        {
            if (id != genClasif3.Codigo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(genClasif3);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GenClasif3Exists(genClasif3.Codigo))
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
            return View(genClasif3);
        }

        // GET: GenClasif3/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.GenClasif3s == null)
            {
                return NotFound();
            }

            var genClasif3 = await _context.GenClasif3s
                .FirstOrDefaultAsync(m => m.Codigo == id);
            if (genClasif3 == null)
            {
                return NotFound();
            }

            return View(genClasif3);
        }

        // POST: GenClasif3/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.GenClasif3s == null)
            {
                return Problem("Entity set 'BdlaboratorioContext.GenClasif3s'  is null.");
            }
            var genClasif3 = await _context.GenClasif3s.FindAsync(id);
            if (genClasif3 != null)
            {
                _context.GenClasif3s.Remove(genClasif3);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GenClasif3Exists(string id)
        {
          return (_context.GenClasif3s?.Any(e => e.Codigo == id)).GetValueOrDefault();
        }
    }
}
