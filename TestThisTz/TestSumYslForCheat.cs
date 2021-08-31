using Microsoft.VisualStudio.TestTools.UnitTesting;
using TZERC;
using TZERC.InterfaceClass;

namespace TestThisTz
{
    [TestClass]
    public class TestSumYslForCheat
    {
        [TestMethod]
        public void SumGvsIn_5a5_5a7_5Return_1a4()
        {
            // Arrange 
            double a = 5.5;
            double b = 5.7;
            double c = 7;
            double Exp = 1.4;
            //Act
            SumYslForChet v = new SumYslForChet();
            double Data = v.SumGvs(a, b, c);
            //Assert
            Assert.AreEqual(Exp, Data, 0.002);
        }
        [TestMethod]
        public void SumXvs_5a5_5a7_5Return_1a4()
        {
            // Arrange 
            double a = 5.5;
            double b = 5.7;
            double c = 7;
            double Exp = 1.4;
            //Act
            SumYslForChet v = new SumYslForChet();
            double Data = v.SumXvs(a, b, c);
            //Assert
            Assert.AreEqual(Exp, Data, 0.002);
        }
        [TestMethod]
        public void SumElD_5a5_5a7_5Return_1a4()
        {
            double a = 5.5;
            double b = 5.7;
            double c = 7;
            double Exp = 1.4;
            //Act
            SumYslForChet v = new SumYslForChet();
            double Data = v.SumElD(a, b, c);
            //Assert
            Assert.AreEqual(Exp, Data, 0.002);
        }
        [TestMethod]
        public void SumElN_5a5_5a7_5Return_1a4()
        {
            double a = 5.5;
            double b = 5.7;
            double c = 7;
            double Exp = 1.4;
            //Act
            SumYslForChet v = new SumYslForChet();
            double Data = v.SumElN(a, b, c);
            //Assert
            Assert.AreEqual(Exp, Data, 0.002);
        }
        [TestMethod]
        public void SumPod_5a5_5a7_5Return_1a4()
        {
            double a = 5.5;
            double b = 5.7;
            double c = 7;
            double Exp = 1.4;
            //Act
            SumYslForChet v = new SumYslForChet();
            double Data = v.SumPod(a, b, c);
            //Assert
            Assert.AreEqual(Exp, Data, 0.002);
        }
        [TestMethod]
        public void SumNag_5a5_5a7_5Return_31a35()
        {
            double a = 5.5;
            double b = 5.7;
            double Exp = 31.35;
            //Act
            SumYslForChet v = new SumYslForChet();
            double Data = v.SumNag(a, b);
            //Assert
            Assert.AreEqual(Exp, Data, 0.002);
        }

    }
}
