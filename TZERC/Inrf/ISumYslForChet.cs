using System;
using System.Collections.Generic;
using System.Text;

namespace TZERC.Inrf
{
    public interface ISumYslForChet
    {
        public double SumGvs(double a, double b, double c);
        public double SumXvs(double a, double b,double c);
        public double SumElD(double a, double b, double c);
        public double SumElN(double a, double b, double c);
        public double SumPod(double a, double b, double c);
        public double SumNag(double a, double b);
    }
}
