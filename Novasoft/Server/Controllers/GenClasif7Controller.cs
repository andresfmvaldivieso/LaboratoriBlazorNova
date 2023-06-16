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
    public class GenClasif7Controller : Controller
    {
        private readonly BdlaboratorioContext _context;

        public GenClasif7Controller(BdlaboratorioContext context)
        {
            _context = context;
        }

        // GET: GenClasif7
        public async Task<IActionResult> Index()
        {
              return _context.GenClasif7s != null ? 
                          View(await _context.GenClasif7s.ToListAsync()) :
                          Problem("Entity set 'BdlaboratorioContext.GenClasif7s'  is null.");
        }

        // GET: GenClasif7/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.GenClasif7s == null)
            {
                return NotFound();
            }

            var genClasif7 = await _context.GenClasif7s
                .FirstOrDefaultAsync(m => m.Codigo == id);
            if (genClasif7 == null)
            {
                return NotFound();
            }

            return View(genClasif7);
        }

        // GET: GenClasif7/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GenClasif7/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Codigo,Nombre,Estado")] GenClasif7 genClasif7)
        {
            if (ModelState.IsValid)
            {
                _context.Add(genClasif7);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(genClasif7);
        }

        // GET: GenClasif7/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.GenClasif7s == null)
            {
                return NotFound();
            }

            var genClasif7 = await _context.GenClasif7s.FindAsync(id);
            if (genClasif7 == null)
            {
                return NotFound();
            }
            return View(genClasif7);
        }

        // POST: GenClasif7/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Codigo,Nombre,Estado")] GenClasif7 genClasif7)
        {
            if (id != genClasif7.Codigo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(genClasif7);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GenClasif7Exists(genClasif7.Codigo))
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
            return View(genClasif7);
        }

        // GET: GenClasif7/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.GenClasif7s == null)
            {
                return NotFound();
            }

            var genClasif7 = await _context.GenClasif7s
                .FirstOrDefaultAsync(m => m.Codigo == id);
            if (genClasif7 == null)
            {
                return NotFound();
            }

            return View(genClasif7);
        }

        // POST: GenClasif7/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.GenClasif7s == null)
            {
                return Problem("Entity set 'BdlaboratorioContext.GenClasif7s'  is null.");
            }
            var genClasif7 = await _context.GenClasif7s.FindAsync(id);
            if (genClasif7 != null)
            {
                _context.GenClasif7s.Remove(genClasif7);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GenClasif7Exists(string id)
        {
          return (_context.GenClasif7s?.Any(e => e.Codigo == id)).GetValueOrDefault();
        }
    }
}
