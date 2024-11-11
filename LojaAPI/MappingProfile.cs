using AutoMapper;

using LojaAPI.Controllers.DTO.Cliente;
using LojaAPI.Controllers.DTO.Compra;
using LojaAPI.Controllers.DTO.Estoque;

using LojaAPI.Controllers.DTO.Produto;
using LojadeRoupa._03_Entidades;
using LojadeRoupa._03_Entidades.DTO.Endereco;
using LojadeRoupa._03_Entidades.DTO.Produto;

namespace LojaAPI
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateProdutoDto, Produto>().ReverseMap();
           
            CreateMap<CreateEstoqueDto, Estoque>().ReverseMap();
            CreateMap<CreateClienteDto, Cliente>().ReverseMap();
            
            CreateMap<CreateCompraDTO, Compra>().ReverseMap();
            CreateMap<CreateEnderecoDto, Endereco>().ReverseMap();


        }
    }
}
