using System.ComponentModel.DataAnnotations;

namespace GestaoPessoal.Data.Models
{
    public class Pessoa
    {
        public int Id { get; set; }

        [Required]
        public string? NomeCompleto { get; set; }

        [Required]
        public DateTime DataNascimento { get; set; }

        [Required]
        public string? CPF { get; set; }

   

        public string? Rua { get; set; }

 

        public int? Numero { get; set; }

        public string? Logradouro { get; set; }

      
        public string? Cidade { get; set; }

        
        public string? Estado { get; set; }

        
        public string? CEP { get; set; }

        
        public string? Telefone { get; set; }

        [EmailAddress]
        public string? Email { get; set; }

        
    }
}
