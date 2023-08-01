using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Novasoft.Shared.Models;

namespace Novasoft.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersLoginController : ControllerBase
    {
        [HttpPost]
        public  async Task<ActionResult> UserLogin([FromBody] UserLogin userLogin)
        {
            return Ok();
        }
    }
}
