using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Novasoft.Server.Data;
using Novasoft.Server.Services;
using System.Collections.Generic;

namespace Novasoft.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GenPaiseController : ControllerBase
    {
        private readonly IGenPaiseServices genPaiseService;
        public GenPaiseController(IGenPaiseServices service)
        {
            genPaiseService = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GenPaise>>> Get()
        {
            IEnumerable<GenPaise> result = await genPaiseService.Get();

            return result is null ? NoContent() : Ok(result);

        }

        [HttpPost]
        public async Task<ActionResult<gen_deptos>> Post(GenPaise genPaise)
        {
            if (genPaise == null)
            {
                return Problem("Entity set 'BdlaboratorioContext.GenDeptos'  is null.");
            }
            try
            {
                await genPaiseService.Save(genPaise);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return CreatedAtAction("GetGenDepto", new { id = genPaise.CodPai }, genPaise);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(string id,GenPaise genPaise)
        {
            try
            {
                await genPaiseService.Update(id,genPaise);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGenDepto(string id)
        {
            await genPaiseService.Delete(id);
            
            return NoContent();
        }
    }
}
