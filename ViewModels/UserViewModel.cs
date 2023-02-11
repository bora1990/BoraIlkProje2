using System.ComponentModel.DataAnnotations;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace Identtity2.Models.ViewModels //Burda yazılan attributelarla client tabanlı doğrulama yapmak için jquery obs vs eklenmeli
{
    public class UserViewModel  //kullanıcının kaydolma işlemini gerçekleştiricek
    {
        [Required(ErrorMessage = "Kullanıcı ismi gereklidir.")]
        [Display(Name = "Kullanıcı Adı")]
        public string UserName { get; set; }

        [Display(Name = "Tel No:")]
        public string? PhoneNumber { get; set; }

        [Required(ErrorMessage = "Email adresi gereklidir.")]
        [Display(Name = "Email Adresiniz")]
        [EmailAddress(ErrorMessage = "Email adresiniz doğru formatta değil")]//email
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifreniz Gereklidir")]
        [Display(Name = "Şifre")]
        [DataType(DataType.Password)]   //tipi password olcağını anlıcak enum
        public string Password { get; set; }

    }
}