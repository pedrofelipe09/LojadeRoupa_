using LojadeRoupa._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojadeRoupa._01_Service.Interface
{
    public interface IClienteService
    {
        void AdicionarCliente(Cliente cliente);
        List<Cliente> ListarCliente();
        void EditarCliente(Cliente cliente);
        void Delete(int id);
    }
}
