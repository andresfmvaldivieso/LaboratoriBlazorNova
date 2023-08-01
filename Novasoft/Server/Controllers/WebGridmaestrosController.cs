using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Novasoft.Server.Data;

namespace Novasoft.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebGridmaestrosController : ControllerBase
    {
        private readonly BdlaboratorioContext _context;

        public WebGridmaestrosController(BdlaboratorioContext context)
        {
            _context = context;
        } 

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<WebGridmaestro>>> Get(short id)
        {
            var result = await _context.WebGridmaestros.Where(x=>x.CodMae==id).ToListAsync();
            return result is null ? NoContent() : Ok(result);

        }
    }
}
