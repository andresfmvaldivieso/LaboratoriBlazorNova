using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Novasoft.Server.Data;

namespace Novasoft.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenDeptoesController : ControllerBase
    {
        private readonly BdlaboratorioContext _context;

        public GenDeptoesController(BdlaboratorioContext context)
        {
            _context = context;
        }

        // GET: api/GenDeptoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GenDepto>>> GetGenDeptos()
        {
          if (_context.GenDeptos == null)
          {
              return NotFound();
          }
            return await _context.GenDeptos.ToListAsync();
        }

        // GET: api/GenDeptoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GenDepto>> GetGenDepto(string id)
        {
          if (_context.GenDeptos == null)
          {
              return NotFound();
          }
            var genDepto = await _context.GenDeptos.FindAsync(id);

            if (genDepto == null)
            {
                return NotFound();
            }

            return genDepto;
        }

        [HttpGet("{CodPais}")]
        public async Task<ActionResult<IEnumerable<GenDepto>>> GetGenDeptoPaises(string codPais)
        {
            if (_context.GenDeptos == null)
            {
                return NotFound();
            }
            var genDepto = await _context.GenDeptos.Where(x=>x.CodPai== codPais).ToListAsync();

            if (genDepto == null)
            {
                return NotFound();
            }

            return genDepto;
        }

        // PUT: api/GenDeptoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGenDepto(string id, GenDepto genDepto)
        {
            if (id != genDepto.CodPai)
            {
                return BadRequest();
            }

            _context.Entry(genDepto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GenDeptoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/GenDeptoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<GenDepto>> PostGenDepto(GenDepto genDepto)
        {
          if (_context.GenDeptos == null)
          {
              return Problem("Entity set 'BdlaboratorioContext.GenDeptos'  is null.");
          }
            _context.GenDeptos.Add(genDepto);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (GenDeptoExists(genDepto.CodPai))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetGenDepto", new { id = genDepto.CodPai }, genDepto);
        }

        // DELETE: api/GenDeptoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGenDepto(string id)
        {
            if (_context.GenDeptos == null)
            {
                return NotFound();
            }
            var genDepto = await _context.GenDeptos.FindAsync(id);
            if (genDepto == null)
            {
                return NotFound();
            }

            _context.GenDeptos.Remove(genDepto);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GenDeptoExists(string id)
        {
            return (_context.GenDeptos?.Any(e => e.CodPai == id)).GetValueOrDefault();
        }
    }
}
