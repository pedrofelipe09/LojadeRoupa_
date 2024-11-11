using LojadeRoupa._03_Entidades.DTO.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojadeRoupa._01_Service.Interface
{
    public interface IEnderecoService
    {
        void AdicionarEndereco(Endereco endereco);
        List<Endereco> ListarEndereco();
        void EditarEndereco(Endereco endereco);
        void DeleteEndereco(int id);
    }
}
