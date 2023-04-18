using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrincipless.SOLID.OpenClosedPrinciple
{
    public class Garanti : IBanka
    {
        public string HesapNo { get; set; }
        public void ParaGonder(int tutar)
        {
            //...
        }
        public bool ParaTransferi(int tutar, string hesapNo)
        {
            try
            {

                HesapNo = hesapNo;
                ParaGonder(tutar);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
