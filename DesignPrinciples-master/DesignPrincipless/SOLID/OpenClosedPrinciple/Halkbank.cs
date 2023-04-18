using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrincipless.SOLID.OpenClosedPrinciple
{
    public class Halkbank : IBanka
    {
        string _hesapNo;
        public void GonderilecekHesapNo(string hesapNo)
        {
            //...
        }
        public void Gonder(int tutar)
        {
            //...
        }
        public bool ParaTransferi(int tutar, string hesapNo)
        {
            try
            {
                GonderilecekHesapNo(hesapNo);
                Gonder(tutar);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
