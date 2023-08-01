using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NameController : ControllerBase
    {
        public NameController() { }

        [HttpGet]
        [ProducesResponseType(200)] // Indica que devuelve una respuesta HTTP 200 exitosa
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "valor1", "valor2" };
        }
    }
}
