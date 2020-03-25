using System;
using System.Collections.Generic;
using System.Text;

namespace App
{
    class User
    {
        string mail;
        string plainTextPassword;

        public User(string mail, string plainTextPassword)
        {
            this.mail = mail;
            this.plainTextPassword = plainTextPassword;
        }

        public User(string mail, string plainTextPassword, string phoneNumber, string address, string age)
            :this(mail,plainTextPassword)
        {
            PhoneNumber = phoneNumber;
            Address = address;
            Age = age;
        }

        public string PhoneNumber { get; private set; }
        public string Address { get; private set; }
        public string Age { get; private set; }
    }
}
