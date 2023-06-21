using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Novasoft.Server.Data;

namespace Novasoft.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GenMenuGralController : ControllerBase
    {
        private readonly BdlaboratorioContext _context;

        public GenMenuGralController(BdlaboratorioContext context)
        {
            _context = context;
        }

        [HttpGet("{idCodApl}", Name = "GenMenuGral")]
        public async Task<ActionResult<IEnumerable<GenMenuGral>>> Get(string idCodApl)
        {
            IEnumerable<GenMenuGral> result = await _context.GenMenuGrals.Where(x=>x.CodApl== idCodApl&&x.TipObj=="P"&&x.GruMenu== "Novasoft").Take(20).ToListAsync();
            return result is null ? NoContent() : Ok(result);
        }
    }
}
