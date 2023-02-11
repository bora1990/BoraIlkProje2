using Microsoft.AspNetCore.Identity;

namespace BoraIlkProje2.CustomValidation
{
    public class CustonTurkishValidation : IdentityErrorDescriber
    {
        public override IdentityError InvalidUserName(string userName)
        {
            return new IdentityError()
            {
                Code = "InvalidUserName",
                Description = $"Bu {userName} geçersizdir."


            };


        }
        public override IdentityError DuplicateEmail(string email)
        {
            return new IdentityError()
            {
                Code = "InvalidUserName",
                Description = $"Bu {email} geçersizdir."

            };


        }

    }
}
