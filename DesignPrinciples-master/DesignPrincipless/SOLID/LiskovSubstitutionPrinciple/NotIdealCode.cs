using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Bu örnekte bakıyoruz AWS'nin ve Google'ın translate hizmeti var ancak azure'nın yok o yüzden throw yaptık.Ama biz cloud dan kalıtım aldığımız için Azure'a Translate fonksiyonunu mecbur kılıyoruz.Azure'da böyle bir işlem yok sen neden bana bunu zorunlu kıldın ? ! İşte Liskov Prensibi bunu söylüyor.*/
namespace DesignPrincipless.SOLID.LiskovSubstitutionPrinciple
{
    abstract class Cloud
    {
        public abstract void Translate();
        public abstract void MachineLearning();
    }
    class AWS : Cloud
    {
        public override void Translate()
            => Console.WriteLine("AWS Translate");
        public override void MachineLearning()
           => Console.WriteLine("AWS Machine Learning");
    }
    class Azure : Cloud
    {
        public override void MachineLearning()
        {
            Console.WriteLine("Azure Machine Learning");
        }
        public override void Translate()
        {
            throw new NotImplementedException();
        }
    }
    class Google : Cloud
    {
        public override void MachineLearning()
        {
            Console.WriteLine("Google Machine Learning");
        }
        public override void Translate()
        {
            Console.WriteLine("Google Translate");
        }
    }
}
