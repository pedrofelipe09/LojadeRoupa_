using Dapper.Contrib.Extensions;
using LojadeRoupa._03_Entidades;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojadeRoupa._02_Repository
{
    public class ProdutoRepository
    {
        public readonly string _connectionString;
        public ProdutoRepository(string connection)
        {
            _connectionString = connection;
        }


        public void AdicionarProduto(Produto produto)
        {
            using var connection = new SQLiteConnection(_connectionString);
            connection.Insert<Produto>(produto);
        }
        public List<Produto> ListarProdutos()
        {
           using var connection = new SQLiteConnection(_connectionString);
            return connection.GetAll<Produto>().ToList();

        }
        public Produto BuscarProduto(int id)
        {
            using var connection = new SQLiteConnection(_connectionString);
            return connection.Get<Produto>(id);
        }
        public void Editar(Produto produto)
        {
            using var connection = new SQLiteConnection(_connectionString);
            connection.Update<Produto>(produto);
        }
        public void Delete(int id)
        {
            using var connection = new SQLiteConnection(_connectionString);
            Produto novoProduto = BuscarProduto(id);
            connection.Delete<Produto>(novoProduto);
        }




    }
}
