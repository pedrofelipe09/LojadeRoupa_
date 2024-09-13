using AutoMapper;
using LojaAPI.Controllers;
using LojaAPI.Controllers.DTO.Estoque;
using LojaAPI.Controllers.DTO.Produto;
using LojadeRoupa._02_Repository;
using LojadeRoupa._03_Entidades;
using Microsoft.AspNetCore.Mvc;

namespace LojaAPI.Controllers
{
    [Route("[controller]")]
    public class EstoqueController : ControllerBase
    {
        private readonly EstoqueRepository repository;
        private readonly IMapper mapper;
    }
}

public class EstoqueController : ControllerBase
{
    private readonly EstoqueRepository repository;
    private readonly IMapper _mapper;

    public EstoqueController(IConfiguration config, IMapper mapper)
    {
        string configuration = config.GetConnectionString("DefaultConnection");
        repository = new EstoqueRepository(configuration);
        _mapper = mapper;
    }

    [HttpPost("Adicionar-Estoque")]
    public void AdicionarEstoque(CreateEstoqueDto estoque)

    {
       Estoque estoque1 = _mapper.Map<Estoque>(estoque);
        repository.AdicionarEstoque(estoque1);
    }
    [HttpGet("Listar-Estoque")]
    public List<Estoque> ListarEstoque()
    {
        return repository.ListarEstoque();
    }

    [HttpPut("Editar-Estoque")]
    public void EditarEstoque(Estoque estoque)
    {
        repository.EditarEstoque(estoque);
    }

    [HttpDelete("Deletar-Estoque")]
    public void DeletarEstoque(int estoque)
    {
        repository.Delete(estoque);
    }

}



