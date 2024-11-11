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
    /// <summary>
    /// Adicione um Produto ao Estoque
    /// </summary>
    /// <param name="estoque"></param>
    /// <returns></returns>
    [HttpPost("Adicionar-Estoque")]
    public IActionResult AdicionarEstoque(CreateEstoqueDto estoque)

    {
        try
        {
            Estoque estoque1 = _mapper.Map<Estoque>(estoque);
            service.AdicionarEstoque(estoque1);
            return Ok(estoque1);
        }
        catch (Exception)
        {

            throw;
        }
      
    }
    /// <summary>
    /// Lista do Estoque
    /// </summary>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    [HttpGet("Listar-Estoque")]
    public List<Estoque> ListarEstoque()
    {
        try
        {
            return service.ListarEstoque();
        }
        catch (Exception)
        {

            throw new Exception("Erro ao listar o Estoque");
        }
    }
    /// <summary>
    /// Modifique Dados do Estoque
    /// </summary>
    /// <param name="estoque"></param>
    /// <returns></returns>
    [HttpPut("Editar-Estoque")]
    public IActionResult EditarEstoque(Estoque estoque)
    {
        service.EditarEstoque(estoque);
        return NoContent();
    }
    /// <summary>
    /// Exclua um Produto do Estoque do seu Banco de Dados
    /// </summary>
    /// <param name="estoque"></param>
    /// <returns></returns>
    [HttpDelete("Deletar-Estoque")]
    public IActionResult DeletarEstoque(int estoque)
    {
        service.Delete(estoque);
        return NoContent();
    }

}



