namespace LojaAPI.Controllers.DTO.Compra
{
    public class CreateCompraDTO
    {
        public int ClienteId { get; set; }
        public int ProdutoId { get; set; }
        public DateTime DataCompra { get; set; }
    }
}
