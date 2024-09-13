namespace LojaAPI.Controllers.DTO.Pedido
{
    public class CreatePedidoDto
    {
        public string Cliente { get; set; }
        public DateTime Data { get; set; }
        public string Total { get; set; }
    }
}
