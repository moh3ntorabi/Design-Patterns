using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Uml
{
    public class SendEmail
    {
        public void send()
        {
            Console.WriteLine("Email send....");
        }

    }
    public class EmailDecorator : SendEmail
    {
        private readonly SendEmail _sendEmail;
        public EmailDecorator(SendEmail sendEmail)
        {
            _sendEmail = sendEmail;
        }
        public void Send()
        {
            _sendEmail.send();
            SaveLog();
        }
        private void SaveLog()
        {
            Console.WriteLine("SaveLog....");
        }
    }
}
