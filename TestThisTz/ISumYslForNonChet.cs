using Microsoft.VisualStudio.TestTools.UnitTesting;
using TZERC;
using TZERC.InterfaceClass;

namespace TestThisTz
{
    [TestClass]
    public class ISumYslForNonChet
    {
        [TestMethod]
        public void SumNonGvsIn_5a5_5a7Return_31a35()
        {
            // Arrange 
            double a = 5.5;
            double b = 5.7;
            double Exp = 31.35;
            //Act
            SumYslForNonChet v = new SumYslForNonChet();
            double Data = v.SumNonDataGVS(a, b);
            //Assert
            Assert.AreEqual(Exp, Data);
        }
        [TestMethod]
        public void SumNonXvsIn_5a5_5a7Return_31a35()
        {
            // Arrange 
            double a = 5.5;
            double b = 5.7;
            double Exp = 31.35;
            //Act
            SumYslForNonChet v = new SumYslForNonChet();
            double Data = v.SumNonDataXVS(a, b);
            //Assert
            Assert.AreEqual(Exp, Data);
        }
        [TestMethod]
        public void SumNonElcIn_5a5_5a7Return_31a35()
        {
            // Arrange 
            double a = 5.5;
            double b = 5.7;
            double Exp = 31.35;
            //Act
            SumYslForNonChet v = new SumYslForNonChet();
            double Data = v.SumNonDataELdat(a, b);
            //Assert
            Assert.AreEqual(Exp, Data);
        }
        [TestMethod]
        public void SumNonGvsPodIn_5a5_5a7Return_31a35()
        {
            // Arrange 
            double a = 5.5;
            double b = 5.7;
            double Exp = 31.35;
            //Act
            SumYslForNonChet v = new SumYslForNonChet();
            double Data = v.SumNonDataGVSPod(a, b);
            //Assert
            Assert.AreEqual(Exp, Data);
        }
        [TestMethod]
        public void SumNonGvsNagIn_5a5_5a7Return_31a35()
        {
            // Arrange 
            double a = 5.5;
            double b = 5.7;
            double Exp = 31.35;
            //Act
            SumYslForNonChet v = new SumYslForNonChet();
            double Data = v.SumNonDataNag(a, b);
            //Assert
            Assert.AreEqual(Exp, Data);
        }

    }
}

