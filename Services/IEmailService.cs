namespace BoraIlkProje2.Services
{
    public interface IEmailService
    {
        Task SendResetPasswordEmail(string resetPasswordEmailLink, string ToEmail);
    }
}
