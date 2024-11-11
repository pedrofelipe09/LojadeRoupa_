using LojadeRoupa._03_Entidades.DTO.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojadeRoupa._02_Repository.Interface
{
    public interface IEnderecoRepository
    {
        void AdicionarEndereco(Endereco endereco);
        List<Endereco> ListarEndereco();
        Endereco BuscarEndereco(int id);
        void EditarEndereco(Endereco endereco);
        void DeleteEndereco(int id);
    }
}
