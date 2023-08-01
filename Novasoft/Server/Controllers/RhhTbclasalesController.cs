using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Novasoft.Server.Data;

namespace Novasoft.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RhhTbclasalesController : ControllerBase
    {
        private readonly BdlaboratorioContext _context;

        public RhhTbclasalesController(BdlaboratorioContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<RhhTbclasal>>> Get()
        {
            IEnumerable<RhhTbclasal> result = await _context.RhhTbclasals.ToListAsync();
            return result is null ? NoContent() : Ok(result);
        }
    }
}
