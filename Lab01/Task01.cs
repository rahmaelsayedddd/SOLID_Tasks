using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    internal class Task01
    {
    }
    public interface IEmailValidator
    {
        bool ValidateEmail(string email);
    }
    public class EmailValidator : IEmailValidator
    {
        public bool ValidateEmail(string email)
        {
            return email.Contains("@");
        }
    }

    public interface IEmailSender
    {
        void SendEmail(MailMessage message);
    }
    public class SmtpEmailSender : IEmailSender
    {
        private SmtpClient _smtpClient;

        public SmtpEmailSender(SmtpClient smtpClient)
        {
            _smtpClient = smtpClient;
        }

        public void SendEmail(MailMessage message)
        {
            _smtpClient.Send(message);
        }
    }

    public class User
    {
        public string Email { get; }
        public string Password { get; }
        public User(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }
    public class UserService
    {
        private IEmailValidator emailValidator;
        private IEmailSender emailSender;

        public UserService(IEmailValidator _emailValidator, IEmailSender _emailSender)
        {
            emailValidator = _emailValidator;
            emailSender = _emailSender;
        }

        public void Register(string email, string password)
        {
            if (!emailValidator.ValidateEmail(email))
                throw new ValidationException("Email is not valid");

            var user = new User(email, password); 

            var message = new MailMessage("mysite@nowhere.com", email)
            {
                Subject = "Hello foo"
            };

            emailSender.SendEmail(message);
        }
    }

}
