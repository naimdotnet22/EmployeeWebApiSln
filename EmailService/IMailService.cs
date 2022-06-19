using System.Threading.Tasks;

namespace EmailService
{
    public interface IMailService
    {
        Task SendEmailAsync(MailRequest mailRequest);
    }
}
