using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhoneBook;

namespace Phonebook.Tests
{
    [TestClass]
    public class PhoneDirectoryTests
    {
        private PhoneDirectory _target;

        [TestInitialize]
        public void Setup()
        {
            _target = new PhoneDirectory();
        }

        [TestMethod]
        public void PutNumber_Davis123456_ShouldContainDavis()
        {
            // Arrange
            var name = "Davis";
            var number = "123456";

            // Act
            _target.PutNumber(name, number);

            // Assert
            Assert.AreEqual(number, _target.GetNumber(name));
        }

        [TestMethod]
        public void GetNumber_Davis_ShouldBeNoNumber()
        {
            // Act
            var number = _target.GetNumber("Davis");

            // Assert
            Assert.AreEqual(null, number);
        }
    }
}
