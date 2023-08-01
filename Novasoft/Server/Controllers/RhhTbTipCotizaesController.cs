using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Novasoft.Server.Data;

namespace Novasoft.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RhhTbTipCotizaesController : ControllerBase
    {
        private readonly BdlaboratorioContext _context;

        public RhhTbTipCotizaesController(BdlaboratorioContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RhhTbTipCotiza>>> Get()
        {
            IEnumerable<RhhTbTipCotiza> result = await _context.RhhTbTipCotizas.ToListAsync();
            return result is null ? NoContent() : Ok(result);
        }

    }
}
