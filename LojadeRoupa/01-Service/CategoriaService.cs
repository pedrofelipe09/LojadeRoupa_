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
    public class CategoriaService : ICategoriaService
    {
        public ICategoriaRepository _repository { get; set; }

        public CategoriaService(string connection)  
        {
            _repository = new CategoriaRepository(connection);
        }
        public void AdicionarCategoria(Categoria categoria)
        {
            _repository.AdicionarCategoria(categoria);
        }
        public List<Categoria> ListarCategoria()
        {
            return _repository.ListarCategoria();
        }
        public void EditarCategoria(Categoria categoria)
        {
            _repository.Editar(categoria);
        }
        public void Delete(int id)
        {
            _repository.Delete(id);
        }

    }
}
