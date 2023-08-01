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
    public class RhhTbmedidaDian2280Controller : ControllerBase
    {
        private readonly BdlaboratorioContext _context;

        public RhhTbmedidaDian2280Controller(BdlaboratorioContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RhhTbmedidaDian2280>>> Get()
        {
            IEnumerable<RhhTbmedidaDian2280> result = await _context.RhhTbmedidaDian2280s.ToListAsync();
            return result is null ? NoContent() : Ok(result);
        }

    }
}
