using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojadeRoupa._03_Entidades
{
    public class Estoque
    {
        public int Id { get; set; }
        public string Produto { get; set; }
        public int QuantidadeDisponivel { get; set; }  
    }
}
