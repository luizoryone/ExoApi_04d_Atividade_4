using ExoApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ExoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjetosController : ControllerBase
    {
        private readonly ProjetoRepository _repo;

        // Injeção de dependência do repositório
        public ProjetosController(ProjetoRepository repo)
        {
            _repo = repo;
        }

        // Método GET para listar projetos
        [HttpGet]
        public IActionResult GetProjetos()
        {
            var projetos = _repo.Listar(); // Chama o método Listar() do repositório
            return StatusCode(200, projetos); // Retorna os projetos com status 200
        }
    }
}
