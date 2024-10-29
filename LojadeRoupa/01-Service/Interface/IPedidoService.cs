using LojadeRoupa._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojadeRoupa._01_Service.Interface
{
    public interface IPedidoService
    {
        void AdicionarPedido(Pedido pedido);
        List<Pedido> ListarPedido();
        void EditarPedido(Pedido pedido);
        void Delete(int id);
    }
}
