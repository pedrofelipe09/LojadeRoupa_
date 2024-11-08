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

        public ClienteController(IConfiguration config, IMapper mapper)
        {
            string configuration = config.GetConnectionString("DefaultConnection");
            service = new ClienteService(configuration);
            _mapper = mapper;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cliente"></param>

        [HttpPost("Adicionar-Cliente")]
        public void AdicionarCliente(CreateClienteDto cliente)

        {
            Cliente cliente1 = _mapper.Map<Cliente>(cliente);
            service.AdicionarCliente(cliente1);
        }
        [HttpGet("Listar-Cliente")]
        public List<Cliente> ListarCliente()
        {
            return service.ListarCliente();
        }

        [HttpPut("Editar-Cliente")]
        public void EditarCliente(Cliente cliente)
        {
            service.EditarCliente(cliente);
        }

        [HttpDelete("Deletar-Cliente")]
        public void DeletarCliente(int cliente)
        {
            service.Delete(cliente);
        }
    }
}
