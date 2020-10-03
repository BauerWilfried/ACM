using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepoTest
    {
        [TestMethod]
        public void ValidRetrieve()
        {
            //Arrange
            var productRepository = new ProductRepository();
            
            var product = new Product()
            {
                ProductName = "Ring",
                Description = "the one ring",
                CurrentPrice = (decimal)12.3,
            };
            var expected = product;

            //Act
            var actual = productRepository.Retrieve(1);

            //Assert
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.Description, actual.Description);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
        }
        [TestMethod]
        public void SaveTestValid()
        {
            //Arrange
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                ProductName = "Ring",
                Description = "the one ring",
                CurrentPrice = (decimal)12.3,
                HasChanges = true
            };

            //Act
            var actual = productRepository.Save(updatedProduct);

            //Assert
            Assert.AreEqual(true, actual);
        }
        [TestMethod]
        public void SaveTestMissingPrice()
        {
            //Arrange
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                ProductName = "Ring",
                Description = "the one ring",
                CurrentPrice = null,
                HasChanges = true,
            };

            //Act
            var actual = productRepository.Save(updatedProduct);

            //Assert
            Assert.AreEqual(false, actual);
        }
    }
}
