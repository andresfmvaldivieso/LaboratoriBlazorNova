using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Novasoft.Server.Data;

namespace Novasoft.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SisApliacacionesController : ControllerBase
    {
        private readonly BdlaboratorioContext _context;

        public SisApliacacionesController(BdlaboratorioContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SisAplicacion>>> Get()
        {
            IEnumerable<SisAplicacion> result = await _context.SisAplicacions.ToListAsync();
            return result is null ? NoContent() : Ok(result);
        }

    }
}
