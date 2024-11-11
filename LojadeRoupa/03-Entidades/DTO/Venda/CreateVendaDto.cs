using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojadeRoupa._03_Entidades.DTO.Venda
{
    public class CreateVendaDto
    {
        public int ClienteId { get; set; }
        public int CompraId { get; set; }
        public int EnderecoId { get; set; }
        public int Total { get; set; }
    }
}
