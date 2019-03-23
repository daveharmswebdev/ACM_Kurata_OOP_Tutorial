using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            // arrange
            var customer = new Customer
            {
                FirstName = "James",
                LastName = "Hewitt"
            };
            var expected = "Hewitt, James";
            // act
            var actual = customer.FullName;
            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameTestValid_FirstNameOnly()
        {
            // arrange
            var customer = new Customer
            {
                FirstName = "James"
            };
            var expected = "James";
            // act
            var actual = customer.FullName;
            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameTestValid_LastNameOnly()
        {
            // arrange
            var customer = new Customer
            {
                LastName = "Hewitt"
            };
            var expected = "Hewitt";
            // act
            var actual = customer.FullName;
            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            // arrange
            //var c1 = new Customer
            //{
            //    FirstName = "Bilbo"
            //};
            Customer.InstanceCount += 1;

            var c2 = new Customer
            {
                FirstName = "Bilbo2"
            };
            Customer.InstanceCount += 1;

            var c3 = new Customer
            {
                FirstName = "Bilbo3"
            };
            Customer.InstanceCount += 1;

            // assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [TestMethod]
        public void ValidateValid()
        {
            // arrange
            var customer = new Customer
            {
                LastName = "Baggins",
                EmailAddress = "fbaggins@gmail.com"
            };
            var expected = true;

            // act
            var actual = customer.Validate();

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Validate_InValid_NoLastName()
        {
            // arrange
            var customer = new Customer
            {
                EmailAddress = "fbaggins@gmail.com"
            };
            var expected = false;

            // act
            var actual = customer.Validate();

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Validate_InValid_NoEmail()
        {
            // arrange
            var customer = new Customer
            {
                LastName = "Baggins"
            };
            var expected = false;

            // act
            var actual = customer.Validate();

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Validate_InValid_BadEmail()
        {
            // arrange
            var customer = new Customer
            {
                LastName = "Baggins",
                EmailAddress = "Baggins"
            };
            var expected = false;

            // act
            var actual = customer.Validate();

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Validate_Valid_GoodEmail()
        {
            // arrange
            var customer = new Customer
            {
                LastName = "Baggins",
                EmailAddress = "Baggins@gmail.com"
            };
            var expected = true;

            // act
            var actual = customer.Validate();

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
