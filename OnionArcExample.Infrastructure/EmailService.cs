using OnionArcExample.Application.Interfaces.Services;
using System;


namespace OnionArcExample.Infrastructure
{
    public class EmailService : IEmailService
    {
        public bool Send(string to, string message)
        {
            Console.WriteLine("mail sent");
            return true;
        }
    }
}
