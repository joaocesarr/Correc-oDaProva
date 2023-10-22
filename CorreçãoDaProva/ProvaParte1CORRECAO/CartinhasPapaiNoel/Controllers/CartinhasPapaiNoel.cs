using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Cartinhas.PapaiNoel.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CartasController : ControllerBase
    {
        private readonly string jsonFilePath = "cartas"; 

        [HttpPost]
        public IActionResult EnviarCarta([FromBody] Carta carta)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            
            var cartas = LerCartas();

           
            cartas.Add(carta);

           
            SalvarCartas(cartas);

            return Ok("Suas cartas foram enviadas com sucesso");
        }

        [HttpGet]
        public IActionResult ListarCartas()
        {
            var cartas = LerCartas();
            return Ok(cartas);
        }

        private List<Carta> LerCartas()
        {
            if (System.IO.File.Exists(jsonFilePath))
            {
                var jsonString = System.IO.File.ReadAllText(jsonFilePath);
                var cartas = JsonSerializer.Deserialize<List<Carta>>(jsonString);
                return cartas ?? new List<Carta>();
            }
            return new List<Carta>();
        }

        private void SalvarCartas(List<Carta> cartas)
        {
            var jsonString = JsonSerializer.Serialize(cartas);
            System.IO.File.WriteAllText(jsonFilePath, jsonString);
        }
    }
}
