using Microsoft.AspNetCore.Mvc;
using AmigosCRUD.Services;
using AmigosCRUD.Domain.Interfaces;
using AmigosCRUD.Domain.Entities;

namespace AmigosCRUD.API.Controllers
{
    public class AmigoApiController : ControllerBase
    {
        private readonly IAmigoService _amigoService;
        public AmigoApiController(IAmigoService amigoService) 
        {
            _amigoService = amigoService;
        }
        // R - Read
        [HttpGet]
        [Route("/Amigos")]
        public IActionResult Index()
        {
            return Ok( _amigoService.GetAll() );
        }
        // C - Create
        [HttpPost]
        [Route("/Amigos/NovoAmigo")]
        public IActionResult RegistrarAmigo(Amigo amigo) 
        {
            _amigoService.Registrar(amigo);
            return Ok();
        }
        // D - Delete
        [HttpDelete]
        [Route("/Amigos/{id}")]
        public IActionResult DeletarAmigo(int id) 
        {
            _amigoService.Deletar(id);
            return NoContent();
        }
        // U - Update
        [HttpPut]
        [Route("/Amigos")]
        public IActionResult AtualizarAmigo(Amigo amigo) 
        {
            _amigoService.Atualizar(amigo);
            return NoContent();
        }
    }
}
