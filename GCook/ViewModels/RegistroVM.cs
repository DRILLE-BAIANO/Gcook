using System.ComponentModel.DataAnnotations;
using System.Runtime.ConstrainedExecution;

namespace GCook.ViewModels;

public class RegistroVM
{
    [Display(Name = "Nome Completo", Prompt = "Informe seu Nome Completo")]
    [Required(ErrorMessage = "Por favor, informe seu Nome")]
    [StringLength(60, ErrorMessage = "O Nome deve possuir no máximo 60 caracteres")]
    public string Nome { get; set; }

    [DataType(DataType.Date)]
    [Display(Name = "Data de Nascimento", Prompt = "Informe sua Data de Nascimento")]
    [Required(ErrorMessage = "Por favor, informe sua Data de Nascimento")]
    public DateTime? DataNascimento { get; set; } = null;

    [Display(Prompt = "Informe seu Email")]
    [Required(ErrorMessage = "Por favor, informe seu Email")]
    [EmailAddress(ErrorMessage = "Por favor, informe um Email Válido!")]
    [StringLength(100, ErrorMessage = "O Emal deve possuir no máximo 100 caracteres")]
    public string Email { get; set; }

    [DataType(DataType.Password)]
    [Display(Name = "Senha de Acesso", Prompt = "Comfirme sua Senha de Acesso")]
    [Required(ErrorMessage = "Por favor, informe sua Senha de acesso")]
    [StringLength(20, MinimumLength = 6, ErrorMessage = "A Senha deve conter no minimo 6 e no máximo 20 caracteres")]
    public string Senha { get; set; }

    [DataType(DataType.Password)]
    [Display(Name = "Comfirmar Senha de Acesso", Prompt = "comfirme sua Senha de Acesso")]
    [Compare("Senha", ErrorMessage = "As Senhas não Comferem.")]
    public string ConfirmacaoSenha { get; set; }

    public IFormFile Foto { get; set; }

    public bool Termos { get; set; } = false;

    public bool Enviado { get; set; } = false;
}