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
    public class GenCcostosController : ControllerBase
    {
        private readonly BdlaboratorioContext _context;

        public GenCcostosController(BdlaboratorioContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GenCcosto>>> Get()
        {
            IEnumerable<GenCcosto> result = await _context.GenCcostos.ToListAsync();
            return result is null ? NoContent() : Ok(result);
        }

    }
}
