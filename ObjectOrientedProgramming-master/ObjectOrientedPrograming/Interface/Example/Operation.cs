using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPrograming.Interface.Example
{
    public interface Operation
    {
       /* int sayi1 = 14;*/ //Burda hata verir çünkü interfaceler içine field tanımlayamazsın!!
        public int Sum(int numberOne, int numberTwo);
        public int Carp(int numberOne, int numberTwo);
        public void Divide(int numberOne, int numberTwo);  
    }
}
