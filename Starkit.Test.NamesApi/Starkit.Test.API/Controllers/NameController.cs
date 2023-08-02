using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    [Route("api/")]
    [ApiController]
    public class NameController : ControllerBase
    {
        public NameController() { }

        [HttpGet("names")]
        [ProducesResponseType(200)]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "valor1", "valor2" };
        }
    }
}
