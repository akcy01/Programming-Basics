using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrincipless.SOLID.LiskovSubstitutionPrinciple
{
    abstract class Cloud
    {
        public abstract void MachineLearning();
    }
    interface ITranslatable
    {
        void Translate();
    }
    class AWS : Cloud, ITranslatable
    {
        public void Translate()
            => Console.WriteLine("AWS Translate");
        public override void MachineLearning()
        {
            Console.WriteLine("AWS machineLearning");
        }
    }
    class Azure : Cloud
    {
        public override void MachineLearning()
        {
            Console.WriteLine("Azure MachineLearning");
        }
    }
    class Google : Cloud, ITranslatable
    {
        public void Translate()
            => Console.WriteLine("Google Translate");
        public override void MachineLearning()
        {
            Console.WriteLine("Google machineLearning");
        }
    }
}
