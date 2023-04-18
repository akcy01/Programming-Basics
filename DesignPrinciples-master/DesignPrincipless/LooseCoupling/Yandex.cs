using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrincipless.LooseCoupling
{
    public class Yandex : IMailServer
    {
        public void Send(string subject, string body)
        {
            throw new NotImplementedException();
        }
    }
}
