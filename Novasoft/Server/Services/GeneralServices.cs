using Microsoft.EntityFrameworkCore;
using Novasoft.Server.Data;

namespace Novasoft.Server.Services
{
    public class GeneralServices<T>
    {
        private readonly BdlaboratorioContext _context;

        public GeneralServices(BdlaboratorioContext dbcontext)
        {
            _context = dbcontext;
        }

        public async Task<IEnumerable<T>> Get()
        {
            return (IEnumerable<T>)await _context.GenDeptos.ToListAsync();
        }
    }
}
