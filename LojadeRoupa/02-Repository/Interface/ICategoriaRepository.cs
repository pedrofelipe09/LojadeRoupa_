using LojadeRoupa._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojadeRoupa._02_Repository.Interface
{
    public interface ICategoriaRepository
    {
        void AdicionarCategoria(Categoria categoria);
        List<Categoria> ListarCategoria();
        Categoria BuscarProduto(int id);
        void Editar(Categoria categoria);
        void Delete(int id);
    }
}
