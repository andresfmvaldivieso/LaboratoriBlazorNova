using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Novasoft.Server.Data;

namespace Novasoft.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeneralController<T> : ControllerBase where T : class
    {
        public readonly BdlaboratorioContext _context;

        public GeneralController(BdlaboratorioContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<T>> Get()
        {
            return (IEnumerable<T>)await _context.GenDeptos.ToListAsync();
        }
    }
}
