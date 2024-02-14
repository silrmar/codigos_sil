using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tasca3p.Models
{
    [Table("Lanches")]
    public class Lanches
    {
        [Key]
        public int LancheId { get; set; }

        [Required (ErrorMessage ="Insira o nome do lanche")]
        [Display(Name ="Nome do lanche")]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "O {0} deve ter no mínimo {1} e no máximo {2} carateres")]
        public required string Nome { get; set; }

        [Required(ErrorMessage = "Insira A descrição do lanche")]
        [Display(Name = "Descrição do lanche")]
        [MinLength(20, ErrorMessage ="A descrição deve ter no mínimo 1 caráter")]
        [MaxLength(200, ErrorMessage = "A descrição deve ter no máximo 200 carateres")]
        public required string DescricaoCurta { get; set; }

        [Required(ErrorMessage = "Insira a  descrição detalhada do lanche")]
        [Display(Name = "Descrição detalhada do Lanche")]
        [MinLength(20, ErrorMessage = "Descrição detalhada deve ter no mínimo {1} caráter")]
        [MaxLength(200, ErrorMessage = "Descrição detalhada pode exceder {1} carateres")]
        public required string DescricaoDetalhada { get; set; }

        [Required(ErrorMessage = "Insira o preço do lanche")]
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1, 99.99, ErrorMessage = "O preço deve estar entre 1 e 99,99")]
        public decimal Preco { get; set; }

        [Display(Name = "Caminho da Imagem do produto")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} carateres")]
        public required string ImagemUrl { get; set; }

        [Display(Name = "Caminho da Imagem - Miniatura")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} carateres")]
        public string? ImagemThumbnailUrl { get; set; }

        [Display(Name = "Preferido?")]
        public bool IsLanchePreferido { get; set; }

        [Display(Name = "stock")]
        public bool EmStock { get; set; }

        //relacionar com a classe categorias
        public  int CategoriaId { get; set; }
        public virtual Categorias? Categorias { get; set; }

    }
}
