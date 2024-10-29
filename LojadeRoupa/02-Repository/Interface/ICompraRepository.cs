using LojadeRoupa._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojadeRoupa._02_Repository.Interface
{
    public interface ICompraRepository
    {
        void AdicionarCompra(Compra compra);
        List<Compra> ListarCompras();
        Compra BuscarCompra(int id);
        void EditarCompra(Compra compra);
        void DeletarCompras(int id);
    }
}
