using System.ComponentModel.DataAnnotations;

namespace MerceariaMVC.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Idade { get; set; }
        public bool Ativo { get; set; }

        public bool Validacao()
        {
            return Idade >=18 && Email.Contains("@") && !string.IsNullOrWhiteSpace(Nome);

        }

        public bool Permissao()
        {
            return Ativo == true && Idade >= 18;
        }
    }
}

