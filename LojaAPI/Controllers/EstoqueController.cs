using AutoMapper;
using LojaAPI.Controllers;
using LojaAPI.Controllers.DTO.Estoque;
using LojaAPI.Controllers.DTO.Produto;
using LojadeRoupa._02_Repository;
using LojadeRoupa._02_Repository.Interface;
using LojadeRoupa._03_Entidades;
using Microsoft.AspNetCore.Mvc;

namespace LojaAPI.Controllers
{
    [Route("[controller]")]
    public class EstoqueController : ControllerBase
    {
        private readonly EstoqueRepository service;
        private readonly IMapper mapper;
    }
}

public class EstoqueController : ControllerBase
{
    private readonly IEstoqueRepository service;
    private readonly IMapper _mapper;

    public EstoqueController(IConfiguration config, IMapper mapper)
    {
        string configuration = config.GetConnectionString("DefaultConnection");
        service = new EstoqueRepository(configuration);
        _mapper = mapper;
    }

    [HttpPost("Adicionar-Estoque")]
    public void AdicionarEstoque(CreateEstoqueDto estoque)

    {
       Estoque estoque1 = _mapper.Map<Estoque>(estoque);
        service.AdicionarEstoque(estoque1);
    }
    [HttpGet("Listar-Estoque")]
    public List<Estoque> ListarEstoque()
    {
        return service.ListarEstoque();
    }

    [HttpPut("Editar-Estoque")]
    public void EditarEstoque(Estoque estoque)
    {
        service.EditarEstoque(estoque);
    }

    [HttpDelete("Deletar-Estoque")]
    public void DeletarEstoque(int estoque)
    {
        service.Delete(estoque);
    }

}



