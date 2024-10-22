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
        public DateTime DataCompra { get; set; }
        public string ItensComprados { get; set; }
        public int Client { get; set; }
        public int Total { get; set; }
        

    }
}
