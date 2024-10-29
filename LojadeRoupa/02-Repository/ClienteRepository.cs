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
    public class ClienteRepository : IClienteRepository
    {
        public readonly string _connectionString;
        public ClienteRepository(string connection)
        {
            _connectionString = connection;
        }
        public void AdicionarCliente(Cliente cliente)
        {
            using var connection = new SQLiteConnection(_connectionString);
            connection.Insert<Cliente>(cliente);
        }
        public List<Cliente> ListarCliente()
        {
            using var connection = new SQLiteConnection(_connectionString);
            return connection.GetAll<Cliente>().ToList();

        }
        public Cliente BuscarCliente(int id)
        {
            using var connection = new SQLiteConnection(_connectionString);
            return connection.Get<Cliente>(id);
        }
        public void EditarCliente(Cliente cliente)
        {
            using var connection = new SQLiteConnection(_connectionString);
            connection.Update<Cliente>(cliente);
        }
        public void Delete(int id)
        {
            using var connection = new SQLiteConnection(_connectionString);
            Cliente novocliente = BuscarCliente(id);
            connection.Delete<Cliente>(novocliente);
        }
    }
}
