using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPrograming.Inheritance
{
    public class Accountant : Employee
    {
        public bool Musavir { get; set; } //Bu sadece müşavir'e özel..

        //Employee'nin ortak özellikleri gelecek!
    }
}
