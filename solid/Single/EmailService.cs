using System.Net.Mail;

namespace SolidPrinciples;

public class EmailService
{
    SmtpClient _smtpClient;

    public EmailService(SmtpClient smtpClient)
    {
        _smtpClient = smtpClient;
    }

    public virtual bool ValidateEmail(string email)
    {
        return email.Contains("@");
    }

    public async Task<bool> SendEmail(MailMessage mailMessage)
    {
        await _smtpClient.SendMailAsync(mailMessage);
        return true;
    }
}