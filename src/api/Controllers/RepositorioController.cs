using Microsoft.AspNetCore.Mvc;
using TerraDesafio.Interfaces;

namespace TerraDesafio.Controllers{
    [ApiController]
    [Route("api/v1/[controller]")] 

    public class RepositorioController: ControllerBase{

        public readonly IRepositorioService _repositorioService;

        public RepositorioController(IRepositorioService repositorioService)
        {
            _repositorioService = repositorioService;
        }

        [HttpGet("repositorios")]
        public async Task<IActionResult> BuscarRepositorios(){
            var response = await _repositorioService.BuscarRepositorios();
            if (response.CodigoHttp == System.Net.HttpStatusCode.OK){
                return Ok(response.DadosRetorno);
            } else {
                return StatusCode((int)response.CodigoHttp, response.ErroRetorno);
            }
        }
    }
}