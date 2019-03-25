using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepoTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            // arrange
            var repo = new ProductRepository();
            var expected = new Product(2)
            {
                CurrentPrice = 19.99M,
                Description = "Bacon ipsum dolor amet beef ribs pork loin cow drumstick cupim frankfurter landjaeger pork chop meatball bresaola fatback chuck. Ham tail turkey jerky biltong rump frankfurter shoulder. Beef ribs venison corned beef chuck. Burgdoggen tongue pork loin meatball turducken landjaeger.",
                ProductName = "Sunflowers"
            };

            // act
            var actual = repo.Retrieve(2);

            // assert
            Assert.AreEqual(expected.ProductId, actual.ProductId);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
            Assert.AreEqual(expected.Description, actual.Description);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
        }

        [TestMethod]
        public void SaveTestValid()
        {
            // arrange
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                CurrentPrice = 18M,
                Description = "asdfasdfasdf",
                ProductName = "Sunflowers",
                HasChanges = true
            };

            // act
            var actual = productRepository.Save(updatedProduct);

            // assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void SaveTestInValid()
        {
            // arrange
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                CurrentPrice = null,
                Description = "asdfasdfasdf",
                ProductName = "Sunflowers",
                HasChanges = true
            };

            // act
            var actual = productRepository.Save(updatedProduct);

            // assert
            Assert.AreEqual(false, actual);
        }
    }
}
