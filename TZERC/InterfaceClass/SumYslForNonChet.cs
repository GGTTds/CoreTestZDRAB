using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
namespace TZERC.InterfaceClass
{
    public class SumYslForNonChet : Inrf.ISumYslForNonChet
    {
        public double SumNonDataGVS(double x, double y)
        {
            return (GlobalDat.GlobalData.HowPPLive * x) * y;
        }
        public double SumNonDataXVS(double x, double y)
        {
            return (GlobalDat.GlobalData.HowPPLive * x) * y;
        }
        public double SumNonDataELdat(double x, double y)
        {
            return (GlobalDat.GlobalData.HowPPLive * x) * y;
        }
        public double SumNonDataGVSPod(double x, double y)
        {
            return (GlobalDat.GlobalData.HowPPLive * x) * y;
        }
        public double SumNonDataNag(double x, double y)
        {
            return (GlobalDat.GlobalData.HowPPLive * x) * y;
        }

    }
}
