using AutoMapper;
using LojaAPI.Controllers.DTO.Produto;
using LojadeRoupa._01_Service;
using LojadeRoupa._02_Repository;
using LojadeRoupa._02_Repository.Interface;
using LojadeRoupa._03_Entidades;
using Microsoft.AspNetCore.Mvc;

namespace LojaAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]

    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoRepository service;
        private readonly IMapper _mapper;

        public ProdutoController(IConfiguration config, IMapper mapper)
        {
            string configuration = config.GetConnectionString("DefaultConnection");
            service = new ProdutoRepository(configuration);
            _mapper = mapper;
        }

        /// <summary>
        /// Adicione um Produto
        /// </summary>
        /// <param name="produto"></param>
        /// <returns></returns>
        [HttpPost("Adicionar-dapper")]
        public IActionResult AdicionarProduto(CreateProdutoDto produto)

        {
            try
            {
                Produto produto1 = _mapper.Map<Produto>(produto);
                service.AdicionarProduto(produto1);
                return Ok();
            }
            catch (Exception)
            {

                throw;
            }

         }
        /// <summary>
        /// Lista de Produtos
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        [HttpGet("Listar-Produtos")]
        public List<Produto> ListarProdutos()
        {
            try
            {
                return service.ListarProdutos();
            }
            catch (Exception)
            {

                throw new Exception("Erro ao listar os Produtos");
            }
        }
        /// <summary>
        /// Modifique Dados dos Produtos
        /// </summary>
        /// <param name="produto"></param>
        /// <returns></returns>
        [HttpPut("Editar-Produtos")]
        public IActionResult EditarProdutos(Produto produto)
        {
            service.Editar(produto);
            return NoContent();
        }
        /// <summary>
        /// Exclua um PRODUTO do seu Banco de Dados
        /// </summary>
        /// <param name="produto"></param>
        /// <returns></returns>
        [HttpDelete("Deletar-Produtos")]
        public IActionResult DeletarProduto(int produto)
        {
            service.Delete(produto);
            return NoContent();
        }



    }
}
