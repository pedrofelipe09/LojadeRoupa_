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
    public class VendaRepository:IVendaRepository
    {
        public readonly string _connectionString;
        public VendaRepository(string connection)
        {
            _connectionString = connection;
        }
        public void AdicionarVenda(Venda venda)
        {
            using var connection = new SQLiteConnection(_connectionString);
            connection.Insert<Venda>(venda);
        }
        public List<Venda> ListarVenda()
        {
            using var connection = new SQLiteConnection(_connectionString);
            return connection.GetAll<Venda>().ToList();

        }
        public Venda BuscarVenda(int id)
        {
            using var connection = new SQLiteConnection(_connectionString);
            return connection.Get<Venda>(id);
        }
        public void EditarVenda(Venda venda)
        {
            using var connection = new SQLiteConnection(_connectionString);
            connection.Update<Venda>(venda);
        }
        public void DeleteVenda(int id)
        {
            using var connection = new SQLiteConnection(_connectionString);
            Venda novaVenda = BuscarVenda(id);
            connection.Delete<Venda>(novaVenda);
        }
    }
}
