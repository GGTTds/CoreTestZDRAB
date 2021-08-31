using Microsoft.VisualStudio.TestTools.UnitTesting;
using TZERC;
using TZERC.InterfaceClass;

namespace TestThisTz
{
    [TestClass]
    public class TestEmlVal
    {
        [TestMethod]
        public void InStringVal_ReturnTrue()
        {
            // Arrange 
            string TestEmalExp = "Email@gmail.com";
            //Act
            EmlVal v = new EmlVal();
            bool IsEmlTry = v.IsValidEmail(TestEmalExp);
            //Assert
            Assert.IsTrue(IsEmlTry);
        }
    }
}
