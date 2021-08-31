using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;
using TZERC;
using TZERC.InterfaceClass;

namespace TestThisTz
{
    [TestClass]
    public class TestPasw
    {
        [TestMethod]
        public void In_6CharAndlowerAndupped_TrueReturn()
        {
            // Arrange
            string ValidPasw = "SDFF16xs";
            int exp = 0;
            // Act
            Pasw fd = new Pasw();
            StringBuilder FG = fd.PasTry(ValidPasw);
            // Assert
            Assert.AreEqual(exp, FG.Length);
        }
    }
}
