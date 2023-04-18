using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPrograming.Inheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
            Developer developer= new Developer();
            developer.Name = "Oğuz"; //Kalıtım sayesinde developer sınıfında isim propu oluşturmadan isim atayabildik!!
        }
    }
}
