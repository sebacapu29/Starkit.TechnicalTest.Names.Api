using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Starkit.Test.Application.DTOs.Requests;
using Starkit.Test.Application.Interfaces;
using Starkit.Test.Application;

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
        public async Task<IActionResult> GetNames(NameRequest nameRequest)
        {
            Logger.LogInfo("Getting Names..");
            var respuesta = await _nameService.GetNames(nameRequest);
            return Ok(respuesta);
        }
    }
}
