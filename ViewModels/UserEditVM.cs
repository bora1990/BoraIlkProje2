using System.ComponentModel.DataAnnotations;

namespace BoraIlkProje2.ViewModels
{
    public class UserEditVM
    {

        [Required(ErrorMessage = "Kullanıcı ismi gereklidir.")]
        [Display(Name = "Kullanıcı Adı")]
        public string UserName { get; set; } = null!;

        [Display(Name = "Tel No:")]
        [Required(ErrorMessage = "Telefon alanı boş bırakılamaz.")]
        public string? PhoneNumber { get; set; } = null!;

        [Required(ErrorMessage = "Email adresi gereklidir.")]
        [Display(Name = "Email Adresiniz")]
        [EmailAddress(ErrorMessage = "Email adresiniz doğru formatta değil")]//email
        public string Email { get; set; }


    }
}
