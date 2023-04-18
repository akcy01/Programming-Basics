using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrincipless.SOLID.InterfaceSegregation
{
    interface IPrint
    {
        void Print();
    }
    interface IScan
    {
        void Scan();
    }
    interface IFax
    {
        void Fax();
    }
    interface IPrintDuplex
    {
        void PrintDuplex();
    }
    class HPPrinter : IPrint, IScan, IFax, IPrintDuplex
    {
        public void Print();
        public void Scan();
        public void Fax();
        public void PrintDuplex();
    }
    class SamsungPrinter : IPrint, IFax
    {
        public void Print();
        public void Fax();
    }
    class LexmarkPrinter : IFax, IPrint, IScan
    {
        public void Fax();
        public void Print();
        public void Scan();
    }
}
