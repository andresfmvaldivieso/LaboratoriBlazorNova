using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Novasoft.Server.Data;

namespace Novasoft.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RhhCentroTrabsController : ControllerBase
    {
        private readonly BdlaboratorioContext _context;

        public RhhCentroTrabsController(BdlaboratorioContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<RhhCentroTrab>>> Get()
        {
            IEnumerable<RhhCentroTrab> result = await _context.RhhCentroTrabs.ToListAsync();
            return result is null ? NoContent() : Ok(result);
        }
    }
}
