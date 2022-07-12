using Microsoft.AspNetCore.Mvc;
using UniversalCNAB.API.Helper;

namespace UniversalCNAB.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Cnab240Controller : Controller
    {
        /// <summary>
        /// Método exemplo
        /// </summary>
        /// <returns>string vazia</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorHandler))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorHandler))]
        [HttpGet("Teste")]
        public IActionResult Index()
        {
            try
            {
                return Ok("");
            }
            catch (BadHttpRequestException ex)
            {
                return BadRequest(new ErrorHandler().Catch(ex));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ErrorHandler().Catch(ex));
            }
        }
    }
}
