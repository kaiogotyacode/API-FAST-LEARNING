using System.ComponentModel.DataAnnotations;

namespace APIFastLearning.Models
{
    public class Pessoa
    {
        public  int Id{ get; set; }
        public string? Nome { get; set; }
        public int Idade { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

    }
}
