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
            DeliveryMethod = SmtpDeliveryMethod.Network,
            Port = 25,
            PickupDirectoryLocation = @"c:\Demos"
        });

        Email.DefaultSender = sender;

        var email = await Email
            .From(senderAddress)
            .To(receiverAddress)
            .Subject(subject)
            .Body(emailBody)
            .SendAsync();
    }
}
