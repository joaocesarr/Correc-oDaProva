using Microsoft.AspNetCore.Mvc;
using Revisao.Application.Interfaces;
using Revisao.Application.ViewModels;

namespace Revisao.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CartaController : ControllerBase
    {
        private readonly ICartaService _cartaService;

        public CartaController(ICartaService cartaService)
        {
            _cartaService = cartaService;
        }

        [HttpPost(Name = "Adicionar")]
        public IActionResult Post(NovaCartaViewModel novaCartaViewModel)
        {
            _cartaService.Adicionar(novaCartaViewModel);

            return Ok();
        }


        [HttpGet(Name = "ObterTodos")]
        public IActionResult Get()
        {
            return Ok(_cartaService.ObterTodos());
        }
    }
}
