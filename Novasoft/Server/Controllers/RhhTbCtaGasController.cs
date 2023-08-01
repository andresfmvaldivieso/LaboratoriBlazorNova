using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Novasoft.Server.Data;

namespace Novasoft.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RhhTbCtaGasController : ControllerBase
    {
        private readonly BdlaboratorioContext _context;

        public RhhTbCtaGasController(BdlaboratorioContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<RhhTbCtaGa>>> Get()
        {
            IEnumerable<RhhTbCtaGa> result = await _context.RhhTbCtaGas.ToListAsync();
            return result is null ? NoContent() : Ok(result);
        }
    }
}
