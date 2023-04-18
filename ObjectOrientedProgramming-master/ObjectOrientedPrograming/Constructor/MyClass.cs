using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPrograming.Constructor
{
    public class MyClass
    {
        public MyClass() 
        {
            Console.WriteLine("Bir adet myClass nesnesi oluşturulmuştur");
        }
        public MyClass(string name)
        {
            Console.WriteLine("2.constructor devreye girdi");
        }
        public MyClass(int a ,int b)
        {
            Console.WriteLine(a + b);
        }
    }
}
