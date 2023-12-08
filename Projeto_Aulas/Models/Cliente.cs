using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Models
{
    [Table("Cliente")]

    public class Cliente
    {
        [Key]

        public int ClientesID {get; set;}
        public string? Nome {get; set;}
        public DateTime? DataNascimento {get; set;}
        public String? Email {get; set;}
        public int?Cep {get; set;}
        public String? Rua {get; set;}
        public String? Bairro {get; set;}
        public String? Cidade {get; set;}
        public String? Estado {get; set;}
        public String? Numero {get; set;}
        public String? Complemento {get; set;}
        public String? Senha {get; set;}
    }
}