using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OluwatorotiElegbede_s00169435;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Checking_IncreasePrice()
        {
            //ARRANGE
            Phone target = new Phone();
            target.Price = 500;
            double percentage = 10;
            double expected = 550;

            //ACT
            target.IncreasePrice(percentage);

            //ASSERT
            Assert.AreEqual(expected, target.Price);
        }
    }
}
