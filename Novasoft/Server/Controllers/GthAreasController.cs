using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Novasoft.Server.Data;

namespace Novasoft.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GthAreasController : ControllerBase
    {
        private readonly BdlaboratorioContext _context;

        public GthAreasController(BdlaboratorioContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GthArea>>> Get()
        {
            IEnumerable<GthArea> result = await _context.GthAreas.ToListAsync();
            return result is null ? NoContent() : Ok(result);
        }
    }
}
