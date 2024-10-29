using LojadeRoupa._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojadeRoupa._02_Repository.Interface
{
    public interface IPedidoRepository
    {
        void AdicionarPedido(Pedido pedido);
        List<Pedido> ListarPedido();
        Pedido BuscarPedido(int id);
        void Editar(Pedido pedido);
        void Delete(int id);

    }
}
