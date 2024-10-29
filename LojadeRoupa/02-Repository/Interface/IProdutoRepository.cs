using LojadeRoupa._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojadeRoupa._02_Repository.Interface
{
    public interface IProdutoRepository
    {
        void AdicionarProduto(Produto produto);
        List<Produto> ListarProdutos();
        Produto BuscarProduto(int id);
        void Editar(Produto produto);
        void Delete(int id);
    }
}
