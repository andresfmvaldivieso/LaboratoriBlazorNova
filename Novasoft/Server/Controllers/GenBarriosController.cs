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
    public class GenBarriosController : Controller
    {
        private readonly BdlaboratorioContext _context;

        public GenBarriosController(BdlaboratorioContext context)
        {
            _context = context;
        }

        // GET: GenBarrios
        public async Task<IActionResult> Index()
        {
              return _context.GenBarrios != null ? 
                          View(await _context.GenBarrios.ToListAsync()) :
                          Problem("Entity set 'BdlaboratorioContext.GenBarrios'  is null.");
        }

        // GET: GenBarrios/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.GenBarrios == null)
            {
                return NotFound();
            }

            var genBarrio = await _context.GenBarrios
                .FirstOrDefaultAsync(m => m.CodPai == id);
            if (genBarrio == null)
            {
                return NotFound();
            }

            return View(genBarrio);
        }

        // GET: GenBarrios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GenBarrios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CodPai,CodDep,CodCiu,CodLocalidad,CodBarrio,NombreBarrio,CodPostal,IndActExtr,CodBarrioExtr,CodCiuExtr,CodDepExtr,CodPaiExtr")] GenBarrio genBarrio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(genBarrio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(genBarrio);
        }

        // GET: GenBarrios/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.GenBarrios == null)
            {
                return NotFound();
            }

            var genBarrio = await _context.GenBarrios.FindAsync(id);
            if (genBarrio == null)
            {
                return NotFound();
            }
            return View(genBarrio);
        }

        // POST: GenBarrios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CodPai,CodDep,CodCiu,CodLocalidad,CodBarrio,NombreBarrio,CodPostal,IndActExtr,CodBarrioExtr,CodCiuExtr,CodDepExtr,CodPaiExtr")] GenBarrio genBarrio)
        {
            if (id != genBarrio.CodPai)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(genBarrio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GenBarrioExists(genBarrio.CodPai))
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
            return View(genBarrio);
        }

        // GET: GenBarrios/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.GenBarrios == null)
            {
                return NotFound();
            }

            var genBarrio = await _context.GenBarrios
                .FirstOrDefaultAsync(m => m.CodPai == id);
            if (genBarrio == null)
            {
                return NotFound();
            }

            return View(genBarrio);
        }

        // POST: GenBarrios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.GenBarrios == null)
            {
                return Problem("Entity set 'BdlaboratorioContext.GenBarrios'  is null.");
            }
            var genBarrio = await _context.GenBarrios.FindAsync(id);
            if (genBarrio != null)
            {
                _context.GenBarrios.Remove(genBarrio);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GenBarrioExists(string id)
        {
          return (_context.GenBarrios?.Any(e => e.CodPai == id)).GetValueOrDefault();
        }
    }
}
