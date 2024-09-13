using LojadeRoupa._02_Repository;
using LojadeRoupa._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojadeRoupa._01_Service
{
    public class ClienteService
    {
        public ClienteRepository _repository { get; set; }

        public ClienteService(string connection)
        {
            _repository = new ClienteRepository(connection);
        }

        public void AdicionarCliente(Cliente cliente)
        {
            _repository.AdicionarCliente(cliente);
        }

        public List<Cliente> ListarCliente()
        {
            return _repository.ListarCliente();
        }

        public void EditarCliente(Cliente cliente)
        {
            _repository.EditarCliente(cliente);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}
