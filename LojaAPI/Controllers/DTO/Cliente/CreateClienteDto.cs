﻿namespace LojaAPI.Controllers.DTO.Cliente
{
    public class CreateClienteDto
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public int Telefone { get; set; }
    }
}
