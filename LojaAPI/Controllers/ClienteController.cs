using AutoMapper;
using LojaAPI.Controllers.DTO.Cliente;
using LojaAPI.Controllers.DTO.Produto;
using LojadeRoupa._02_Repository;
using LojadeRoupa._03_Entidades;
using Microsoft.AspNetCore.Mvc;

namespace LojaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController:ControllerBase
    {
        private readonly ClienteRepository repository;
        private readonly IMapper _mapper;

        public ClienteController(IConfiguration config, IMapper mapper)
        {
            string configuration = config.GetConnectionString("DefaultConnection");
            repository = new ClienteRepository(configuration);
            _mapper = mapper;
        }

        [HttpPost("Adicionar-Cliente")]
        public void AdicionarCliente(CreateClienteDto cliente)

        {
            Cliente cliente1 = _mapper.Map<Cliente>(cliente);
            repository.AdicionarCliente(cliente1);
        }
        [HttpGet("Listar-Cliente")]
        public List<Cliente> ListarCliente()
        {
            return repository.ListarCliente();
        }

        [HttpPut("Editar-Cliente")]
        public void EditarCliente(Cliente cliente)
        {
            repository.EditarCliente(cliente);
        }

        [HttpDelete("Deletar-Cliente")]
        public void DeletarCliente(int cliente)
        {
            repository.Delete(cliente);
        }
    }
}
