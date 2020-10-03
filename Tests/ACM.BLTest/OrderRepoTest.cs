using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class OrderRepoTest
    {
        [TestMethod]
        public void ValidRetrieve()
        {
            //Arrange
            var orderRepository = new OrderRepository();
            var order = new Order(1)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0))
            };
            var expected = order;

            //Act
            var actual = orderRepository.Retrieve(1);

            //Assert
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);
        }
    }
}
