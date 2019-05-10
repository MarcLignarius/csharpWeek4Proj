using Microsoft.VisualStudio.TestTools.UnitTesting;
using HairSalon.Models;

namespace HairSalon.Tests
{
    [TestClass]
    public class ClientTest
    {

        [TestMethod]
        public void ClientConstructor_CreatesInstanceOfClient_Client()
        {
          // Arrange
          Client newClient = new Client("Marc", "Davies", "3232866556");

          // Assert
          Assert.AreEqual(typeof(Client), newClient.GetType());
        }

        [TestMethod]
        public void GetFirstName_ReturnsFirstName_String()
        {
          // Arrange
          string firstName = "Marc";
          string lastName = "Davies";
          string phoneNumber = "3232866556";
          Client newClient = new Client(firstName, lastName, phoneNumber);

          // Act
          string result = newClient.GetFirstName();

          // Assert
          Assert.AreEqual(firstName, result);
        }

        [TestMethod]
        public void SetFirstName_SetFirstName_String()
        {
            // Arrange
            string firstName = "Marc";
            string lastName = "Davies";
            string phoneNumber = "3232866556";
            Client newClient = new Client(firstName, lastName, phoneNumber);

            //Act
            string updatedFirstName = "Mimi";
            newClient.SetFirstName(updatedFirstName);
            string result = newClient.GetFirstName();

            //Assert
            Assert.AreEqual(updatedFirstName, result);
        }

        [TestMethod]
        public void GetLastName_ReturnsLastName_String()
        {
          // Arrange
          string firstName = "Marc";
          string lastName = "Davies";
          string phoneNumber = "3232866556";
          Client newClient = new Client(firstName, lastName, phoneNumber);

          // Act
          string result = newClient.GetLastName();

          // Assert
          Assert.AreEqual(lastName, result);
        }

        [TestMethod]
        public void SetLastName_SetLastName_String()
        {
            // Arrange
            string firstName = "Marc";
            string lastName = "Davies";
            string phoneNumber = "3232866556";
            Client newClient = new Client(firstName, lastName, phoneNumber);

            //Act
            string updatedLastName = "Ajili";
            newClient.SetLastName(updatedLastName);
            string result = newClient.GetLastName();

            //Assert
            Assert.AreEqual(updatedLastName, result);
        }

        [TestMethod]
        public void GetPhoneNumber_ReturnsPhoneNumber_String()
        {
            // Arrange
            string firstName = "Marc";
            string lastName = "Davies";
            string phoneNumber = "3232866556";
            Client newClient = new Client(firstName, lastName, phoneNumber);

            // Act
            string result = newClient.GetPhoneNumber();

            // Assert
            Assert.AreEqual(phoneNumber, result);
        }

    }
}