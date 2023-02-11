using System.ComponentModel.DataAnnotations;

namespace BoraIlkProje2.ViewModels
{
    public class RoleUpdateVM
    {

        [Required(ErrorMessage = "Role ismi")]
        public string Name { get; set; } = null!;

        public string Id { get; set; }  //bu roldeki id ye ulaşmak,güncellemek için bir id ye ihtiyaç vardır
    }
}
