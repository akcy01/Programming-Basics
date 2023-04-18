using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrincipless.SOLID.InterfaceSegregation
{
    interface IPrinter
    {
        void Print();
        void Scan();
        void Fax();
        void PrintDuplex();
    }
    class HPPrinter : IPrinter
    {
        public void Fax()
        {
            //fax işlemleri
        }

        public void Print()
        {
            //print işlemleri
        }

        public void PrintDuplex()
        {
            //printduplex işlemleri
        }

        public void Scan()
        {
            //scan işlemleri
        }
    }
    class SamsungPrinter : IPrinter
    {
        public void Fax()
        {
            //fax işlemleri
        }

        public void Print()
        {
            //print işlemleri
        }

        public void PrintDuplex()
        {
            throw new NotImplementedException(); //Exception fırlatanlar kullanılamıyor demek.
        }

        public void Scan()
        {
            throw new NotImplementedException();
        }
    }
    class LexmarkPrinter : IPrinter
    {
        public void Fax()
        {
            //fax işlemleri
        }

        public void Print()
        {
            //print işlemleri
        }

        public void PrintDuplex()
        {
            throw new NotImplementedException();
        }

        public void Scan()
        {
            throw new NotImplementedException();
        }
    }
}
