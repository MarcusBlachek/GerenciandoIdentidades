using System.ComponentModel.DataAnnotations;

namespace GerenciamentoDeIdentidades.ViewModels
{
    //classe com os modelos e configurações PARA o formulário.
    public class ContaCadastrarViewModel
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        [Display(Name ="Nome Completo")]
        public string Nomecompleto { get; set; }
        [Required]
        [EmailAddress]
        public string  Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
    }
}