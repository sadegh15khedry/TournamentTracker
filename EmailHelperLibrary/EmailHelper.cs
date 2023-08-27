using FluentEmail.Core;
using FluentEmail.Smtp;
using System.Net.Mail;

namespace EmailHelperLibrary;
public static class EmailHelper
{
    public static async Task SendEmailAsync(string senderAddress, string receiverAddress
        , string subject, string emailBody)
    {
        var sender = new SmtpSender(() => new SmtpClient("localHost")
        {
            EnableSsl = false,
            DeliveryMethod = SmtpDeliveryMethod.SpecifiedPickupDirectory,
            PickupDirectoryLocation = @"c:\Demos"
        });

        Email.DefaultSender = sender;

        var email = await Email
            .From(senderAddress)
            .To("akvar@gmail.com")
            .Subject("test")
            .Body("this is an email")
            .SendAsync();
    }
}
