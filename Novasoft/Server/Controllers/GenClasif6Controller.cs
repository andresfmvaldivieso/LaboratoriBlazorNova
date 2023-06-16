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
    public class GenClasif6Controller : Controller
    {
        private readonly BdlaboratorioContext _context;

        public GenClasif6Controller(BdlaboratorioContext context)
        {
            _context = context;
        }

        // GET: GenClasif6
        public async Task<IActionResult> Index()
        {
              return _context.GenClasif6s != null ? 
                          View(await _context.GenClasif6s.ToListAsync()) :
                          Problem("Entity set 'BdlaboratorioContext.GenClasif6s'  is null.");
        }

        // GET: GenClasif6/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.GenClasif6s == null)
            {
                return NotFound();
            }

            var genClasif6 = await _context.GenClasif6s
                .FirstOrDefaultAsync(m => m.Codigo == id);
            if (genClasif6 == null)
            {
                return NotFound();
            }

            return View(genClasif6);
        }

        // GET: GenClasif6/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GenClasif6/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Codigo,Nombre,Estado")] GenClasif6 genClasif6)
        {
            if (ModelState.IsValid)
            {
                _context.Add(genClasif6);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(genClasif6);
        }

        // GET: GenClasif6/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.GenClasif6s == null)
            {
                return NotFound();
            }

            var genClasif6 = await _context.GenClasif6s.FindAsync(id);
            if (genClasif6 == null)
            {
                return NotFound();
            }
            return View(genClasif6);
        }

        // POST: GenClasif6/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Codigo,Nombre,Estado")] GenClasif6 genClasif6)
        {
            if (id != genClasif6.Codigo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(genClasif6);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GenClasif6Exists(genClasif6.Codigo))
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
            return View(genClasif6);
        }

        // GET: GenClasif6/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.GenClasif6s == null)
            {
                return NotFound();
            }

            var genClasif6 = await _context.GenClasif6s
                .FirstOrDefaultAsync(m => m.Codigo == id);
            if (genClasif6 == null)
            {
                return NotFound();
            }

            return View(genClasif6);
        }

        // POST: GenClasif6/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.GenClasif6s == null)
            {
                return Problem("Entity set 'BdlaboratorioContext.GenClasif6s'  is null.");
            }
            var genClasif6 = await _context.GenClasif6s.FindAsync(id);
            if (genClasif6 != null)
            {
                _context.GenClasif6s.Remove(genClasif6);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GenClasif6Exists(string id)
        {
          return (_context.GenClasif6s?.Any(e => e.Codigo == id)).GetValueOrDefault();
        }
    }
}
