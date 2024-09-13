using AutoMapper;
using LojaAPI.Controllers.DTO.Pedido;
using LojaAPI.Controllers.DTO.Produto;
using LojadeRoupa._02_Repository;
using LojadeRoupa._03_Entidades;
using Microsoft.AspNetCore.Mvc;

namespace LojaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PedidoController
    {
        private readonly PedidoRepository repository;
        private readonly IMapper _mapper;

        public PedidoController(IConfiguration config, IMapper mapper)
        {
            string configuration = config.GetConnectionString("DefaultConnection");
            repository = new PedidoRepository(configuration);
            _mapper = mapper;
        }

        [HttpPost("Adicionar-Pedido")]
        public void AdicionarPedido(CreatePedidoDto pedido)

        {
            Pedido pedido1 = _mapper.Map<Pedido>(pedido);
            repository.AdicionarPedido(pedido1);
        }
        [HttpGet("Listar-Pedido")]
        public List<Pedido> ListarPedido()
        {
            return repository.ListarPedido();
        }

        [HttpPut("Editar-Pedido")]
        public void EditarPedido(Pedido pedido)
        {
            repository.Editar(pedido);
        }

        [HttpDelete("Deletar-Pedido")]
        public void DeletarPedido(int pedido)
        {
            repository.Delete(pedido);
        }
    }
}
