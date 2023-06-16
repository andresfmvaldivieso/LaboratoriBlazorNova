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
    public class GenCompaniumsController : Controller
    {
        private readonly BdlaboratorioContext _context;

        public GenCompaniumsController(BdlaboratorioContext context)
        {
            _context = context;
        }

        // GET: GenCompaniums
        public async Task<IActionResult> Index()
        {
              return _context.GenCompania != null ? 
                          View(await _context.GenCompania.ToListAsync()) :
                          Problem("Entity set 'BdlaboratorioContext.GenCompania'  is null.");
        }

        // GET: GenCompaniums/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.GenCompania == null)
            {
                return NotFound();
            }

            var genCompanium = await _context.GenCompania
                .FirstOrDefaultAsync(m => m.CodCia == id);
            if (genCompanium == null)
            {
                return NotFound();
            }

            return View(genCompanium);
        }

        // GET: GenCompaniums/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GenCompaniums/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CodCia,NomCia,NitCia,DigVer,NumPat,RepLeg,DirCia,CodPai,CodDep,CodCiu,TelCia,FaxCia,CorEle,LogoCia,ImagenFirmaAut,ResponsableGh,NomPagador,DirectorRh,CargoDirectorRh,TipPagpen,CodActEconomica,EntInformante,Identfc,Tdocpcc,Nitpcc,CodOrganigrama,CodEstrucCargo,CodCiaExtr,IndActExtr")] GenCompanium genCompanium)
        {
            if (ModelState.IsValid)
            {
                _context.Add(genCompanium);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(genCompanium);
        }

        // GET: GenCompaniums/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.GenCompania == null)
            {
                return NotFound();
            }

            var genCompanium = await _context.GenCompania.FindAsync(id);
            if (genCompanium == null)
            {
                return NotFound();
            }
            return View(genCompanium);
        }

        // POST: GenCompaniums/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CodCia,NomCia,NitCia,DigVer,NumPat,RepLeg,DirCia,CodPai,CodDep,CodCiu,TelCia,FaxCia,CorEle,LogoCia,ImagenFirmaAut,ResponsableGh,NomPagador,DirectorRh,CargoDirectorRh,TipPagpen,CodActEconomica,EntInformante,Identfc,Tdocpcc,Nitpcc,CodOrganigrama,CodEstrucCargo,CodCiaExtr,IndActExtr")] GenCompanium genCompanium)
        {
            if (id != genCompanium.CodCia)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(genCompanium);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GenCompaniumExists(genCompanium.CodCia))
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
            return View(genCompanium);
        }

        // GET: GenCompaniums/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.GenCompania == null)
            {
                return NotFound();
            }

            var genCompanium = await _context.GenCompania
                .FirstOrDefaultAsync(m => m.CodCia == id);
            if (genCompanium == null)
            {
                return NotFound();
            }

            return View(genCompanium);
        }

        // POST: GenCompaniums/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.GenCompania == null)
            {
                return Problem("Entity set 'BdlaboratorioContext.GenCompania'  is null.");
            }
            var genCompanium = await _context.GenCompania.FindAsync(id);
            if (genCompanium != null)
            {
                _context.GenCompania.Remove(genCompanium);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GenCompaniumExists(string id)
        {
          return (_context.GenCompania?.Any(e => e.CodCia == id)).GetValueOrDefault();
        }
    }
}
