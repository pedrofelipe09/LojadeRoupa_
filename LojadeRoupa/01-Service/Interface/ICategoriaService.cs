using LojadeRoupa._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojadeRoupa._01_Service.Interface
{
    public interface ICategoriaService
    {
        void AdicionarCategoria(Categoria categoria);
        List<Categoria> ListarCategoria();
        void EditarCategoria(Categoria categoria);
        void Delete(int id);

    }
}
