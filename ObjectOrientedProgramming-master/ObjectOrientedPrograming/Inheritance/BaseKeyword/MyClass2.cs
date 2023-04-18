using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPrograming.Inheritance.BaseKeyword
{
    public class MyClass2 : MyClass 
    {
        public MyClass2() : base(7)  //Buradaki base sayesinde kalıtım aldığımız sınıfın constructor'ına eriştik!
        {

        }
    }
}
