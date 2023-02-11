using System.ComponentModel.DataAnnotations;

namespace BoraIlkProje2.ViewModels
{
    public class LoginViewModel
    {
        [Display(Name = "Email Adresiniz")]
        [Required(ErrorMessage = "Email Alanı Gereklidir")]
        [EmailAddress]
        public string Email { get; set; }


        [Display(Name = "Şifreniz")]
        [Required(ErrorMessage = "Şifre alanı gereklidir.")]
        [DataType(DataType.Password)]  //görükmesin
        [MinLength(4, ErrorMessage = "şifreniz en az 4 karakter içerebilir")]
        public string Password { get; set; }
    }
}
