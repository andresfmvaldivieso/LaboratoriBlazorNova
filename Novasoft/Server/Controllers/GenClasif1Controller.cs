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
    public class GenClasif1Controller : Controller
    {
        private readonly BdlaboratorioContext _context;

        public GenClasif1Controller(BdlaboratorioContext context)
        {
            _context = context;
        }

        // GET: GenClasif1
        public async Task<IActionResult> Index()
        {
              return _context.GenClasif1s != null ? 
                          View(await _context.GenClasif1s.ToListAsync()) :
                          Problem("Entity set 'BdlaboratorioContext.GenClasif1s'  is null.");
        }

        // GET: GenClasif1/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.GenClasif1s == null)
            {
                return NotFound();
            }

            var genClasif1 = await _context.GenClasif1s
                .FirstOrDefaultAsync(m => m.Codigo == id);
            if (genClasif1 == null)
            {
                return NotFound();
            }

            return View(genClasif1);
        }

        // GET: GenClasif1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GenClasif1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Codigo,Nombre,Estado")] GenClasif1 genClasif1)
        {
            if (ModelState.IsValid)
            {
                _context.Add(genClasif1);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(genClasif1);
        }

        // GET: GenClasif1/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.GenClasif1s == null)
            {
                return NotFound();
            }

            var genClasif1 = await _context.GenClasif1s.FindAsync(id);
            if (genClasif1 == null)
            {
                return NotFound();
            }
            return View(genClasif1);
        }

        // POST: GenClasif1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Codigo,Nombre,Estado")] GenClasif1 genClasif1)
        {
            if (id != genClasif1.Codigo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(genClasif1);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GenClasif1Exists(genClasif1.Codigo))
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
            return View(genClasif1);
        }

        // GET: GenClasif1/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.GenClasif1s == null)
            {
                return NotFound();
            }

            var genClasif1 = await _context.GenClasif1s
                .FirstOrDefaultAsync(m => m.Codigo == id);
            if (genClasif1 == null)
            {
                return NotFound();
            }

            return View(genClasif1);
        }

        // POST: GenClasif1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.GenClasif1s == null)
            {
                return Problem("Entity set 'BdlaboratorioContext.GenClasif1s'  is null.");
            }
            var genClasif1 = await _context.GenClasif1s.FindAsync(id);
            if (genClasif1 != null)
            {
                _context.GenClasif1s.Remove(genClasif1);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GenClasif1Exists(string id)
        {
          return (_context.GenClasif1s?.Any(e => e.Codigo == id)).GetValueOrDefault();
        }
    }
}
