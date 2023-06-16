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
    public class GenGrupoetnicosController : Controller
    {
        private readonly BdlaboratorioContext _context;

        public GenGrupoetnicosController(BdlaboratorioContext context)
        {
            _context = context;
        }

        // GET: GenGrupoetnicos
        public async Task<IActionResult> Index()
        {
              return _context.GenGrupoetnicos != null ? 
                          View(await _context.GenGrupoetnicos.ToListAsync()) :
                          Problem("Entity set 'BdlaboratorioContext.GenGrupoetnicos'  is null.");
        }

        // GET: GenGrupoetnicos/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.GenGrupoetnicos == null)
            {
                return NotFound();
            }

            var genGrupoetnico = await _context.GenGrupoetnicos
                .FirstOrDefaultAsync(m => m.CodGrupo == id);
            if (genGrupoetnico == null)
            {
                return NotFound();
            }

            return View(genGrupoetnico);
        }

        // GET: GenGrupoetnicos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GenGrupoetnicos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CodGrupo,Descripcion")] GenGrupoetnico genGrupoetnico)
        {
            if (ModelState.IsValid)
            {
                _context.Add(genGrupoetnico);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(genGrupoetnico);
        }

        // GET: GenGrupoetnicos/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.GenGrupoetnicos == null)
            {
                return NotFound();
            }

            var genGrupoetnico = await _context.GenGrupoetnicos.FindAsync(id);
            if (genGrupoetnico == null)
            {
                return NotFound();
            }
            return View(genGrupoetnico);
        }

        // POST: GenGrupoetnicos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CodGrupo,Descripcion")] GenGrupoetnico genGrupoetnico)
        {
            if (id != genGrupoetnico.CodGrupo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(genGrupoetnico);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GenGrupoetnicoExists(genGrupoetnico.CodGrupo))
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
            return View(genGrupoetnico);
        }

        // GET: GenGrupoetnicos/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.GenGrupoetnicos == null)
            {
                return NotFound();
            }

            var genGrupoetnico = await _context.GenGrupoetnicos
                .FirstOrDefaultAsync(m => m.CodGrupo == id);
            if (genGrupoetnico == null)
            {
                return NotFound();
            }

            return View(genGrupoetnico);
        }

        // POST: GenGrupoetnicos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.GenGrupoetnicos == null)
            {
                return Problem("Entity set 'BdlaboratorioContext.GenGrupoetnicos'  is null.");
            }
            var genGrupoetnico = await _context.GenGrupoetnicos.FindAsync(id);
            if (genGrupoetnico != null)
            {
                _context.GenGrupoetnicos.Remove(genGrupoetnico);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GenGrupoetnicoExists(string id)
        {
          return (_context.GenGrupoetnicos?.Any(e => e.CodGrupo == id)).GetValueOrDefault();
        }
    }
}
