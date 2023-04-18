using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrincipless.LooseCoupling
{
    public interface IMailServer
    {
        void Send(string subject, string body);
    }
}
