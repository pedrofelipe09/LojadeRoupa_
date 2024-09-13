using LojadeRoupa._02_Repository;
using LojadeRoupa._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojadeRoupa._01_Service
{
    public class PedidoService
    {
        public PedidoRepository _repository { get; set; }

        public PedidoService(string connection)
        {
            _repository = new PedidoRepository(connection);
        }
        public void AdicionarPedido(Pedido pedido)
        {
            _repository.AdicionarPedido(pedido);
        }

        public List<Pedido> ListarPedido()
        {
            return _repository.ListarPedido();
        }

        public void EditarPedido(Pedido pedido)
        {
            _repository.Editar(pedido);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}
