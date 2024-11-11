using Dapper.Contrib.Extensions;
using LojadeRoupa._02_Repository.Interface;
using LojadeRoupa._03_Entidades;
using LojadeRoupa._03_Entidades.DTO.Produto;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojadeRoupa._02_Repository
{
    public class EnderecoRepository : IEnderecoRepository
    {
        public readonly string _connectionString;
        public EnderecoRepository(string connection)
        {
            _connectionString = connection;
        }

        public void AdicionarEndereco(Endereco endereco)
        {
            using var connection = new SQLiteConnection(_connectionString);
            connection.Insert<Endereco>(endereco);
        }
        public List<Endereco> ListarEndereco()
        {
            using var connection = new SQLiteConnection(_connectionString);
            return connection.GetAll<Endereco>().ToList();

        }
        public Endereco BuscarEndereco(int id)
        {
            using var connection = new SQLiteConnection(_connectionString);
            return connection.Get<Endereco>(id);
        }
        public void EditarEndereco(Endereco endereco)
        {
            using var connection = new SQLiteConnection(_connectionString);
            connection.Update<Endereco>(endereco);
        }
        public void DeleteEndereco(int id)
        {
            using var connection = new SQLiteConnection(_connectionString);
            Endereco novoendereco = BuscarEndereco(id);
            connection.Delete<Endereco>(novoendereco);
        }
    }
}
