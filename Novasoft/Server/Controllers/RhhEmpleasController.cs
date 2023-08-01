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
    [Route("api/[controller]")]
    [ApiController]
    public class RhhEmpleasController : ControllerBase
    {
        private readonly BdlaboratorioContext _context;

        public RhhEmpleasController(BdlaboratorioContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<RhhEmplea>>> Get()
        {
            IEnumerable<RhhEmplea> result = await _context.RhhEmpleas.Include(x=>x.TipIdeNavigation).ToListAsync();
            return result is null ? NoContent() : Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<RhhEmplea>> Post(RhhEmplea rhhEmplea)
        {
            if (rhhEmplea == null)
            {
                return Problem("Entity set 'BdlaboratorioContext.rhhEmplea'  is null.");
            }
            try
            {
                _context.Add(rhhEmplea);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return CreatedAtAction("rhhEmplea", new { id = rhhEmplea.CodEmp }, rhhEmplea);
        }
    }
}
