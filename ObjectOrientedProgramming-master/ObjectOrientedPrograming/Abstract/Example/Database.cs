using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
  
/* Interfaceden farklı olarak abstract classlarda metot içerisine kod yazabiliyoruz.Field tanımlayabiliyoruz. */
namespace ObjectOrientedPrograming.Abstract.Example
{
    public abstract class Database
    {
        int sayi3 = 14;
        public void Add()
        {
            Console.WriteLine("Ekleme işlemi yapıldı");
        }
        public abstract void Delete();
    }
}
