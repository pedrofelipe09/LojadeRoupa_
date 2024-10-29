using LojadeRoupa._01_Service.Interface;
using LojadeRoupa._02_Repository;
using LojadeRoupa._02_Repository.Interface;
using LojadeRoupa._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojadeRoupa._01_Service
{
    public class ClienteService : IClienteService
    {
        public IClienteRepository _service { get; set; }

        public ClienteService(string connection)
        {
            _service = new ClienteRepository(connection);
        }

        public void AdicionarCliente(Cliente cliente)
        {
            _service.AdicionarCliente(cliente);
        }

        public List<Cliente> ListarCliente()
        {
            return _service.ListarCliente();
        }

        public void EditarCliente(Cliente cliente)
        {
            _service.EditarCliente(cliente);
        }

        public void Delete(int id)
        {
            _service.Delete(id);
        }
    }
}
