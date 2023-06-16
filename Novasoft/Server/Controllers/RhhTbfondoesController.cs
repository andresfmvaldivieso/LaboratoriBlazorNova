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
    public class RhhTbfondoesController : Controller
    {
        private readonly BdlaboratorioContext _context;

        public RhhTbfondoesController(BdlaboratorioContext context)
        {
            _context = context;
        }

        // GET: RhhTbfondoes
        public async Task<IActionResult> Index()
        {
              return _context.RhhTbfondos != null ? 
                          View(await _context.RhhTbfondos.ToListAsync()) :
                          Problem("Entity set 'BdlaboratorioContext.RhhTbfondos'  is null.");
        }

        // GET: RhhTbfondoes/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.RhhTbfondos == null)
            {
                return NotFound();
            }

            var rhhTbfondo = await _context.RhhTbfondos
                .FirstOrDefaultAsync(m => m.CodFdo == id);
            if (rhhTbfondo == null)
            {
                return NotFound();
            }

            return View(rhhTbfondo);
        }

        // GET: RhhTbfondoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RhhTbfondoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CodFdo,NomFdo,NitTer,DvrTer,SecFdo,TipFdo,CodSgs,CtaFdo,CtaDeb,Ind326,IndD30,IndDau,CodCon,IndProv,Ind12vaInc,CreFsp,DebFsp,CodSap,NiifDeb,NiifCre,NiifDebfsp,NiifCrefsp,CodBan,CtaBanfdo,MedPag,TipCtafdo,Rubros,ConcDesc,TipGasto")] RhhTbfondo rhhTbfondo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rhhTbfondo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(rhhTbfondo);
        }

        // GET: RhhTbfondoes/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.RhhTbfondos == null)
            {
                return NotFound();
            }

            var rhhTbfondo = await _context.RhhTbfondos.FindAsync(id);
            if (rhhTbfondo == null)
            {
                return NotFound();
            }
            return View(rhhTbfondo);
        }

        // POST: RhhTbfondoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CodFdo,NomFdo,NitTer,DvrTer,SecFdo,TipFdo,CodSgs,CtaFdo,CtaDeb,Ind326,IndD30,IndDau,CodCon,IndProv,Ind12vaInc,CreFsp,DebFsp,CodSap,NiifDeb,NiifCre,NiifDebfsp,NiifCrefsp,CodBan,CtaBanfdo,MedPag,TipCtafdo,Rubros,ConcDesc,TipGasto")] RhhTbfondo rhhTbfondo)
        {
            if (id != rhhTbfondo.CodFdo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rhhTbfondo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RhhTbfondoExists(rhhTbfondo.CodFdo))
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
            return View(rhhTbfondo);
        }

        // GET: RhhTbfondoes/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.RhhTbfondos == null)
            {
                return NotFound();
            }

            var rhhTbfondo = await _context.RhhTbfondos
                .FirstOrDefaultAsync(m => m.CodFdo == id);
            if (rhhTbfondo == null)
            {
                return NotFound();
            }

            return View(rhhTbfondo);
        }

        // POST: RhhTbfondoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.RhhTbfondos == null)
            {
                return Problem("Entity set 'BdlaboratorioContext.RhhTbfondos'  is null.");
            }
            var rhhTbfondo = await _context.RhhTbfondos.FindAsync(id);
            if (rhhTbfondo != null)
            {
                _context.RhhTbfondos.Remove(rhhTbfondo);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RhhTbfondoExists(string id)
        {
          return (_context.RhhTbfondos?.Any(e => e.CodFdo == id)).GetValueOrDefault();
        }
    }
}
