using System;
using System.Collections.Generic;
using System.Text;

namespace TZERC.Inrf
{
    public interface ISumYslForNonChet
    {
        public double SumNonDataGVS(double x, double y);
        public double SumNonDataXVS(double x, double y);
        public double SumNonDataELdat(double x, double y);
        public double SumNonDataGVSPod(double x, double y);
        public double SumNonDataNag(double x, double y);
    }
}
