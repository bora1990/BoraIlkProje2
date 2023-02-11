using System.ComponentModel.DataAnnotations;

namespace BoraIlkProje2.ViewModels
{
    public class ResetPasswordVM
    {
        [Required(ErrorMessage = "Eski şifrenizi giriniz")]
        [Display(Name = "Eski Şifreniz:")]
        [DataType(DataType.Password)]

        public string PasswordOld { get; set; } = null!;

        [Required(ErrorMessage = "Yeni Şifreniz Gereklidir")]
        [Display(Name = "Yeni Şifre :")]
        [DataType(DataType.Password)]   //tipi password olcağını anlıcak enum
        [MinLength(6, ErrorMessage = "Şifreniz en az 6 karakterli olmalıdır.")]
        public string Password { get; set; } = null!;

        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "Şifre aynı değildir.")]
        [Required(ErrorMessage = "Şifre tekrar alanı boş bırakılamaz")]
        [Display(Name = "Yeni Şifre Tekrar: ")]
        public string PasswordConfirm { get; set; } = null!;



    }
}
