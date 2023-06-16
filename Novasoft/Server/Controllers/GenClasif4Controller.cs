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
    public class GenClasif4Controller : Controller
    {
        private readonly BdlaboratorioContext _context;

        public GenClasif4Controller(BdlaboratorioContext context)
        {
            _context = context;
        }

        // GET: GenClasif4
        public async Task<IActionResult> Index()
        {
              return _context.GenClasif4s != null ? 
                          View(await _context.GenClasif4s.ToListAsync()) :
                          Problem("Entity set 'BdlaboratorioContext.GenClasif4s'  is null.");
        }

        // GET: GenClasif4/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.GenClasif4s == null)
            {
                return NotFound();
            }

            var genClasif4 = await _context.GenClasif4s
                .FirstOrDefaultAsync(m => m.Codigo == id);
            if (genClasif4 == null)
            {
                return NotFound();
            }

            return View(genClasif4);
        }

        // GET: GenClasif4/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GenClasif4/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Codigo,Nombre,Estado")] GenClasif4 genClasif4)
        {
            if (ModelState.IsValid)
            {
                _context.Add(genClasif4);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(genClasif4);
        }

        // GET: GenClasif4/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.GenClasif4s == null)
            {
                return NotFound();
            }

            var genClasif4 = await _context.GenClasif4s.FindAsync(id);
            if (genClasif4 == null)
            {
                return NotFound();
            }
            return View(genClasif4);
        }

        // POST: GenClasif4/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Codigo,Nombre,Estado")] GenClasif4 genClasif4)
        {
            if (id != genClasif4.Codigo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(genClasif4);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GenClasif4Exists(genClasif4.Codigo))
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
            return View(genClasif4);
        }

        // GET: GenClasif4/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.GenClasif4s == null)
            {
                return NotFound();
            }

            var genClasif4 = await _context.GenClasif4s
                .FirstOrDefaultAsync(m => m.Codigo == id);
            if (genClasif4 == null)
            {
                return NotFound();
            }

            return View(genClasif4);
        }

        // POST: GenClasif4/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.GenClasif4s == null)
            {
                return Problem("Entity set 'BdlaboratorioContext.GenClasif4s'  is null.");
            }
            var genClasif4 = await _context.GenClasif4s.FindAsync(id);
            if (genClasif4 != null)
            {
                _context.GenClasif4s.Remove(genClasif4);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GenClasif4Exists(string id)
        {
          return (_context.GenClasif4s?.Any(e => e.Codigo == id)).GetValueOrDefault();
        }
    }
}
