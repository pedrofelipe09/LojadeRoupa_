using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojadeRoupa._03_Entidades
{
    public class Pedido
    {
        public int Id { get; set; }
        public string Cliente { get; set; }
        public DateTime Data { get; set; }
        public string Total { get; set; }

    }
}
