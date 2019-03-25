using System;
using System.Collections.Generic;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            // arrange
            var repo = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "fbaggins@gmail.com",
                FirstName = "Frodo",
                LastName = "Baggins"
            };
            // act
            var actual = repo.Retrieve(1);
            // assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
        }

        [TestMethod]
        public void RetrieveExistingWithAddress()
        {
            // arrange
            var repo = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "fbaggins@gmail.com",
                FirstName = "Frodo",
                LastName = "Baggins",
                AddressList = new List<Address>()
                {
                     new Address()
                        {
                            AddressType = "1",
                            StreetLine1 = "Bag End",
                            StreetLine2 = "Bagshot Row",
                            City = "Nashville",
                            StateProvince = "TN",
                            Country = "USA",
                            PostalCode = "37215"
                        },
                     new Address()
                        {
                            AddressType = "2",
                            StreetLine1 = "665 Grassmere",
                            City = "Nashville",
                            StateProvince = "TN",
                            Country = "USA",
                            PostalCode = "37111"
                        }
                }
            };
            // act
            var actual = repo.Retrieve(1);

            // assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);

            // arrange
            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expected.AddressList[1].AddressType, actual.AddressList[1].AddressType);
                Assert.AreEqual(expected.AddressList[1].StreetLine1, actual.AddressList[1].StreetLine1);
                Assert.AreEqual(expected.AddressList[1].City, actual.AddressList[1].City);
                Assert.AreEqual(expected.AddressList[1].StateProvince, actual.AddressList[1].StateProvince);
                Assert.AreEqual(expected.AddressList[1].Country, actual.AddressList[1].Country);
                Assert.AreEqual(expected.AddressList[1].PostalCode, actual.AddressList[1].PostalCode);
            }
        }
    }
}
