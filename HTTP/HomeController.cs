using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace SimpleHttpApp
{
    // Controlador simples para lidar com as requisições
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return Ok("Requisição GET recebida com sucesso.");
        }

        
        [HttpPost]
        public IActionResult Post()
        {
            return Ok("Requisição POST recebida com sucesso.");
        }

        
        public IActionResult Unauthorized()
        {
            return Unauthorized();
        }

        
        public IActionResult Forbidden()
        {
            return Forbid();
        }

        
        public IActionResult NotFound()
        {
            return NotFound();
        }

       
        public IActionResult InternalServerError()
        {
            throw new System.Exception("Erro interno do servidor.");
        }
    }
}
