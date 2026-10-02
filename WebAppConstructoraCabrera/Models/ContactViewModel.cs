using System.ComponentModel.DataAnnotations;

namespace WebAppConstructoraCabrera.Models
{
    public class ContactViewModel
    {
        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [Display(Name = "Nombre")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "El correo es obligatorio.")]
        [EmailAddress(ErrorMessage = "Ingresa un correo válido.")]
        [Display(Name = "Correo")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "El asunto es obligatorio.")]
        [Display(Name = "Asunto")]
        public string Subject { get; set; } = string.Empty;

        [Required(ErrorMessage = "El mensaje es obligatorio.")]
        [Display(Name = "Mensaje")]
        public string Message { get; set; } = string.Empty;
    }
}
