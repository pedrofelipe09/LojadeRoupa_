using LojadeRoupa._02_Repository;
using LojadeRoupa._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojadeRoupa._01_Service
{
    public class CompraService
    {
        public CompraRepository _repository { get; set; }
        public CompraService(string connection)
        {
            _repository = new CompraRepository(connection);
        }
        public void AdicionarCompra(Compra compra)
        {
            _repository.AdicionarCompra(compra);
        }

        public List<Compra> ListarCompras()
        {
            return _repository.ListarCompras();
        }

        public void EditarCompra(Compra compra)
        {
            _repository.EditarCompra(compra);
        }

        public void DeletarCompras(int id)
        {
            _repository.DeletarCompras(id);     
        }
    }
}
