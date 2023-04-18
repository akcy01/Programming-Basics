using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPrograming.Object
{
    public class Program
    {
        static void Main(string[] args)
        {
            new MyClass(); //Bu şekilde heap'de bir nesne oluşturdun ama bunun referansı yok.Heap'deki nesneye erişemezsin!

            MyClass oguz = new MyClass();   //oguz isminde bir referans tanımladık.Bunun sayesinde heap'daki nesneye erişebiliriz.
            MyClass sena = new();          //Bu şekilde de nesne oluşturulabilir.


            /* Object Initializer */
            MyClass m = new MyClass()
            {
                MyProperty = 1,
                Name = "a",
            };
        }
    }
}
