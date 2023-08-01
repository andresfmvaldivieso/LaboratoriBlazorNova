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
    public class GenCompaniumsController : ControllerBase
    {
        private readonly BdlaboratorioContext _context;

        public GenCompaniumsController(BdlaboratorioContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GenCompanium>>> Get()
        {
            IEnumerable<GenCompanium> result = await _context.GenCompania.ToListAsync();
            return result is null ? NoContent() : Ok(result);
        }
    }
    
}
