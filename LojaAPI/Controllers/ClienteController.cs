using AutoMapper;
using LojaAPI.Controllers.DTO.Cliente;
using LojaAPI.Controllers.DTO.Produto;
using LojadeRoupa._01_Service;
using LojadeRoupa._01_Service.Interface;
using LojadeRoupa._02_Repository;
using LojadeRoupa._03_Entidades;
using Microsoft.AspNetCore.Mvc;

namespace LojaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController:ControllerBase
    {
        private readonly IClienteService service;
        private readonly IMapper _mapper;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="config"></param>
        /// <param name="mapper"></param>
        public ClienteController(IConfiguration config, IMapper mapper)
        {
            string configuration = config.GetConnectionString("DefaultConnection");
            service = new ClienteService(configuration);
            _mapper = mapper;
        }
        /// <summary>
        /// Adicione um cliente
        /// </summary>
        /// <param name="cliente"></param>

        [HttpPost("Adicionar-Cliente")]
        public IActionResult AdicionarCliente(CreateClienteDto cliente)

        {
            try
            {
                Cliente cliente1 = _mapper.Map<Cliente>(cliente);
                service.AdicionarCliente(cliente1);
                return Ok(cliente1);
            }
            catch (Exception exception)
            {
                BadRequest($"Ocorreu um erro ao adicionar o aluno, " +
                    $"o erro foi \n {exception.Message}");
                throw;
            }
           
        }
        /// <summary>
        /// Lista de Clientes
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        [HttpGet("Listar-Cliente")]
        public List<Cliente> ListarCliente()
        {
            try
            {
                return service.ListarCliente();
            }
            catch (Exception)
            {

                throw new Exception("Erro ao Listar o Cliente");
            }
            
        }
        /// <summary>
        /// Modifique Dados dos Clientes
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        [HttpPut("Editar-Cliente")]
        public IActionResult EditarCliente(Cliente cliente)
        {
            service.EditarCliente(cliente);
            return NoContent();
        }
        /// <summary>
        /// Exclua um CLIENTE do seu Banco de Dados
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        [HttpDelete("Deletar-Cliente")]
        public IActionResult DeletarCliente(int cliente)
        {
            service.Delete(cliente);
            return NoContent();
        }
    }
}
