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
    public class EstoqueRepository
    {
        public readonly string connectionstring;
        public EstoqueRepository(string connection)
        {
            connectionstring = connection;
        }
        public void AdicionarEstoque(Estoque estoque)
        {
            using var connection = new SQLiteConnection(connectionstring);
            connection.Insert<Estoque>(estoque);
        }
        public List<Estoque> ListarEstoque()
        {
            using var connection = new SQLiteConnection(connectionstring);
            return connection.GetAll<Estoque>().ToList();
        }
        public Estoque BuscarEstoque(int id)
        {
            using var connection = new SQLiteConnection(connectionstring);
            return connection.Get<Estoque>(id);
        }
        public void EditarEstoque(Estoque estoque)
        {
            using var connection = new SQLiteConnection(connectionstring);
            connection.Update<Estoque>(estoque);
        }
        public void Delete(int id)
        {
            using var connection = new SQLiteConnection(connectionstring);
            Estoque novoEstoque = BuscarEstoque(id);
            connection.Delete<Estoque>(novoEstoque);
        }
    }
}
