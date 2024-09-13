using LojadeRoupa._02_Repository;
using LojadeRoupa._02_Repository.Data;
using LojadeRoupa._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojadeRoupa._01_Service
{
    public class ProdutoService
    {
        public ProdutoRepository _repository { get; set; }

        public ProdutoService(string connection)
        {
            _repository = new ProdutoRepository(connection);
        }

        public void AdicionarProduto(Produto produto )
        {
            _repository.AdicionarProduto(produto);
        }

        public List<Produto> ListarProdutos()
        {
            return _repository.ListarProdutos();
        }

        public void EditarProduto(Produto produto)
        {
            _repository.Editar(produto);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }
     

    }
}
