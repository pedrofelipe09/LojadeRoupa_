using LojadeRoupa._02_Repository;
using LojadeRoupa._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojadeRoupa._01_Service
{
    public class EstoqueService
    {
        public EstoqueRepository repository { get; set; }

        public EstoqueService(string connection)
        {
            repository = new EstoqueRepository(connection);
        }
        public void AdicionarEstoque(Estoque estoque)
        {
            repository.AdicionarEstoque(estoque);
        }
        public List<Estoque> ListarEstoque()
        {
            return repository.ListarEstoque();
        }

        public void EditarEstoque(Estoque estoque)
        {
            repository.EditarEstoque(estoque);
        }

        public void Delete(int id)
        {
            repository.Delete(id);
        }
    }
}
