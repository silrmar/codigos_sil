using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tasca3p.Models
{
    [Table("Categorias")]
    public class Categorias
    {
        [Key]
        public int CategoriaId { get; set; }

        [Required(ErrorMessage = "Insira o nome da categoria")]
        [Display(Name = "Nome da categoria")]
        [StringLength(50, ErrorMessage ="Tamanho máximo de 50 carateres")]
        public required string CategoriaNome { get; set; }

        [Required(ErrorMessage = "Insira A descrição da categoria")]
        [Display(Name = "Descrição da categoria")]
        [MinLength(20, ErrorMessage = "A descrição deve ter no mínimo 1 caráter")]
        [MaxLength(200, ErrorMessage = "A descrição deve ter no máximo 100 carateres")]
        public required string Descricao { get; set; }

        //Relacionar com a classe Lanches ( uma categoria  para vários lanches)
        public List<Lanches>? Lanches { get; set; }
    }
}
