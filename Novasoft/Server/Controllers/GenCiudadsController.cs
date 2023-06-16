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
    public class GenCiudadsController : ControllerBase
    {
        private readonly BdlaboratorioContext _context;

        public GenCiudadsController(BdlaboratorioContext context)
        {
            _context = context;
        }

        // GET: api/GenCiudads
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GenCiudad>>> GetGenCiudads()
        {
          if (_context.GenCiudads == null)
          {
              return NotFound();
          }
            return await _context.GenCiudads.ToListAsync();
        }

        // GET: api/GenCiudads/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GenCiudad>> GetGenCiudad(string id)
        {
          if (_context.GenCiudads == null)
          {
              return NotFound();
          }
            var genCiudad = await _context.GenCiudads.FindAsync(id);

            if (genCiudad == null)
            {
                return NotFound();
            }

            return genCiudad;
        }

        // PUT: api/GenCiudads/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGenCiudad(string id, GenCiudad genCiudad)
        {
            if (id != genCiudad.CodPai)
            {
                return BadRequest();
            }

            _context.Entry(genCiudad).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GenCiudadExists(id))
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

        // POST: api/GenCiudads
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<GenCiudad>> PostGenCiudad(GenCiudad genCiudad)
        {
          if (_context.GenCiudads == null)
          {
              return Problem("Entity set 'BdlaboratorioContext.GenCiudads'  is null.");
          }
            _context.GenCiudads.Add(genCiudad);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (GenCiudadExists(genCiudad.CodPai))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetGenCiudad", new { id = genCiudad.CodPai }, genCiudad);
        }

        // DELETE: api/GenCiudads/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGenCiudad(string id)
        {
            if (_context.GenCiudads == null)
            {
                return NotFound();
            }
            var genCiudad = await _context.GenCiudads.FindAsync(id);
            if (genCiudad == null)
            {
                return NotFound();
            }

            _context.GenCiudads.Remove(genCiudad);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GenCiudadExists(string id)
        {
            return (_context.GenCiudads?.Any(e => e.CodPai == id)).GetValueOrDefault();
        }
    }
}
