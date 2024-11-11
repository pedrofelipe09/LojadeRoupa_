namespace LojaAPI.Controllers.DTO.Compra
{
    public class CreateCompraDTO
    {
        public DateTime DataCompra { get; set; }
        public int ClienteId { get; set; }
        public int ProdutoId { get; set; }
        public int EnderecoId { get; set; }
        public int Total { get; set; }
    }
}
