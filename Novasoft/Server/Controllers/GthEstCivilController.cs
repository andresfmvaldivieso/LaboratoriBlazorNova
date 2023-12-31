﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Novasoft.Server.Data;

namespace Novasoft.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GthEstCivilesController : ControllerBase
    {
        private readonly BdlaboratorioContext _context;

        public GthEstCivilesController(BdlaboratorioContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GthEstCivil>>> Get()
        {
            IEnumerable<GthEstCivil> result = await _context.GthEstCivils.ToListAsync();
            return result is null ? NoContent() : Ok(result);
        }
    }
}
