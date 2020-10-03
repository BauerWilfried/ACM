using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //Arrange
            Customer customer = new Customer
            {
                FirstName = "Bilbo",
                LastName = "Baggins"
            };
            string expected = "Baggins, Bilbo";
            //Act
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //Arrange
            Customer customer = new Customer
            {
                LastName = "Baggins"
            };
            string expected = "Baggins";

            //Act
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //Arrange
            Customer customer = new Customer
            {
                FirstName = "Bilbo"
            };
            string expected = "Bilbo";

            //Act
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void StaticTest()
        {
            //Arrange
            var c1 = new Customer
            {
                FirstName = "Anna"
            };
            Customer.InstanceCount += 1;

            var c2 = new Customer
            {
                FirstName = "Max"
            };
            Customer.InstanceCount += 1;

            var c3 = new Customer
            {
                FirstName = "Bob"
            };
            Customer.InstanceCount += 1;

            int expected = 3;

            //Act

            //Assert
            Assert.AreEqual(expected, Customer.InstanceCount);
        }
        [TestMethod]
        public void ValidateValid()
        {
            //Arrange
            var customer = new Customer
            {
                LastName = "Baggins",
                EmailAddress = "fbaggins@gmail.com" 
            };
            bool expected = true;

            //Act
            bool actual = customer.Validate();

            //Assert
            Assert.AreEqual(expected, actual); 
        }
        [TestMethod]
        public void ValidateMissingLastName()
        {
            //Arrange
            var customer = new Customer
            {
                LastName = "Baggins"
            };
            var expected = false;

            //Act
            var actual = customer.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
