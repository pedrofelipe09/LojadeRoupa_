using AutoMapper;
using LojaAPI.Controllers.DTO.Produto;
using LojadeRoupa._02_Repository;
using LojadeRoupa._03_Entidades;
using Microsoft.AspNetCore.Mvc;

namespace LojaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriaController:ControllerBase
    {
        private readonly CategoriaRepository repository;
        private readonly IMapper _mapper;

        public CategoriaController(IConfiguration config, IMapper mapper)
        {
            string configuration = config.GetConnectionString("DefaultConnection");
            repository = new CategoriaRepository(configuration);
            _mapper = mapper;
        }

        [HttpPost("Adicionar-Categoria")]
        public void AdicionarCategoria(Categoria categoria)

        {
            Categoria categoria1 = _mapper.Map<Categoria>(categoria);
            repository.AdicionarCategoria(categoria);
        }
        [HttpGet("Listar-Categoria")]
        public List<Categoria> ListarCategoria()
        {
            return repository.ListarCategoria();
        }
        [HttpPut("Editar-Categoria")]
        public void EditarCategoria(Categoria categoria)
        {
            repository.Editar(categoria);
        }

        [HttpDelete("Deletar-Categoria")]
        public void DeletarCategoria(int categoria)
        {
            repository.Delete(categoria);
        }

    }
}
