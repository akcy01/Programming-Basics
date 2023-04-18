using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrincipless.SOLID.SingleResponsibilityPrinciple
{
    public class Database
    {
        public void Connect()
        {
            Console.WriteLine("Veritabanı bağlantısı sağlanmıştır");
        }
        public void Disconnect() 
        {
            Console.WriteLine("Veritabanı bağlantısı sonlandırılmıştır");
        }
    }
}
