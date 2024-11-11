using LojadeRoupa._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojadeRoupa._01_Service.Interface
{
    public interface IVendaService
    {
        void AdicionarVenda(Venda venda);
        List<Venda> ListarVenda();
        void EditarVenda(Venda venda);
        void DeleteVenda(int id);
    }
}
