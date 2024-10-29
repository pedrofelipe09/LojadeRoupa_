using LojadeRoupa._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojadeRoupa._02_Repository.Interface
{
    public interface IEstoqueRepository
    {
        void AdicionarEstoque(Estoque estoque);
        List<Estoque> ListarEstoque();
        Estoque BuscarEstoque(int id);
        void EditarEstoque(Estoque estoque);
        void Delete(int id);
    }
}
