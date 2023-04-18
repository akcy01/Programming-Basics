using DesignPrincipless.LooseCoupling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* Artık gmaile olan salt bağılılktan ziyade gmail bizim oluşturduğumuz interface vasıtasıyla bize bağımlı hale geliyor ! */
namespace DesignPrincipless.SOLID.DependencyInversion
{
    public class MailService
    {
        public void SendMail(IMailServer mailServer,string to, string body)
        {
            mailServer.Send(to, body);
        }
    }
    interface IMailServer
    {
        void Send(string to, string body);
    }
    class Gmail : IMailServer
    {
        public void Send(string to,string body)
        {
            // send mail
        }
    }
    class Yandex : IMailServer
    {
        public void Send(string to, string body)
        {
            // send mail
        }
    }
}

