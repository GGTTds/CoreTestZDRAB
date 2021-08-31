using System;
using System.Collections.Generic;
using System.Text;

namespace TZERC.InterfaceClass
{
    public class SumYslForChet : Inrf.ISumYslForChet
    {
        public double SumGvs(double a, double b, double c)
        {
            return (b - a) * c ;
        }
        public double SumXvs(double a, double b, double c)
        {
            return (b - a) * c;
        }
        public double SumElD(double a, double b, double c)
        {
            return (b - a) * c;
        }
        public double SumElN(double a, double b, double c)
        {
            return (b - a) * c;
        }
        public double SumPod(double a, double b, double c)
        {
            return (b - a) * c;
        }
        public double SumNag(double a, double b)
        {
            return b * b;
        }
    }
}
