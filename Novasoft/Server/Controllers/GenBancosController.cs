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
    public class GenBancosController : ControllerBase
    {
        private readonly BdlaboratorioContext _context;

        public GenBancosController(BdlaboratorioContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GenBanco>>> Get()
        {
            IEnumerable<GenBanco> result = await _context.GenBancos.ToListAsync();
            return result is null ? NoContent() : Ok(result);
        }
    }
}
