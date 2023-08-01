using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Novasoft.Server.Data;

namespace Novasoft.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebMaestrosGensController : ControllerBase
    {
        private readonly BdlaboratorioContext _context;

        public WebMaestrosGensController(BdlaboratorioContext context)
        {
            _context = context;
        }

        [HttpGet("{CodMae}")]
        public async Task<ActionResult<WebMaestrosgen>> Get(short codMae)
        {
            WebMaestrosgen result = await _context.WebMaestrosgens.FirstOrDefaultAsync(x => x.CodMae == codMae);
            return result is null ? NoContent() : Ok(result);
        }
    }
}
