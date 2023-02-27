namespace ApiProdutos.Services.Models
{
    public class ProdutosGetModel
    {
        public Guid IdProduto { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public decimal? preco { get; set;}
        public int? Quantidade { get; set;}
        public DateTime? DataHoraCadastro { get; set;}
        /// <summary>
        /// Dados da categoria do produto
        /// </summary>
        public CategoriaGetModel? Categoria { get; set;}
    }
}
