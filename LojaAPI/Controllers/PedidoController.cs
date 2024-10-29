using AutoMapper;
using LojaAPI.Controllers.DTO.Pedido;
using LojaAPI.Controllers.DTO.Produto;
using LojadeRoupa._02_Repository;
using LojadeRoupa._02_Repository.Interface;
using LojadeRoupa._03_Entidades;
using Microsoft.AspNetCore.Mvc;

namespace LojaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PedidoController
    {
        private readonly IPedidoRepository service;
        private readonly IMapper _mapper;

        public PedidoController(IConfiguration config, IMapper mapper)
        {
            string configuration = config.GetConnectionString("DefaultConnection");
            service = new PedidoRepository(configuration);
            _mapper = mapper;
        }

        [HttpPost("Adicionar-Pedido")]
        public void AdicionarPedido(CreatePedidoDto pedido)

        {
            Pedido pedido1 = _mapper.Map<Pedido>(pedido);
            service.AdicionarPedido(pedido1);
        }
        [HttpGet("Listar-Pedido")]
        public List<Pedido> ListarPedido()
        {
            return service.ListarPedido();
        }

        [HttpPut("Editar-Pedido")]
        public void EditarPedido(Pedido pedido)
        {
            service.Editar(pedido);
        }

        [HttpDelete("Deletar-Pedido")]
        public void DeletarPedido(int pedido)
        {
            service.Delete(pedido);
        }
    }
}
