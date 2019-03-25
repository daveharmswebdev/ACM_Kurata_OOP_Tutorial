using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductTest
    {
        [TestMethod]
        public void ValidateValid()
        {
            // arrange
            var product = new Product
            {
                ProductName = "Widget",
                Description = "this is a great widget",
                CurrentPrice = 1.00M
            };
            var expected = true;

            // act
            var actual = product.Validate();

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Validate_InValid_NoProductName()
        {
            // arrange
            var product = new Product
            {
                Description = "this is a great widget",
                CurrentPrice = 1.00M
            };
            var expected = false;

            // act
            var actual = product.Validate();

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Validate_InValid_NoDescription()
        {
            // arrange
            var product = new Product
            {
                ProductName = "Widget",
                CurrentPrice = 1.00M
            };
            var expected = false;

            // act
            var actual = product.Validate();

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Validate_InValid_NoCurrentPrice()
        {
            // arrange
            var product = new Product
            {
                ProductName = "Widget",
                Description = "this is a great widget"
            };
            var expected = false;

            // act
            var actual = product.Validate();

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
