using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Starkit.Test.Application.DTOs.Requests;
using Starkit.Test.Application.Interfaces;

namespace App.Controllers
{
    [Route("api/")]
    [ApiController]
    public class NameController : ControllerBase
    {
        public INameService _nameService;
        public NameController(INameService nameService) 
        {   
            _nameService = nameService;
        }

        [HttpPost("names")]
        [ProducesResponseType(200)]
        public async Task<IActionResult> Get(NameRequest nameRequest)
        {
            var respuesta = await _nameService.GetNames(nameRequest);
            return Ok(respuesta);
        }
    }
}
