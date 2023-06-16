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
    public class GenClasif5Controller : Controller
    {
        private readonly BdlaboratorioContext _context;

        public GenClasif5Controller(BdlaboratorioContext context)
        {
            _context = context;
        }

        // GET: GenClasif5
        public async Task<IActionResult> Index()
        {
              return _context.GenClasif5s != null ? 
                          View(await _context.GenClasif5s.ToListAsync()) :
                          Problem("Entity set 'BdlaboratorioContext.GenClasif5s'  is null.");
        }

        // GET: GenClasif5/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.GenClasif5s == null)
            {
                return NotFound();
            }

            var genClasif5 = await _context.GenClasif5s
                .FirstOrDefaultAsync(m => m.Codigo == id);
            if (genClasif5 == null)
            {
                return NotFound();
            }

            return View(genClasif5);
        }

        // GET: GenClasif5/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GenClasif5/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Codigo,Nombre,Estado")] GenClasif5 genClasif5)
        {
            if (ModelState.IsValid)
            {
                _context.Add(genClasif5);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(genClasif5);
        }

        // GET: GenClasif5/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.GenClasif5s == null)
            {
                return NotFound();
            }

            var genClasif5 = await _context.GenClasif5s.FindAsync(id);
            if (genClasif5 == null)
            {
                return NotFound();
            }
            return View(genClasif5);
        }

        // POST: GenClasif5/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Codigo,Nombre,Estado")] GenClasif5 genClasif5)
        {
            if (id != genClasif5.Codigo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(genClasif5);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GenClasif5Exists(genClasif5.Codigo))
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
            return View(genClasif5);
        }

        // GET: GenClasif5/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.GenClasif5s == null)
            {
                return NotFound();
            }

            var genClasif5 = await _context.GenClasif5s
                .FirstOrDefaultAsync(m => m.Codigo == id);
            if (genClasif5 == null)
            {
                return NotFound();
            }

            return View(genClasif5);
        }

        // POST: GenClasif5/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.GenClasif5s == null)
            {
                return Problem("Entity set 'BdlaboratorioContext.GenClasif5s'  is null.");
            }
            var genClasif5 = await _context.GenClasif5s.FindAsync(id);
            if (genClasif5 != null)
            {
                _context.GenClasif5s.Remove(genClasif5);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GenClasif5Exists(string id)
        {
          return (_context.GenClasif5s?.Any(e => e.Codigo == id)).GetValueOrDefault();
        }
    }
}
