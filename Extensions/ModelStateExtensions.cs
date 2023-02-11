using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace BoraIlkProje2.Extensions
{
    public static class ModelStateExtensions
    {
        public static void AddModelErrorList(this ModelStateDictionary modelState, IEnumerable<IdentityError> errors)
        {

            errors.ToList().ForEach(x =>
            {
                modelState.AddModelError(string.Empty, x.Description);

            });

        }
    }
}
