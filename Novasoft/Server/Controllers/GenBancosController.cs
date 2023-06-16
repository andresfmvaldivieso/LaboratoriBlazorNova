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
    public class GenBancosController : Controller
    {
        private readonly BdlaboratorioContext _context;

        public GenBancosController(BdlaboratorioContext context)
        {
            _context = context;
        }

        // GET: GenBancos
        public async Task<IActionResult> Index()
        {
              return _context.GenBancos != null ? 
                          View(await _context.GenBancos.ToListAsync()) :
                          Problem("Entity set 'BdlaboratorioContext.GenBancos'  is null.");
        }

        // GET: GenBancos/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.GenBancos == null)
            {
                return NotFound();
            }

            var genBanco = await _context.GenBancos
                .FirstOrDefaultAsync(m => m.CodBan == id);
            if (genBanco == null)
            {
                return NotFound();
            }

            return View(genBanco);
        }

        // GET: GenBancos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GenBancos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CodBan,NomBan,CodTra,CodSuper,NitBan,BanUnion,BanEle,BanEc,BanNacha,CodBanach")] GenBanco genBanco)
        {
            if (ModelState.IsValid)
            {
                _context.Add(genBanco);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(genBanco);
        }

        // GET: GenBancos/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.GenBancos == null)
            {
                return NotFound();
            }

            var genBanco = await _context.GenBancos.FindAsync(id);
            if (genBanco == null)
            {
                return NotFound();
            }
            return View(genBanco);
        }

        // POST: GenBancos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CodBan,NomBan,CodTra,CodSuper,NitBan,BanUnion,BanEle,BanEc,BanNacha,CodBanach")] GenBanco genBanco)
        {
            if (id != genBanco.CodBan)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(genBanco);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GenBancoExists(genBanco.CodBan))
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
            return View(genBanco);
        }

        // GET: GenBancos/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.GenBancos == null)
            {
                return NotFound();
            }

            var genBanco = await _context.GenBancos
                .FirstOrDefaultAsync(m => m.CodBan == id);
            if (genBanco == null)
            {
                return NotFound();
            }

            return View(genBanco);
        }

        // POST: GenBancos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.GenBancos == null)
            {
                return Problem("Entity set 'BdlaboratorioContext.GenBancos'  is null.");
            }
            var genBanco = await _context.GenBancos.FindAsync(id);
            if (genBanco != null)
            {
                _context.GenBancos.Remove(genBanco);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GenBancoExists(string id)
        {
          return (_context.GenBancos?.Any(e => e.CodBan == id)).GetValueOrDefault();
        }
    }
}
