using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPrograming.VirtualStructures
{
    public class Terlik : Obje
    {
        public override void Bilgi() //Bilgi metodu virtual olmasaydı override yazamazdık !! Override sayesinde metodun davranışını değiştik
        {
            Console.WriteLine("Ben bir terliğim");
        }
    }
}
