namespace LojaAPI.Controllers.DTO.Produto
{
    public class CreateProdutoDto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public string Descricao { get; set; }
        public double Tamanho { get; set; }
        public string Cor { get; set; }
        public string Categoria { get; set; }

    }
}
