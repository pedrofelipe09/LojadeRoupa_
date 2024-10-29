using AutoMapper;
using LojaAPI.Controllers.DTO.Produto;
using LojadeRoupa._01_Service;
using LojadeRoupa._01_Service.Interface;
using LojadeRoupa._02_Repository;
using LojadeRoupa._02_Repository.Interface;
using LojadeRoupa._03_Entidades;
using Microsoft.AspNetCore.Mvc;

namespace LojaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriaController:ControllerBase
    {
        private readonly ICategoriaService service;
        private readonly IMapper _mapper;

        public CategoriaController(IConfiguration config, IMapper mapper)
        {
            string configuration = config.GetConnectionString("DefaultConnection");
            service = new CategoriaService(configuration);
            _mapper = mapper;
        }

        [HttpPost("Adicionar-Categoria")]
        public void AdicionarCategoria(Categoria categoria)

        {
            Categoria categoria1 = _mapper.Map<Categoria>(categoria);
            service.AdicionarCategoria(categoria1);
        }
        [HttpGet("Listar-Categoria")]
        public List<Categoria> ListarCategoria()
        {
            return service.ListarCategoria();
        }
        [HttpPut("Editar-Categoria")]
        public void EditarCategoria(Categoria categoria)
        {
            service.EditarCategoria(categoria);
        }

        [HttpDelete("Deletar-Categoria")]
        public void DeletarCategoria(int categoria)
        {
            service.Delete(categoria);
        }

    }
}
