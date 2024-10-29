using Dapper.Contrib.Extensions;
using LojadeRoupa._02_Repository.Interface;
using LojadeRoupa._03_Entidades;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojadeRoupa._02_Repository
{
    public class CompraRepository : ICompraRepository
    {
        public readonly string _connectionString;
        public CompraRepository(string connection)
        {
            _connectionString = connection;
        }

        public void AdicionarCompra(Compra compra)
        {
            using var connection = new SQLiteConnection(_connectionString);
            connection.Insert<Compra>(compra);
        }
        public List<Compra> ListarCompras()
        {
            using var connection = new SQLiteConnection(_connectionString);
            return connection.GetAll<Compra>().ToList();
        }
        public Compra BuscarCompra(int id)
        {
            using var connection = new SQLiteConnection(_connectionString);
            return connection.Get<Compra>(id);
        }
        public void EditarCompra(Compra compra)
        {
            using var connection = new SQLiteConnection(_connectionString);
            connection.Update<Compra>(compra);
        }
        public void DeletarCompras(int id)
        {
            using var connection = new SQLiteConnection(_connectionString);
            Compra novacompra = BuscarCompra(id);
            connection.Delete<Compra>(novacompra);
        }
    }
}
