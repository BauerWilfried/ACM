using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Common;

namespace Acme.Tests
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesValidTest()
        {
            //Arrange
            string testphrase = "BilboBaggins";
            var expected = "Bilbo Baggins";

            //Act
            var actual = testphrase.InsertSpaces();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void InsertSpacesWithExistingSpacesTest()
        {
            //Arrange
            string testphrase = "Bilbo Baggins";
            var expected = "Bilbo Baggins";

            //Act
            var actual = testphrase.InsertSpaces();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
