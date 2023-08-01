using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Novasoft.Server.Data;

namespace Novasoft.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RhhTbTipTrabajosController : ControllerBase
    {
        private readonly BdlaboratorioContext _context;

        public RhhTbTipTrabajosController(BdlaboratorioContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<RhhTbTipTrabajo>>> Get()
        {
            IEnumerable<RhhTbTipTrabajo> result = await _context.RhhTbTipTrabajos.ToListAsync();
            return result is null ? NoContent() : Ok(result);
        }
    }
}
