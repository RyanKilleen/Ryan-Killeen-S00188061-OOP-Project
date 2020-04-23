using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


using Ryan_Killeen_S00188061_OOP_Project;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdding()
        {
            //Arrange
            DriverTest add1 = new DriverTest();
            int FinalPoints = 436;

            //Act
            add1.Adding(436);

            //Assert
            Assert.AreEqual(FinalPoints, add1.Points);

        }
    }
}
