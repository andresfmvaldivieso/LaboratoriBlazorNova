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
    public class GenSucursalesController : Controller
    {
        private readonly BdlaboratorioContext _context;

        public GenSucursalesController(BdlaboratorioContext context)
        {
            _context = context;
        }

        // GET: GenSucursales
        public async Task<IActionResult> Index()
        {
            var bdlaboratorioContext = _context.GenSucursals.Include(g => g.Cod).Include(g => g.CodNavigation);
            return View(await bdlaboratorioContext.ToListAsync());
        }

        // GET: GenSucursales/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.GenSucursals == null)
            {
                return NotFound();
            }

            var genSucursal = await _context.GenSucursals
                .Include(g => g.Cod)
                .Include(g => g.CodNavigation)
                .FirstOrDefaultAsync(m => m.CodSuc == id);
            if (genSucursal == null)
            {
                return NotFound();
            }

            return View(genSucursal);
        }

        // GET: GenSucursales/Create
        public IActionResult Create()
        {
            ViewData["CodPai"] = new SelectList(_context.GenCiudads, "CodPai", "CodPai");
            ViewData["CodPai"] = new SelectList(_context.GenBarrios, "CodPai", "CodPai");
            return View();
        }

        // POST: GenSucursales/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CodSuc,NomSuc,DirSuc,CodPai,CodDep,CodCiu,TelSuc,EncSuc,EstSuc,TarIca,BodFact,CodIca,IndExciva,CodSucExtr,CodLocalidad,CodBarrio,IndActExtr")] GenSucursal genSucursal)
        {
            if (ModelState.IsValid)
            {
                _context.Add(genSucursal);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CodPai"] = new SelectList(_context.GenCiudads, "CodPai", "CodPai", genSucursal.CodPai);
            ViewData["CodPai"] = new SelectList(_context.GenBarrios, "CodPai", "CodPai", genSucursal.CodPai);
            return View(genSucursal);
        }

        // GET: GenSucursales/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.GenSucursals == null)
            {
                return NotFound();
            }

            var genSucursal = await _context.GenSucursals.FindAsync(id);
            if (genSucursal == null)
            {
                return NotFound();
            }
            ViewData["CodPai"] = new SelectList(_context.GenCiudads, "CodPai", "CodPai", genSucursal.CodPai);
            ViewData["CodPai"] = new SelectList(_context.GenBarrios, "CodPai", "CodPai", genSucursal.CodPai);
            return View(genSucursal);
        }

        // POST: GenSucursales/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CodSuc,NomSuc,DirSuc,CodPai,CodDep,CodCiu,TelSuc,EncSuc,EstSuc,TarIca,BodFact,CodIca,IndExciva,CodSucExtr,CodLocalidad,CodBarrio,IndActExtr")] GenSucursal genSucursal)
        {
            if (id != genSucursal.CodSuc)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(genSucursal);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GenSucursalExists(genSucursal.CodSuc))
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
            ViewData["CodPai"] = new SelectList(_context.GenCiudads, "CodPai", "CodPai", genSucursal.CodPai);
            ViewData["CodPai"] = new SelectList(_context.GenBarrios, "CodPai", "CodPai", genSucursal.CodPai);
            return View(genSucursal);
        }

        // GET: GenSucursales/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.GenSucursals == null)
            {
                return NotFound();
            }

            var genSucursal = await _context.GenSucursals
                .Include(g => g.Cod)
                .Include(g => g.CodNavigation)
                .FirstOrDefaultAsync(m => m.CodSuc == id);
            if (genSucursal == null)
            {
                return NotFound();
            }

            return View(genSucursal);
        }

        // POST: GenSucursales/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.GenSucursals == null)
            {
                return Problem("Entity set 'BdlaboratorioContext.GenSucursals'  is null.");
            }
            var genSucursal = await _context.GenSucursals.FindAsync(id);
            if (genSucursal != null)
            {
                _context.GenSucursals.Remove(genSucursal);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GenSucursalExists(string id)
        {
          return (_context.GenSucursals?.Any(e => e.CodSuc == id)).GetValueOrDefault();
        }
    }
}
