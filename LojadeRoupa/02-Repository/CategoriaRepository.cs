using Dapper.Contrib.Extensions;
using LojadeRoupa._02_Repository.Interface;
using LojadeRoupa._03_Entidades;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LojadeRoupa._02_Repository
{
    public class CategoriaRepository : ICategoriaRepository
    {
        public readonly string connectionstring;
        public CategoriaRepository(string connection)
        {
            connectionstring = connection;
        }

        public void AdicionarCategoria(Categoria categoria)
        {
            using var connection = new SQLiteConnection(connectionstring);
            connection.Insert<Categoria>(categoria);
        }
        public List<Categoria> ListarCategoria()
        {
            using var connection = new SQLiteConnection(connectionstring);
            return connection.GetAll<Categoria>().ToList();

        }
        public Categoria BuscarProduto(int id)
        {
            using var connection = new SQLiteConnection(connectionstring);
            return connection.Get<Categoria>(id);
        }
        public void Editar(Categoria categoria)
        {
            using var connection = new SQLiteConnection(connectionstring);
            connection.Update<Categoria>(categoria);
        }
        public void Delete(int id)
        {
            using var connection = new SQLiteConnection(connectionstring);
            Categoria categoria = BuscarProduto(id);
            connection.Delete<Categoria>(categoria);
        }

    }
}
