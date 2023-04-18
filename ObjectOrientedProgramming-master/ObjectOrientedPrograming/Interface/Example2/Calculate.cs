using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPrograming.Interface.Example2
{
    public class Calculate : Bol, Cikar, Topla
    {
        public void BolmeIslemi(int numberOne, int numberTwo)
        {
            Console.WriteLine(numberOne / numberTwo);
        }

        public void CikarmaIslemi(int numberOne, int numberTwo)
        {
            Console.WriteLine(numberOne - numberTwo);
        }

        public void ToplamaIslemi(int numberOne, int numberTwo)
        {
            Console.WriteLine(numberOne + numberTwo);
        }

    }
}
