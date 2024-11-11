using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojadeRoupa._02_Repository.Data
{
    public static class Inicializador_bd
    {
        private const string ConnectionString = "Data Source=LojaCRUD.db";

        public static void Inicializar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            string criarTabela = @"CREATE TABLE IF NOT EXISTS Produtos(
                                           Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                           Nome TEXT NOT NULL,
                                           Preco REAL NOT NULL,
                                           Descricao TEXT NOT NULL

                                           );";
            criarTabela += @"CREATE TABLE IF NOT EXISTS Estoques(
                                           Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                           ProdutoId INTEGER NOT NULL,
                                           QuantidadeDisponivel INTEGER NOT NULL
                                         
                                           );";
            criarTabela += @"CREATE TABLE IF NOT EXISTS Clientes(
                                           Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                           Nome TEXT NOT NULL,
                                           Email TEXT NOT NULL,
                                           Endereco TEXT NOT NULL,
                                           Telefone TEXT NOT NULL
                                           );";
            
            criarTabela += @"CREATE TABLE IF NOT EXISTS Compras(
                                           Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                           ProdutoId INTEGER NOT NULL,
                                           ClienteId INTEGER NOT NULL,
                                           DataCompra DATETIME NOT NULL

                                            );";
            criarTabela += @"CREATE TABLE IF NOT EXISTS Enderecos(
                                           Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                           Estado TEXT NOT NULL,
                                           Cidade TEXT NOT NULL,
                                           Bairro TEXT NOT NULL,
                                           Rua TEXT NOT NULL,
                                           Numero INTEGER NOT NULL

                                            );";



            connection.Execute(criarTabela);

            


        }



    }
}
