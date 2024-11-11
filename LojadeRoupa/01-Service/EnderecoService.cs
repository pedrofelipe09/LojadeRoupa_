using LojadeRoupa._01_Service.Interface;
using LojadeRoupa._02_Repository;
using LojadeRoupa._02_Repository.Interface;
using LojadeRoupa._03_Entidades;
using LojadeRoupa._03_Entidades.DTO.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojadeRoupa._01_Service
{
    public class EnderecoService : IEnderecoService
    {
        public IEnderecoRepository _service { get; set; }
        public EnderecoService(string connection)
        {
            _service = new EnderecoRepository(connection);
        }
        public void AdicionarEndereco(Endereco endereco)
        {
            _service.AdicionarEndereco(endereco);
        }

        public List<Endereco> ListarEndereco()
        {
            return _service.ListarEndereco();
        }

        public void EditarEndereco(Endereco endereco)
        {
            _service.EditarEndereco(endereco);
        }

        public void DeleteEndereco(int id)
        {
            _service.DeleteEndereco(id);
        }
    }
}
