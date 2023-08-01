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
    public class GenClasif6Controller : ControllerBase
    {
        private readonly BdlaboratorioContext _context;

        public GenClasif6Controller(BdlaboratorioContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GenClasif6>>> Get()
        {
            IEnumerable<GenClasif6> result = await _context.GenClasif6s.ToListAsync();
            return result is null ? NoContent() : Ok(result);
        }
    }
}
