using AutoMapper;
using LojaAPI.Controllers.DTO.Compra;
using LojaAPI.Controllers.DTO.Produto;
using LojadeRoupa._01_Service;
using LojadeRoupa._03_Entidades;
using LojadeRoupa._03_Entidades.DTO.Venda;
using Microsoft.AspNetCore.Mvc;

namespace LojaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VendaController:ControllerBase
    {
        private readonly VendaService service;
        private readonly IMapper _mapper;

        public VendaController(IConfiguration config, IMapper mapper)
        {
            string configuration = config.GetConnectionString("DefaultConnection");
            service = new VendaService(configuration);
            _mapper = mapper;
        }
        /// <summary>
        /// Adicione uma Venda
        /// </summary>
        /// <param name="venda"></param>
        /// <returns></returns>
        [HttpPost("Adicionar-Venda")]
        public IActionResult AdicionarVenda(CreateVendaDto venda)

        {
            try
            {
                Venda venda1 = _mapper.Map<Venda>(venda);
                service.AdicionarVenda(venda1);
                return Ok(venda1);
            }
            catch (Exception erro)
            {

                return BadRequest($"Ocorreu um erro ao adicionar a venda," +
                    $"o erro foi \n{erro.Message}");
            }

        }
        /// <summary>
        /// Lista de Vendas
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        [HttpGet("Listar-Venda")]
        public List<Venda> ListarVenda()
        {
            try
            {
                return service.ListarVenda();
            }
            catch (Exception)
            {

                throw new Exception("Erro ao listar as Vendas");
            }

        }
        /// <summary>
        /// Modifique os dados da Venda
        /// </summary>
        /// <param name="venda"></param>
        /// <returns></returns>
        [HttpPut("Editar-Venda")]
        public IActionResult EditarVenda(Venda venda)
        {
            service.EditarVenda(venda);
            return NoContent();
        }
        /// <summary>
        /// Delete uma Venda
        /// </summary>
        /// <param name="produto"></param>
        /// <returns></returns>
        [HttpDelete("Deletar-Venda")]
        public IActionResult DeleteVenda(int venda)
        {
            service.DeleteVenda(venda);
            return NoContent();
        }


    }
}
