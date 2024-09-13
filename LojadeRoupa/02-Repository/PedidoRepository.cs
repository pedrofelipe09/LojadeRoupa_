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
    public class PedidoRepository
    {
        public readonly string _connectionString;

        public PedidoRepository(string connection)
        {
            _connectionString = connection;
        }

        public void AdicionarPedido(Pedido pedido)
        {
            using var connection = new SQLiteConnection(_connectionString);
            connection.Insert<Pedido>(pedido);
        }
        public List<Pedido> ListarPedido()
        {
            using var connection = new SQLiteConnection(_connectionString);
            return connection.GetAll<Pedido>().ToList();

        }
        public Pedido BuscarPedido(int id)
        {
            using var connection = new SQLiteConnection(_connectionString);
            return connection.Get<Pedido>(id);
        }
        public void Editar(Pedido pedido)
        {
            using var connection = new SQLiteConnection(_connectionString);
            connection.Update<Pedido>(pedido);
        }
        public void Delete(int id)
        {
            using var connection = new SQLiteConnection(_connectionString);
            Pedido novopedido = BuscarPedido(id);
            connection.Delete<Pedido>(novopedido);
        }

    }
}
