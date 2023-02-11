using System.ComponentModel.DataAnnotations;

namespace BoraIlkProje2.ViewModels
{
    public class RoleVM
    {

        [Display(Name = "Role ismi")]
        [Required(ErrorMessage = "Role ismi gereklidir")]
        public string Name { get; set; } = null!;

        public int Id { get; set; }  //bu roldeki id ye ulaşmak,güncellemek için bir id ye ihtiyaç vardır


    }
}

