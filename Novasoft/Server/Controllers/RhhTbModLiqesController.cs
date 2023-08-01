using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Novasoft.Server.Data;

namespace Novasoft.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RhhTbModLiqesController : ControllerBase
    {
        private readonly BdlaboratorioContext _context;

        public RhhTbModLiqesController(BdlaboratorioContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<RhhTbModLiq>>> Get()
        {
            IEnumerable<RhhTbModLiq> result = await _context.RhhTbModLiqs.ToListAsync();
            return result is null ? NoContent() : Ok(result);
        }
    }
}
