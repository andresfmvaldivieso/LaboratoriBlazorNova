using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Novasoft.Server.Data;
using Novasoft.Server.Models;

namespace Novasoft.Server.Services
{
    public class GenPaiseServices: IGenPaiseServices
    {
        private readonly BdlaboratorioContext _context;

        public GenPaiseServices(BdlaboratorioContext dbcontext)
        {
            _context = dbcontext;
        }

        public async  Task<IEnumerable<GenPaise>> Get()
        {
            return await _context.GenPaises.ToListAsync();
        }
        public async Task Save(GenPaise genPaise)
        {
            _context.Add(genPaise);
            await _context.SaveChangesAsync();
        }

        public async Task Update(string codPai, GenPaise genPaise)
        {
            var paisActual = _context.GenPaises.FirstOrDefault(x => x.CodPai == codPai);

            if (paisActual is not null)
            {
                _context.Entry(genPaise).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
        }

        public async Task Delete(string codPai)
        {
            var paisActual = _context.GenPaises.FirstOrDefault(x => x.CodPai == codPai);

            if (paisActual is not null)
            {
                _context.Remove(paisActual);
                await _context.SaveChangesAsync();
            }
        }
    }
    public interface IGenPaiseServices
    {
        Task<IEnumerable<GenPaise>> Get();
        Task Save(GenPaise genPaise);
        Task Update(string codPai, GenPaise genPaise);
        Task Delete(string codPai);
    }
}
