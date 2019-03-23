using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class OrderTest
    {
        [TestMethod]
        public void ValidateIsValid()
        {
            // arrange
            var orderDate = new DateTime(2019, 7, 7);
            var order = new Order
            {
                OrderDate = new DateTimeOffset(orderDate)
            };
            var expected = true;

            // act
            var actual = order.Validate();

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateInValid()
        {
            // arrange
            var order = new Order();
            var expected = false;

            // act
            var actual = order.Validate();

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
