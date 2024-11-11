using AutoMapper;
using LojaAPI.Controllers.DTO.Compra;
using LojadeRoupa._02_Repository;
using LojadeRoupa._02_Repository.Interface;
using LojadeRoupa._03_Entidades;
using LojadeRoupa._03_Entidades.DTO.Endereco;
using LojadeRoupa._03_Entidades.DTO.Produto;
using Microsoft.AspNetCore.Mvc;

namespace LojaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EnderecoController:ControllerBase
    {
        private readonly IEnderecoRepository service;
        private readonly IMapper _mapper;

        public EnderecoController(IConfiguration config, IMapper mapper)
        {
            string configuration = config.GetConnectionString("DefaultConnection");
            service = new EnderecoRepository(configuration);
            _mapper = mapper;
        }
        /// <summary>
        /// Adicione um Endereco
        /// </summary>
        /// <param name="endereco"></param>
        /// <returns></returns>
        [HttpPost("Adicionar-Endereco")]
        public IActionResult AdicionarEndereco(CreateEnderecoDto endereco)

        {
            try
            {
                Endereco endereco1 = _mapper.Map<Endereco>(endereco);
                service.AdicionarEndereco(endereco1);
                return Ok(endereco1);
            }
            catch (Exception)
            {

                throw;
            }

        }
        /// <summary>
        /// Lista dos Endereços
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        [HttpGet("Listar-Endereco")]
        public List<Endereco> ListarEndereco()
        {
            try
            {
                return service.ListarEndereco();
            }
            catch (Exception)
            {

                throw new Exception("Erro ao listar Os Endereços");
            }

        }
        /// <summary>
        /// Modifique o Endereço
        /// </summary>
        /// <param name="endereco"></param>
        /// <returns></returns>
        [HttpPut("Editar-Endereco")]
        public IActionResult EditarEndereco(Endereco endereco)
        {
            service.EditarEndereco(endereco);
            return NoContent();
        }
        /// <summary>
        ///  Exclua um Endereço
        /// </summary>
        /// <param name="endereco"></param>
        /// <returns></returns>
        [HttpDelete("Deletar-Endereco")]
        public IActionResult DeletarEndereco(int endereco)
        {
            service.DeleteEndereco(endereco);
            return NoContent();
        }
    }
}
