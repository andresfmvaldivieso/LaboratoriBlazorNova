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
    public class GthGeneroesController : ControllerBase
    {
        private readonly BdlaboratorioContext _context;

        public GthGeneroesController(BdlaboratorioContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GthGenero>>> Get()
        {
            IEnumerable<GthGenero> result = await _context.GthGeneros.ToListAsync();
            return result is null ? NoContent() : Ok(result);
        }

    }
}
