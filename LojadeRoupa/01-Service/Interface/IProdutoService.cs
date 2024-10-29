using LojadeRoupa._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojadeRoupa._01_Service.Interface
{
    public interface IProdutoService
    {
        void AdicionarProduto(Produto produto);
        List<Produto> ListarProdutos();
        void EditarProduto(Produto produto);
        void Delete(int id);
    }
}
