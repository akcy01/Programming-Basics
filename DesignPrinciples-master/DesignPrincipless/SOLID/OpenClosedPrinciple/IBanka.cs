﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrincipless.SOLID.OpenClosedPrinciple
{
    public interface IBanka
    {
        bool ParaTransferi(int tutar, string hesapNo);
    }
}
