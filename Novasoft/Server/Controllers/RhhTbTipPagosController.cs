using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Novasoft.Server.Data;

namespace Novasoft.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RhhTbTipPagosController : ControllerBase
    {
        private readonly BdlaboratorioContext _context;

        public RhhTbTipPagosController(BdlaboratorioContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<RhhTbTipPag>>> Get()
        {
            IEnumerable<RhhTbTipPag> result = await _context.RhhTbTipPags.ToListAsync();
            return result is null ? NoContent() : Ok(result);
        }
    }
}
