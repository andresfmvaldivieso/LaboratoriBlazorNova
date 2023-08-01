using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Novasoft.Server.Data;

namespace Novasoft.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RhhTipconsController : ControllerBase
    {
        private readonly BdlaboratorioContext _context;

        public RhhTipconsController(BdlaboratorioContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<RhhTipcon>>> Get()
        {
            IEnumerable<RhhTipcon> result = await _context.RhhTipcons.ToListAsync();
            return result is null ? NoContent() : Ok(result);
        }
    }
}
