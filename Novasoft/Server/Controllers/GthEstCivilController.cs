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
    public class GthEstCivilController : ControllerBase
    {
        private readonly BdlaboratorioContext _context;

        public GthEstCivilController(BdlaboratorioContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GthEstCivil>>> GetEstCivil()
        {
            if (_context.GthEstCivils == null)
            {
                return NotFound();
            }
            return await _context.GthEstCivils.ToListAsync();
        }
    }
}
