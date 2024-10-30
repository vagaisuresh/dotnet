using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace SolidPrinciples;

public class UserService
{
    EmailService _emailService;

    public UserService(EmailService emailService)
    {
        _emailService = emailService;
    }

    public async void Register(string email, string password)
    {
        if (!_emailService.ValidateEmail(email))
            throw new ValidationException("Email is not valid address.");
        
        // Add user logic
        //var user = new User(email, password);
         
        await _emailService.SendEmail(new MailMessage("test@test.com", email) { Subject = "Test message"});
    }
}