using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletLibrary;
namespace UnitTestMC
{
    [TestClass]
    public class UnitTestMCMetoder
    {
        [TestMethod]
        public void TestMethodPris()
        {
            //arrange
            MC nyMC = new MC();

            //act
            decimal pris = nyMC.Pris();

            //assert
            Assert.AreEqual(125, pris);
        }

        [TestMethod]
        public void TestMethodK�ret�j()
        {
            //arrange
            MC nyMC = new MC();

            //act
            string navn = nyMC.K�ret�j();

            //assert
            Assert.AreEqual("MC", navn);
        }
    }
}
