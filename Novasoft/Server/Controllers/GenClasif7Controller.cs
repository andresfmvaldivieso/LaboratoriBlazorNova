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
    public class GenClasif7Controller : ControllerBase
    {
        private readonly BdlaboratorioContext _context;

        public GenClasif7Controller(BdlaboratorioContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GenClasif7>>> Get()
        {
            IEnumerable<GenClasif7> result = await _context.GenClasif7s.ToListAsync();
            return result is null ? NoContent() : Ok(result);
        }
    }
}
