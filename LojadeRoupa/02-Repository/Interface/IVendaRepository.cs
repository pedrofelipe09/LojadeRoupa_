using LojadeRoupa._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojadeRoupa._02_Repository.Interface
{
    public interface IVendaRepository
    {
        void AdicionarVenda(Venda venda);
        List<Venda> ListarVenda();
        Venda BuscarVenda(int id);
        void EditarVenda(Venda venda);
        void DeleteVenda(int id);
    }
}
