using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Novasoft.Server.Data;

namespace Novasoft.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RhhSucursalSssController : ControllerBase
    {
        private readonly BdlaboratorioContext _context;

        public RhhSucursalSssController(BdlaboratorioContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<RhhSucursalSs>>> Get()
        {
            IEnumerable<RhhSucursalSs> result = await _context.RhhSucursalSses.ToListAsync();
            return result is null ? NoContent() : Ok(result);
        }
    }
}
