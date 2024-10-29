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
            using var connection = new SQLiteConnection("Data Source=LojaCrud.db");
            string criarTabela = @"CREATE TABLE IF NOT EXISTS Produtos(
                                           Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                           Nome TEXT NOT NULL,
                                           Preco REAL NOT NULL,
                                           Descricao TEXT,
                                           Tamanho REAL,
                                           Cor TEXT,
                                           Categoria TEXT
                                           );";

            criarTabela += @"CREATE TABLE IF NOT EXISTS Categorias(
                                           Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                           Nome TEXT NOT NULL,
                                           Descricao TEXT
                                         
                                           );";
            criarTabela += @"CREATE TABLE IF NOT EXISTS Estoques(
                                           Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                           Produto TEXT NOT NULL,
                                           QuantidadeDisponivel INTEGER
                                         
                                           );";
            criarTabela = @"CREATE TABLE IF NOT EXISTS Clientes(
                                           Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                           Nome TEXT NOT NULL,
                                           Email TEXT NOT NULL,
                                           Endereco TEXT NOT NULL,
                                           Telefone INTEGER
                                           );";
            criarTabela = @"CREATE TABLE IF NOT EXISTS Pedidos(
                                           Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                           Cliente TEXT NOT NULL,
                                           Data DATETIME NOT NULL,
                                           Total TEXT
                                        
                                           );";
            criarTabela = @"CREATE TABLE IF NOT EXISTS Compras(
                                           Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                           DataCompra DATETIME NOT NULL,
                                           ItensComprados TEXT,
                                           Client INTEGER,
                                           Total TEXT
                                        
                                           );";

            connection.Execute(criarTabela);

            


        }



    }
}
