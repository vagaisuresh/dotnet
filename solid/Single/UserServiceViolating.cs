using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace SolidPrinciples;

public class UserServiceViolating
{
    public void Register(string email, string password)
    {
        if (!ValidateEmail(email))
            throw new ValidationException("Email is not a valid address.");
        
        // Add user logic
        //var user = new User(email, password);
        SendEmail(new MailMessage("mysite@nowhere.com", email) { Subject="HEllo foo" });
    }

    public virtual bool ValidateEmail(string email)
    {
        return email.Contains("@");
    }

    public bool SendEmail(MailMessage mailMessage)
    {
        return true;
    }
}