using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;
using System.Collections.Generic;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepoTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //Arrange
            var customerRepository = new CustomerRepository();
            var customer = new Customer(1)
            {
                LastName = "Baggins",
                FirstName = "Frodo",
                EmailAddress = "frodo@gmail.com"
            };
            var expected = customer;

            //Act
            var actual = customerRepository.Retrieve(1);

            //Assert
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.CustomerID, actual.CustomerID);
        }
        [TestMethod]
        public void RetrieveValidWithAddress()
        {
            //Arrange
            var customer = new Customer(1)
            {
                LastName = "Baggins",
                FirstName = "Frodo",
                EmailAddress = "frodo@gmail.com",
                AddressList = new List<Address>()
                {
                    new Address()
                    {
                        AddressType = 1,
                        StreetLine1 = "AA",
                        StreetLine2 = "AB",
                        PostalCode = "A1234",
                        City = "AC",
                        State = "AD",
                        Country = "AE",
                    },

                    new Address()
                    {
                        AddressType = 1,
                        StreetLine1 = "BA",
                        StreetLine2 = "BB",
                        PostalCode = "B1234",
                        City = "BC",
                        State = "BD",
                        Country = "BE",
                    }
                }
            };
            var expected = customer;

            //Act
            var customerRepository = new CustomerRepository();
            var actual = customerRepository.Retrieve(1);

            //Assert
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.CustomerID, actual.CustomerID);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.AreEqual(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.AreEqual(expected.AddressList[i].StreetLine2, actual.AddressList[i].StreetLine2);
                Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.AreEqual(expected.AddressList[i].State, actual.AddressList[i].State);
                Assert.AreEqual(expected.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.AreEqual(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);
            }

        }
    }
}
