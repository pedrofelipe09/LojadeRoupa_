using AutoMapper;
using LojaAPI.Controllers.DTO.Produto;
using LojadeRoupa._01_Service;
using LojadeRoupa._02_Repository;
using LojadeRoupa._03_Entidades;
using Microsoft.AspNetCore.Mvc;

namespace LojaAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]

    public class ProdutoController : ControllerBase
    {
        private readonly ProdutoRepository repository;
        private readonly IMapper _mapper;

        public ProdutoController(IConfiguration config, IMapper mapper)
        {
            string configuration = config.GetConnectionString("DefaultConnection");
            repository = new ProdutoRepository(configuration);
            _mapper = mapper;
        }


        [HttpPost("Adicionar-dapper")]
        public void AdicionarProduto(CreateProdutoDto produto)

        {
            Produto produto1 = _mapper.Map<Produto>(produto);
            repository.AdicionarProduto(produto1);
        }
        [HttpGet("Listar-Produtos")]
        public List<Produto> ListarProdutos()
        {
            return repository.ListarProdutos();
        }

        [HttpPut("Editar-Produtos")]
        public void EditarProdutos(Produto produto)
        {
            repository.Editar(produto);
        }

        [HttpDelete("Deletar-Produtos")]
        public void DeletarProduto(int produto)
        {
            repository.Delete(produto);
        }



    }
}
