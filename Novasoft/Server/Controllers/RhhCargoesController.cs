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
    public class RhhCargoesController : Controller
    {
        private readonly BdlaboratorioContext _context;

        public RhhCargoesController(BdlaboratorioContext context)
        {
            _context = context;
        }

        // GET: RhhCargoes
        public async Task<IActionResult> Index()
        {
            var bdlaboratorioContext = _context.RhhCargos.Include(r => r.CarSupNavigation).Include(r => r.CodCiaNavigation).Include(r => r.NivAcaNavigation);
            return View(await bdlaboratorioContext.ToListAsync());
        }

        // GET: RhhCargoes/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.RhhCargos == null)
            {
                return NotFound();
            }

            var rhhCargo = await _context.RhhCargos
                .Include(r => r.CarSupNavigation)
                .Include(r => r.CodCiaNavigation)
                .Include(r => r.NivAcaNavigation)
                .FirstOrDefaultAsync(m => m.CodCar == id);
            if (rhhCargo == null)
            {
                return NotFound();
            }

            return View(rhhCargo);
        }

        // GET: RhhCargoes/Create
        public IActionResult Create()
        {
            ViewData["CarSup"] = new SelectList(_context.RhhCargos, "CodCar", "CodCar");
            ViewData["CodCia"] = new SelectList(_context.GenCompania, "CodCia", "CodCia");
            ViewData["NivAca"] = new SelectList(_context.RhhTbclaests, "TipEst", "TipEst");
            return View();
        }

        // POST: RhhCargoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CodCar,CodGra,NomCar,SalBas,NivCar,DesCar,CarCia,Atrib,CarSup,RespCar,FuncCar,NivAca,CodAreaCno,CodNivelCno,CodConv,CodCia,CodCli,CodGruCiuo,CodCiuo,CnoDet,CodActSecEc,ObjCar,RamaActsecEc,CodIessEc,CodCritico,CodCatCar,CarCop,CodCarExtr,CodEmpleo,IndActExtr,CodEstrucCargo,CodCiaExtr")] RhhCargo rhhCargo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rhhCargo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CarSup"] = new SelectList(_context.RhhCargos, "CodCar", "CodCar", rhhCargo.CarSup);
            ViewData["CodCia"] = new SelectList(_context.GenCompania, "CodCia", "CodCia", rhhCargo.CodCia);
            ViewData["NivAca"] = new SelectList(_context.RhhTbclaests, "TipEst", "TipEst", rhhCargo.NivAca);
            return View(rhhCargo);
        }

        // GET: RhhCargoes/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.RhhCargos == null)
            {
                return NotFound();
            }

            var rhhCargo = await _context.RhhCargos.FindAsync(id);
            if (rhhCargo == null)
            {
                return NotFound();
            }
            ViewData["CarSup"] = new SelectList(_context.RhhCargos, "CodCar", "CodCar", rhhCargo.CarSup);
            ViewData["CodCia"] = new SelectList(_context.GenCompania, "CodCia", "CodCia", rhhCargo.CodCia);
            ViewData["NivAca"] = new SelectList(_context.RhhTbclaests, "TipEst", "TipEst", rhhCargo.NivAca);
            return View(rhhCargo);
        }

        // POST: RhhCargoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CodCar,CodGra,NomCar,SalBas,NivCar,DesCar,CarCia,Atrib,CarSup,RespCar,FuncCar,NivAca,CodAreaCno,CodNivelCno,CodConv,CodCia,CodCli,CodGruCiuo,CodCiuo,CnoDet,CodActSecEc,ObjCar,RamaActsecEc,CodIessEc,CodCritico,CodCatCar,CarCop,CodCarExtr,CodEmpleo,IndActExtr,CodEstrucCargo,CodCiaExtr")] RhhCargo rhhCargo)
        {
            if (id != rhhCargo.CodCar)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rhhCargo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RhhCargoExists(rhhCargo.CodCar))
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
            ViewData["CarSup"] = new SelectList(_context.RhhCargos, "CodCar", "CodCar", rhhCargo.CarSup);
            ViewData["CodCia"] = new SelectList(_context.GenCompania, "CodCia", "CodCia", rhhCargo.CodCia);
            ViewData["NivAca"] = new SelectList(_context.RhhTbclaests, "TipEst", "TipEst", rhhCargo.NivAca);
            return View(rhhCargo);
        }

        // GET: RhhCargoes/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.RhhCargos == null)
            {
                return NotFound();
            }

            var rhhCargo = await _context.RhhCargos
                .Include(r => r.CarSupNavigation)
                .Include(r => r.CodCiaNavigation)
                .Include(r => r.NivAcaNavigation)
                .FirstOrDefaultAsync(m => m.CodCar == id);
            if (rhhCargo == null)
            {
                return NotFound();
            }

            return View(rhhCargo);
        }

        // POST: RhhCargoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.RhhCargos == null)
            {
                return Problem("Entity set 'BdlaboratorioContext.RhhCargos'  is null.");
            }
            var rhhCargo = await _context.RhhCargos.FindAsync(id);
            if (rhhCargo != null)
            {
                _context.RhhCargos.Remove(rhhCargo);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RhhCargoExists(string id)
        {
          return (_context.RhhCargos?.Any(e => e.CodCar == id)).GetValueOrDefault();
        }
    }
}
