using System.ComponentModel.DataAnnotations;

namespace BoraIlkProje2.ViewModels
{
    public class ForgetPasswordVM
    {
        [Required(ErrorMessage = "Email adresi gereklidir.")]
        [Display(Name = "Email Adresiniz")]
        [EmailAddress(ErrorMessage = "Email adresiniz doğru formatta değil")]//email
        public string Email { get; set; }

    }
}
