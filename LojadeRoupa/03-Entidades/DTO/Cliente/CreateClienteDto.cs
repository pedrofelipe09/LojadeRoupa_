namespace LojaAPI.Controllers.DTO.Cliente
{
    public class CreateClienteDto
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int EnderecoId { get; set; }
        public string Telefone { get; set; }
    }
}
