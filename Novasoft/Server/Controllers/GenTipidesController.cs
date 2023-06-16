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
    [ApiController]
    [Route("api/[controller]")]
    public class GenTipidesController : ControllerBase
    {
        private readonly BdlaboratorioContext _context;

        public GenTipidesController(BdlaboratorioContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GenTipide>>> Get()
        {
            IEnumerable<GenTipide> result = await _context.GenTipides.ToListAsync();
            return result is null ? NoContent() : Ok(result);
        }
    }
}
