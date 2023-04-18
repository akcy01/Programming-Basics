using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPrograming.Polymorphism
{
    public class Program
    {
        static void Main(string[] args)
        {
            A A = new B();  //İşte polimorfizm budur kalıtım alan sınıfı ata sınıftan çıkartabiliyoruz.
            B B = new C();
        }
    }
}
