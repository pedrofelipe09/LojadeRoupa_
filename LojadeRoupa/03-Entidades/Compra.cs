using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojadeRoupa._03_Entidades
{
    public class Compra
    {
        public int Id { get; set; } 
        public int ClienteId { get; set; }
        public int ProdutoId { get; set; }
        public DateTime DataCompra { get; set; }



    }
}
