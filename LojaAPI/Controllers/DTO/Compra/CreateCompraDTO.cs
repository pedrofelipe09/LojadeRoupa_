namespace LojaAPI.Controllers.DTO.Compra
{
    public class CreateCompraDTO
    {
        public DateTime DataCompra { get; set; }
        public string ItensComprados { get; set; }
        public int Client { get; set; }
        public int Total { get; set; }
    }
}
