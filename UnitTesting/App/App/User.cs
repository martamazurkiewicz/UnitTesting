using System;
using System.Collections.Generic;
using System.Text;

namespace App
{
    /// <summary>
    /// User class - used for signing in.
    /// </summary>
    class User
    {
        /// <summary>
        /// User class fields - mail and plainTextPassword.
        /// </summary>
        string mail;
        string plainTextPassword;

        /// <summary>
        /// User class constructor.
        /// </summary>
        /// <param name="mail"></param>
        /// <param name="plainTextPassword"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="address"></param>
        /// <param name="age"></param>
        public User(string mail, string plainTextPassword, string phoneNumber, string address, string age)
        {
            this.mail = mail;
            this.plainTextPassword = plainTextPassword;
            PhoneNumber = phoneNumber;
            Address = address;
            Age = age;
        }

        /// <summary>
        /// User class property - phone number.
        /// </summary>
        public string PhoneNumber { get; private set; }
        /// <summary>
        /// User class property - address.
        /// </summary>
        public string Address { get; private set; }
        /// <summary>
        /// User class property - age.
        /// </summary>
        public string Age { get; private set; }
    }
}
