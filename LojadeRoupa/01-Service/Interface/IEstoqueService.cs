using LojadeRoupa._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojadeRoupa._01_Service.Interface
{
    public interface IEstoqueService
    {
        void AdicionarEstoque(Estoque estoque);
        List<Estoque> ListarEstoque();
        void EditarEstoque(Estoque estoque);
        void Delete(int id);
    }
}
