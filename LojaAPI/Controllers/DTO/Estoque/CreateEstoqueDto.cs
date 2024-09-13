namespace LojaAPI.Controllers.DTO.Estoque
{
    public class CreateEstoqueDto
    {
        public string Produto { get; set; }
        public int QuantidadeDisponivel { get; set; }
    }
}
