using LojadeRoupa._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojadeRoupa._01_Service.Interface
{
    public interface ICompraService
    {
        void AdicionarCompra(Compra compra);
        List<Compra> ListarCompras();
        void EditarCompra(Compra compra);
        void DeletarCompras(int id);
    }
}
