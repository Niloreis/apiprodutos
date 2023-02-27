using System.ComponentModel.DataAnnotations;

namespace ApiProdutos.Services.Models
{
    public class CategoriasPutModel
    {
        [Required(ErrorMessage ="POr favor informe o id da categotia ")]
        public Guid id { get; set; }
        [MinLength(6, ErrorMessage = "Informe no mínimo {1} caracteres.")]
        [MaxLength(50, ErrorMessage = "Informe no máximo {1} caracteres.")]
        public string? Nome { get; set; }
        [MinLength(6, ErrorMessage = "Informe no mínimo {1} caracteres.")]
        [MaxLength(150, ErrorMessage = "Informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor informe a dencreição da categoria.")]
        public string? Descricao { get; set; }
    }
}

