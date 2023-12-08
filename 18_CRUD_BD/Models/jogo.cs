using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace _18_CRUD_BD.Models
{
    [Table("Jogos")]
    public class Jogo
    {
      public int JogoId { get; set; }
      [Required(ErrorMessage="Nome é obrigatório")]
      [Display(Name="Nome do jogo")]
      public string Nome { get; set; }
      public string Descricao{ get; set; }
      public string imagem{ get; set; }
      public string ativo{ get; set; }
    }
}