using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Novasoft.Server.Data;

namespace Novasoft.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebPaginasmaesController : ControllerBase
    {
        private readonly BdlaboratorioContext _context;

        public WebPaginasmaesController(BdlaboratorioContext context)
        {
            _context = context;
        }

        [HttpGet("{CodMae}")]
        public async Task<ActionResult<IEnumerable<WebPaginasmae>>> Get(short codMae)
        {
            IEnumerable<WebPaginasmae> result = await _context.WebPaginasmaes.Where(x=>x.CodMae==codMae).Include(x=>x.WebMaestros).ToListAsync();
            return result is null ? NoContent() : Ok(result);
        }

    }
}
