using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPrograming.Interface.Example
{
    public class Calculate : Operation
    {
        public int Carp(int numberOne, int numberTwo)
        {
            return numberOne * numberTwo;
        }

        public void Divide(int numberOne, int numberTwo)
        {
            Console.WriteLine(numberOne / numberTwo);
        }

        public int Sum(int numberOne, int numberTwo)
        {
            return numberOne + numberTwo;
        }
    }
}
