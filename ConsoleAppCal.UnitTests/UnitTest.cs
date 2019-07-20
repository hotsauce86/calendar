
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleAppCal.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var startday = 2;
            var endday = 4;
            var result =0;

            var check = startday + endday;
            var schedulertest = new scheduler();

            //Act
            result = schedulertest.adder(startday, endday);
            //Assert
            Assert.Equals(result, check);
        }
    }
}
