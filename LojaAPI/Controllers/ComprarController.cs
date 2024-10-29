using AutoMapper;
using LojaAPI.Controllers.DTO.Compra;
using LojaAPI.Controllers.DTO.Pedido;
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

        [HttpPost("Adicionar-Compra")]
        public void AdicionarCompra(CreateCompraDTO compra)

        {
            Compra compra1 = _mapper.Map<Compra>(compra);
            service.AdicionarCompra(compra1);
        }
        [HttpGet("Listar-Compra")]
        public List<Compra> ListarCompra()
        {
            return service.ListarCompras();
        }
        [HttpPut("Editar-Compra")]
        public void EditarCompra(Compra compra)
        {
            service.EditarCompra(compra);
        }
        [HttpDelete("Deletar-Compra")]
        public void DeletarCompra(int compra)
        {
            service.DeletarCompras(compra);
        }

    }
}
