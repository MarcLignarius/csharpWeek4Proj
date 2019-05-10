using System;
using System.Collections.Generic;

namespace HairSalon.Models
{
    public class Client
    {
        private string _firstName;
        private string _lastName;
        private string _phoneNumber;
        private string _emailAddress;
        private static List<Client> _instances = new List<Client> {};

        public Client (string firstName, string lastName, string phoneNumber, string emailAddress)
        {
            _firstName = firstName;
            _lastName = lastName;
            _phoneNumber = phoneNumber;
            _emailAddress = emailAddress;
            _instances.Add(this);
        }

        public string GetFirstName()
        {
            return _firstName;
        }

        public void SetFirstName(string newFirstName)
        {
            _firstName = newFirstName;
        }

        public string GetLastName()
        {
            return _lastName;
        }

        public void SetLastName(string newLastName)
        {
            _lastName = newLastName;
        }

        public string GetPhoneNumber()
        {
            return _phoneNumber;
        }

        public void SetPhoneNumber(string newPhoneNumber)
        {
            _phoneNumber = newPhoneNumber;
        }

        public string GetEmailAddress()
        {
            return _emailAddress;
        }

        public void SetEmailAddress(string newEmailAddress)
        {
            _emailAddress = newEmailAddress;
        }

        public static List<Client> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }
    }
}