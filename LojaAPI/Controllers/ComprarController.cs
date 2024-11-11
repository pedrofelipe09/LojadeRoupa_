using AutoMapper;
using LojaAPI.Controllers.DTO.Compra;
using LojadeRoupa._01_Service;
using LojadeRoupa._02_Repository;
using LojadeRoupa._03_Entidades;
using Microsoft.AspNetCore.Mvc;

namespace LojaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ComprarController : ControllerBase
    {
        private readonly CompraService service;
        private readonly IMapper _mapper;

        public ComprarController(IConfiguration config, IMapper mapper)
        {
            string configuration = config.GetConnectionString("DefaultConnection");
            service = new CompraService(configuration);
            _mapper = mapper;
        }
        /// <summary>
        /// Adicione uma Compra
        /// </summary>
        /// <param name="compra"></param>
        /// <returns></returns>
        [HttpPost("Adicionar-Compra")]
        public IActionResult AdicionarCompra(CreateCompraDTO compra)

        {
            try
            {
                Compra compra1 = _mapper.Map<Compra>(compra);
                service.AdicionarCompra(compra1);
                return Ok(compra1);
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        /// <summary>
        /// Lista das Compras
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        [HttpGet("Listar-Compra")]
        public List<Compra> ListarCompra()
        {
            try
            {
                return service.ListarCompras();
            }
            catch (Exception)
            {

                throw new Exception("Erro ao listar as Compras");
            }
        
        }
        /// <summary>
        /// Modifique Dados das Compras
        /// </summary>
        /// <param name="compra"></param>
        /// <returns></returns>
        [HttpPut("Editar-Compra")]
        public IActionResult EditarCompra(Compra compra)
        {
            service.EditarCompra(compra);
            return NoContent();
        }
        /// <summary>
        /// Exclua uma COMPRA do seu Banco de Dados
        /// </summary>
        /// <param name="compra"></param>
        /// <returns></returns>
        [HttpDelete("Deletar-Compra")]
        public IActionResult DeletarCompra(int compra)
        {
            service.DeletarCompras(compra);
            return NoContent();
        }

    }
}
