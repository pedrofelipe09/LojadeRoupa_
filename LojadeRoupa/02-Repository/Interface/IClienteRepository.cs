using LojadeRoupa._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojadeRoupa._02_Repository.Interface
{
    public interface IClienteRepository
    {
        void AdicionarCliente(Cliente cliente);
        List<Cliente> ListarCliente();
        Cliente BuscarCliente(int id);
        void EditarCliente(Cliente cliente);
        void Delete(int id);
    }
}
