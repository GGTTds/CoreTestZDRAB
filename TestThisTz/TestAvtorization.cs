using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using TZERC;
using TZERC.InterfaceClass;
namespace TestThisTz
{
    [TestClass]

    public class TestAvtorization
    {
        [TestClass]
        public class TestLogginAsync_ReturnTrue
        {
            [TestMethod]
            public async Task LoginAsync_ReturnTrue()
            {
                //Act
                string s = "test";
                string s1 = "test";
                Avtorization _TestClass = new Avtorization();
                bool IsTrueAddnewUser = await _TestClass.LoginInAsync(s, s1);
                //Assert
                Assert.IsTrue(IsTrueAddnewUser);
            }
            
        }
    }
}